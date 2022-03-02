using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public class Fact
    {
        private static int Counter;
        private int _ID;
        private int _OperationType;
        private int _Time;
        private bool _IsGraph;
        private int _CarId;
        public Fact(int CarId, int OperationType, int Time, bool IsGraph)
        {
            //Проверка соответствия типа операции и времени которое может пробыть автомобиль на операции
            if ((OperationType == 0 && Time >= 1 && Time <= 5) || 
                (OperationType > 0 && OperationType <= Type_operation.Types.Length && Time >= 3 && Time <= 6))
            {
                _ID = ++Counter;
                _OperationType = OperationType;
                _Time = Time;
                _IsGraph = IsGraph;
                _CarId = CarId;
            }
            else
                throw new Exception("Параметры записи факта обслуживания заданы неправильно");
        }

        public override string ToString()
        {
            return _ID + " Операция: " + Type_operation.Types[_OperationType] + "," + "Время обслуживания: " + _Time + "," + "Тип очереди автомобиля: " + (_IsGraph ? "По графику" : "Обычная очередь");
        }

        public int ID
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

        }
        public int Time
        {
            get
            {
                return _Time;
            }

        }
        public bool IsGraph
        {
            get
            {
                return _IsGraph;
            }
            set
            {
                _IsGraph = value;
            }
        }

        public int CarId
        {
            get
            {
                return _CarId;
            }
            set
            {
                _CarId = value;
            }
        }
    }
}
