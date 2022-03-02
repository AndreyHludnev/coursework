using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication20
{
    public delegate void CalcBack(string a);

    public class OnlyPrintArgs : EventArgs
    {
        public CalcBack PrintResult;
    }


    public class Car
    {
        private static int Counter;
        private int _ID;
        private bool _IsGraph;
       //Массив, элементы которого хранят время прохождения операций
        private int[] _TimeOperation = new int[Type_operation.Types.Length]; 

        public Car(bool IsGraph, int TimeWash, int TimeZam, int TimeBal, int TimeProv)
        {
            _ID = ++Counter;
            _IsGraph = IsGraph;
            //Время прохождения операции "мойка" может быть от 1 до 5 минут
            _TimeOperation[0] = (TimeWash >= 1 && TimeWash <= 5) ? TimeWash : 3;
            // Время прохождения остальных операции может быть от 3 до 6 минут
            _TimeOperation[1] = (TimeZam >= 3 && TimeZam <= 6) ? TimeZam : 4; 
            _TimeOperation[2] = (TimeBal >= 3 && TimeBal <= 6) ? TimeBal : 4;
            _TimeOperation[3] = (TimeProv >= 3 && TimeProv <= 6) ? TimeProv : 4;
        }
        //Конструктор по умолчанию
        public Car()
            : this(false, 3, 4, 4, 4)
        {
        }
        //Строковое представления объекта
        public override string ToString()
        {
            return "Автомобиль" + _ID + "(" + (_IsGraph ? "По графику" : "Обычная очередь") + "Время мойки :" + _TimeOperation[0] + "," + "Время операции 'замена жидкости' :"
                + _TimeOperation[1] + "," + "Время операции 'балансировка колес' :" + _TimeOperation[2] + "," + "Время операции 'проверка электроники' :" + _TimeOperation[3] + ")"; 
        }

        public bool IsGraph
        {
            get
            {
                return _IsGraph;
            }
           
        }

        public int ID
        {
            get
            {
                return _ID;
            }
        }

        public int this[int index]
        {
            get
            {
                return _TimeOperation[index];
            }

            set
            {
                if (index == 1)
                {
                    if ((value >= 1 && value <= 5)||value==0)
                        _TimeOperation[index] = value;
                }
                else
                    if ((value >= 3 && value <= 6) || value == 0 )
                        _TimeOperation[index] = value;
            }

        }
                   
    
    }
}
