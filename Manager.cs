using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    class Manager
    {
        private List<CarsQueue> CarsQueues = new List<CarsQueue>();
        private List<Operation> Operations = new List<Operation>();
        private List<Fact> Facts = new List<Fact>();
        private List<Car> Cars = new List<Car>();
        //Генератор случайных чисел
        private Random RND = new Random();
        //Визуальные компоненты для вывода списка выполненых на шаге действий и создания отчета
        private TextBox _FactCar_TB, _Stat_TB;
        // Поле, определяющее шанс приезда нового автомобиля в автосервис
        private int _Chance = 2;
        // Поле, определяющее количество автомобилей, которые могут приехать в автосервис за один шаг
        private int _CountCars = 1;
        public Manager(TextBox FactCar_TB, TextBox Stat_TB)
        {
            _FactCar_TB = FactCar_TB;
            _Stat_TB = Stat_TB;
        }
        public Manager()
            : this(null, null)
        {
        }
        public int Chance
        {
            set
            {
                if (value >= 1 && value <= 5)
                    _Chance = value;
            }
        }
        public int CountCars
        {
            set
            {
                if (value >= 1 && value <= 3)
                    _CountCars = value;
            }
        }
        //События "Новый автомобиль по графику", "Новый обычный автомобиль"
        private event EventHandler<CarArgs> NewVipCarEvent, NewCommonCarEvent;
        //Активатор события "Новый автомобиль"
        private void OnNewCar()
        {
            CarArgs E = new CarArgs();
            E.car = new Car(RND.Next(2) == 0, RND.Next(1, 5), RND.Next(3, 6), RND.Next(3, 6), RND.Next(3, 6));
            //Добавление автомобиля в список автомобилей
            AddCar(E.car);
            E.PrintResult = PrintResult;
            if (E.car.IsGraph)
            {
                if (NewVipCarEvent != null)
                {
                    NewVipCarEvent(this, E);

                }

            }
            else
            {
                if (NewCommonCarEvent != null)
                {
                    NewCommonCarEvent(this, E);

                }
            }
            if (E.car != null)
                PrintResult("Не найдена подходящая очередь, <" + E.car + "> уехал из автосервиса");
        }
        //Событие "Шаг"
        private event EventHandler<FactArgs> RunTimeEvent;

        //Активация события "Шаг"
        private void OnRunTime()
        {
            if (RunTimeEvent != null)
            {
                FactArgs E = new FactArgs();
                E.PrintResult = PrintResult;
                E.PrintFact = PrintFact;
                RunTimeEvent(this, E);
            }

        }
        //Метод для отображения выполненого действия в визуальном компоненте
        private void PrintResult(string s)
        {
            if (_FactCar_TB != null)
                _FactCar_TB.AppendText(s + Environment.NewLine);
        }
        //Метод фиксации факта заправки
        private void PrintFact(Fact Item)
        {
            Facts.Add(Item);
        }

        //Метод для добавления автомобиля в список автомобилей на заправке
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        //Метод для активации событий "Шаг" и "Новый автомобиль"
        public void OnTimer()
        {
            _FactCar_TB.Clear();
            OnRunTime();
            if (RND.Next(_Chance) == 0)
                for (int i = 1; i <= _CountCars; i++)
                    OnNewCar();
        }

        //Метод для расчета статистики операций
        public void SetStatOperation()
        {
            //Построение LINQ запроса для каждой операции
            var res =
                // Для каждого типа операции
                from to in Type_operation.Types
                //Отбираются соответсвующие факты заправки
                      join elem in Facts on to equals Type_operation.Types[elem.OperationType]
                //Которые сохраняются в структуру TO
                into TO
                //Сортировка по номеру операции
                      orderby to.Length
                //Создание анонимного класса
                      select new
                      {
                          // Первое поле которого является название операции
                          Type_operation = to,
                          //Отбираются факты из структуры "TO"
                          Car = from car in Cars
                                join fact in TO on car.ID equals fact.CarId
                                // Выполняется сортировка по типу автомобиля(по графику/ обычный)
                                orderby car.IsGraph descending
                                //Создается анонимный класс
                                select new
                                {
                                    //первое поле которого является тип автомобиля
                                    graph = car.IsGraph,
                                    // второе поле является номером автомобиля
                                    Id = car.ID,
                                    //третье поле является временем автомобиля, проведенного на операции
                                    Time = fact.Time,
                                }
                      };
            // Таким образом в переменной "res" получается двухуровневая структура: операция - автомобиль.
            //Для каждой комбинации уровней в поле "Time" указывается время, проведенное автомобилем на операции
            _Stat_TB.Clear();
            //Перебор первого уровня структуры
            foreach (var elem in res)
            {
                //Вывод названия операции
                _Stat_TB.AppendText(elem.Type_operation + Environment.NewLine);
                //Перебор второго уровня
                foreach (var car in elem.Car)
                    //Вывод автомобиля и времени, проведенного автомобилем на операции
                    _Stat_TB.AppendText("       " +(car.graph ? "По графику" : "Обычная очередь") + " Автомобиль" + "(" + car.Id + ") " + car.Time + Environment.NewLine);
            }

        }
        //Метод добавления новой очереди
        public void AddQueue(CarsQueue Queue)
        {
            CarsQueues.Add(Queue);
            if (Queue.IsGraph)
                //Фиксация заинтересованности очереди в событии "Новый автомобиль"
                NewVipCarEvent += Queue.NewCar;
            else
                NewCommonCarEvent += Queue.NewCar;
            foreach (Operation operation in Operations)
                //Если очередь предназначена для данной операции
                if (operation.OperationType == Queue.OperationType)
                {
                    //Взаимная фиксация заинтересованности в событиях
                    //между очередью и операцией. Очередь заинтересована
                    //в событии "Операция свободна", а операция в событии
                    //"Первый автомобиль в очереди"
                    operation.IsReadyEvent += Queue.SetOperation;
                    Queue.SingleCarEvent += operation.WaitSingle;
                }
                //Иначе
                else
                {
                    //Подписка очереди на событие "Возвращение автомобиля в очереди"
                    operation.IsReturnCarEvent += Queue.ReturnOperation;
                    //Подписка очереди на событие "Удаление автомобиля из очередей"
                    operation.IsDelCarFromQueue += Queue.DelCarFromQueue;
                    //Подписка очереди на событие "Проверка нахождения автомобиля на операциях"
                    Queue.IsCarOnOperation +=operation.CarOnOperation;
                }
        }

        //Метод удаления очереди
        public void RemoveQueue(CarsQueue Queue)
        {
            CarsQueues.Remove(Queue);
            //Отмена заинтересованности очереди в событии "Новый автомобиль"
            if (Queue.IsGraph)
                NewVipCarEvent -= Queue.NewCar;
            else
                NewCommonCarEvent -= Queue.NewCar;
            foreach (Operation operation in Operations)
                if (operation.OperationType == Queue.OperationType)
                    //Отмена заинтересованности очереди в событии "Операция свободна"
                    operation.IsReadyEvent -= Queue.SetOperation;
                else
                {
                    //Отмена заинтересованности очереди в событии "Возвращение автомобиля в очереди"
                    operation.IsReturnCarEvent -= Queue.ReturnOperation;
                    //Отмена заинтересованности очереди в событии "Удаление автомобиля из очередей"
                    operation.IsDelCarFromQueue -= Queue.DelCarFromQueue;

                }
        }
        //Метод добавления новой операции
        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
            //Фиксация заинтересованности операции в событии "Шаг"
            RunTimeEvent += operation.RunTime;
            foreach (CarsQueue Queue in CarsQueues)
                if (operation.OperationType == Queue.OperationType)
                {
                    operation.IsReadyEvent += Queue.SetOperation;
                    Queue.SingleCarEvent += operation.WaitSingle;
                }
                else
                {
                    operation.IsReturnCarEvent += Queue.ReturnOperation;
                    operation.IsDelCarFromQueue += Queue.DelCarFromQueue;
                    Queue.IsCarOnOperation +=operation.CarOnOperation;
                }

        }

        //Метод удаления операции
        public void RemoveOperation(Operation operation)
        {
            Operations.Remove(operation);
            //Отмена заинтересованности операции в событии "Шаг"
            RunTimeEvent -= operation.RunTime;
            foreach (CarsQueue Queue in CarsQueues)
                if (operation.OperationType == Queue.OperationType)
                    //Отмена заинтересованности операции в событии "Первый автомобиль в очереди"
                    Queue.SingleCarEvent -= operation.WaitSingle;
                else
                    //Отмена заинтересованности операции в событии "Проверка нахождения автомобиля на операциях"
                    Queue.IsCarOnOperation -= operation.CarOnOperation;

        }

    }
}
