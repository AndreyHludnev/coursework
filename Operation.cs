using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    // Класс, позволяющий в качестве параметра события передать экземпляр автомобиля
    public class CarArgs : OnlyPrintArgs 
    {
        public Car car;
        public bool OnOperation = false;
    }

    // Делегат, который указывает метод размещения факта обслуживания в общий список фактов
    public delegate void FactCalcBack(Fact e);
    // Класс, позволяющий в качестве параметра события передать метод для фиксации факта обслуживания
    public class FactArgs : OnlyPrintArgs 
    {
        public FactCalcBack PrintFact;
    }
    // Делегат, который будет указывать метод размещения нового автомобиля на операции 
    public delegate bool OperationCalcBack(CarArgs e);
    public class OperationArgs : OnlyPrintArgs
    {
        public OperationCalcBack SetOperation;
        // Поле, указывающее готова ли операция разместить автомобиль
        public bool IsReady; 
    }


    public class Operation
    {
        private static int Counter;
        private int _ID;
        private int _OperationType;
        private TextBox _TB;
        private Car _Current;
        // Поле, выполняющее функцию счетчика времени, которое автообиль провел на операции
        private int _Timer = 0;
        private string _Name;
        public Operation(int OperationType, TextBox TB)
        {
            _ID = ++Counter;
            _OperationType = (OperationType >= 0 && OperationType <= Type_operation.Types.Length) ? OperationType : 0;
            _Name = _ID + " Операция :" + Type_operation.Types[_OperationType];
            _TB = TB;
            if (TB != null)
                TB.Clear();
        }
        public Operation()
            : this(1, null)
        {
        }
        public override string ToString()
        {
            return _Name;
        }


        public int OperationID
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
                if (OperationType >= 0 && OperationType <= Type_operation.Types.Length)
                    _OperationType = value;
                else throw new Exception("Номер видов операций должен быть в диапозоне от 0 до 3");
            }
        }

        public Car Current
        {
            get
            {
                return _Current;
            }
        }
        
        // Метод, позволяющий разместить автомобиль на операцию
        private bool SetCar(CarArgs E)
        {
            //Проверка, что автомобиль существует
            if (E.car != null)
                //Проверка, что на операции нет автомобиля
                if (_Current == null)
                {
                    //Размещение автомобиля
                    _Current = E.car;
                    if (_TB != null)
                        _TB.Text = E.car.ToString();
                    //Вывод описания размещения автомобиля
                    if (E.PrintResult != null)
                        E.PrintResult(this + ": поступил на операцию '" + Type_operation.Types[_OperationType] +
                            "' <" + E.car + ">");
                }
                else
                {
                    if (E.PrintResult != null)
                        E.PrintResult(this + ": <" + E.car + "> не смог разместиться на операции '" + Type_operation.Types[_OperationType]
                            + "> ");
                }
        //Метод возвращает значение true если операция осталась свободна, если автомобиль разместился на операции возвращает значение false
            return _Current == null; 
        }
        
        // Событие "Возвращение автомобиля в очереди"
        public event EventHandler<CarArgs> IsReturnCarEvent;
        
        // Событие "Удаление автомобиля из очередей"
        public event EventHandler<CarArgs> IsDelCarFromQueue;
       
        // Событие "Операция свободна"
        public event EventHandler<OperationArgs> IsReadyEvent;

        // Активация события "Операция свободна"
        private void OnIsReady(CalcBack PrintResult) 
        {
            //Событие генерируется, если операция свободна
            if (IsReadyEvent != null && _Current == null)
            {
                //Создание класса параметра события
                OperationArgs e = new OperationArgs();
                e.PrintResult = PrintResult;
                //указание метода размещения автомобиля на операции
                e.SetOperation = SetCar;
                e.IsReady = true;
                //Генерация события
                IsReadyEvent(this, e);
                // Активация события "Удаление автомобиля из очередей
                if (IsDelCarFromQueue != null)
                {
                    //Создание класса параметра события
                    CarArgs E = new CarArgs();
                    //Размещение автомобиля на операции в экземпляр класса автомобиля
                    E.car = _Current;
                    E.PrintResult = e.PrintResult;
                    //Генерация события
                    IsDelCarFromQueue(this, E);
                }
            }
        }

        // Метод, обрабатывающий событие "Автомобиль на операции"
        public void CarOnOperation(object sender, CarArgs e) 
        {
            //Обработка происходит, если автомобиль существует
            if (e.car != null)
                // Проверка, находится ли данный автомобиль на операции
                if (_Current == e.car && e.car[_OperationType] != 0)
                    //Изменение значения поле, указывающее находится ли уже данный автомобиль на операции
                    e.OnOperation = true;
        }

        // Метод, обрабатывающий событие "Шаг"
        public void RunTime(object sender, FactArgs e)
        {
            //Обработка производится если на операции есть автомобиль
            if (_Current != null)
            {
                _Timer++;
                //Если время таймера равен времени, которое необходимо
                //автомобилю для прохождения операции
                if (_Timer == _Current[_OperationType])
                {
                    // Время, которое необходимо автомобилю на прохождение данной операции обнуляется
                    _Current[_OperationType] = 0;
                    // Фиксация факта прохождения операции
                    if (e.PrintFact != null)
                        e.PrintFact(new Fact(_Current.ID, _OperationType, _Timer, _Current.IsGraph));
                    //Таймер обнуляется
                    _Timer = 0;
                    //Очистка визуального компонента
                    if (_TB != null)
                        _TB.Clear();
                    //Вывод факта завершения обслуживания автомобиля
                    if (e.PrintResult != null)
                        e.PrintResult(this + " закончила обслуживание <" + _Current + ">");
                    // Если автобиль прошел все операции, то он уезжает
                    if (_Current[0] == 0 && _Current[1] == 0 && _Current[2] == 0 && _Current[3] == 0)
                    {
                        if (e.PrintResult != null)
                            e.PrintResult(this + " уехал из автосервиса <" + _Current + ">");
                    }
                    //Иначе, происходит активация события "Возращение автомобиля в очереди"
                    else
                    {
                        CarArgs E = new CarArgs();
                        E.car = _Current;
                        E.PrintResult = e.PrintResult;
                        IsReturnCarEvent(this, E);
                    }
                    //Автомобиль удаляется с операции
                    _Current = null;
                    OnIsReady(e.PrintResult);
                }

            }
            // Иначе вызов метода, обрабатывающего событие "Первый автомобиль в очереди"
            else
                OnIsReady(e.PrintResult);
        }

        // Метод, обрабатывающий событие "Первый автомобиль в очереди"
        public void WaitSingle(object sender, OnlyPrintArgs e)
        {
            OnIsReady(e.PrintResult);

        }

    }
}
