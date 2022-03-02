using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public class CarsQueue
    {
        private static int Counter;
        private int _ID;
        private bool _IsGraph;
        private int _OperationType;
        //Список автомобилей в очереди
        private Queue<Car> _Queue = new Queue<Car>();
        private ListBox _LB;
        private string _Name;
        public CarsQueue(bool IsGraph, int OperationType, ListBox LB)
        {
            if (OperationType >= 0 && OperationType <= Type_operation.Types.Length)
            {
                _ID = ++Counter;
                _OperationType = OperationType;
                _IsGraph = IsGraph;
                _LB = LB;
                _Name = "Очередь" + _ID + "(для " + (_IsGraph ? " автомобилей по графику" : " обычных автомобилей") + " на операцию '" + Type_operation.Types[_OperationType] + "'";
            }
        }
        public CarsQueue()
            : this(true, 0, null)
        {
        }
        public override string ToString()
        {
            return _Name;
        }

        public int QueueNumber
        {
            get
            {
                return _ID;
            }
        }

        public int OperationType
        {
            get
            {
                return _OperationType;
            }
            set
            {
                if (value >= 0 && value <= Type_operation.Types.Length)
                    _OperationType = value;
            }
        }

        public bool IsGraph
        {
            get
            {
                return _IsGraph;
            }
        }
        //Событие "Первый автомобиль в очереди"
        public event EventHandler<OnlyPrintArgs> SingleCarEvent;
        //Событие "Проверка нахождения автомобиля на операциях"
        public event EventHandler<CarArgs> IsCarOnOperation;

        //Активация события "Первый автомобиль на операции"
        private void OnSingleCar(CalcBack PrintResult)
        {
            //Событие генерируется если поступивший автомобиль первый в очереди
            if (SingleCarEvent != null && _Queue.Count == 1)
            {
              // Создания параметров события
                OnlyPrintArgs E = new OnlyPrintArgs();
                E.PrintResult = PrintResult;
               //Генерация события
                SingleCarEvent(this, E);
            }
        }

        //Метод, обрабатывающий событие "Новый автомобиль"
        public void NewCar(object sender, CarArgs e)
        {
            //Размещение происходит, если автомобиль существует и тип автомобиля
            //соответсвует типа очереди
            if (e.car != null && e.car.IsGraph == _IsGraph)
            {
                //Добавление автомобиля в очередь
                _Queue.Enqueue(e.car);
                //Отображение в визуальном компоненте
                if (_LB != null)
                    _LB.Items.Add(e.car);
                //Вывод описания факта добавления автомобиля
                if (e.PrintResult != null)
                    e.PrintResult(this + ": добавлен <" + e.car + ">");
                //Если автомобиль размещен в очередь, то другие автомобили не должны
                //разместить его у себя, но они тоже получат информацию о событии
                //"Новый автомобиль". Поэтому параметр события видоизменяется
                e.car = null;
                //Возможная активация события "Первый автмобиль в очереди"
                OnSingleCar(e.PrintResult);
            }
        }

        //Метод, обрабатывающий событие "Размещение автомобиля на операцию"
        public void SetOperation(object sender, OperationArgs e)
        {
            //Обработка производится, если в очереди есть автомобили и операция свободна
            if (_Queue.Count > 0 && e.IsReady)
            {
                //Активация события "Проверка нахождения автомобиля на операциях"
                if (IsCarOnOperation != null)
                {
                    CarArgs E = new CarArgs();
                    //Удаление автомобиля из очереди
                    E.car = _Queue.Dequeue();
                    //Удаление автомобиля из визуального компонента
                    _LB.Items.Remove(E.car);
                    //Генерация события
                    IsCarOnOperation(this, E);

                    //Если после выполнения события "Проверка нахождения автомобиля на операциях"
                    //поле OnOperation остается false, тогда происходит размещения автомобиля на операцию
                    if (!E.OnOperation)
                    {
                        if (e.PrintResult != null)
                            e.PrintResult(this + ": уехал <" + E.car + ">");
                        E.PrintResult = e.PrintResult;
                        e.IsReady = e.SetOperation(E);
                    }
                    // Иначе размещение не происходит и выводится информация об удалении
                    // автомобиля из очереди
                    else
                    {
                        if (e.PrintResult != null)
                            e.PrintResult(this + ": удален <" + E.car + ">");
                    }
                }
            }
        }

        //Метод, обрабатывающий событие "Возращение автомобиля в очереди"
        public void ReturnOperation(object sender, CarArgs e)
        {
            //Возвращение возможно, если автомобиль существует, его тип соответсвует типу очереди
            // и автомобиль ещё не прошел операцию к которой ведет данная очередь 
            if  (e.car != null && e.car.IsGraph == _IsGraph && e.car[_OperationType] != 0)
            {
                 //Добавление автомобиля
                    _Queue.Enqueue(e.car);
                //Отображение в визуальном компоненте
                    if (_LB != null)
                        _LB.Items.Add(e.car);
                //Вывод описания факта возвращения автомобиля
                    if (e.PrintResult != null)
                        e.PrintResult(this + ": возвращен <" + e.car + ">");
                //Возможная активация события "Первый автмобиль в очереди"
                    OnSingleCar(e.PrintResult);
            }
        }

        //Метод, обрабатывающий событие "Удаление автомобиля из очередей
        public void DelCarFromQueue(object sender, CarArgs e)
        {
            //Если очередь содержит автомобиль, переданный методу
            if (_Queue.Contains(e.car))
            {
                Queue<Car> _NewQueue = new Queue<Car>();
                //Запись всех автомобилей, не являющихся автомобилем, переданным методу, в новую очередь
                for (int i = 0; i < _Queue.Count; i++)
                {
                    if (_Queue.ElementAt(i) != e.car)
                    {
                        _NewQueue.Enqueue(_Queue.ElementAt(i));
                    }
                }
                _Queue = _NewQueue;
                _LB.Items.Remove(e.car);
                e.PrintResult(this + "удален <" + e.car + ">");

            }
        }
    }
}



