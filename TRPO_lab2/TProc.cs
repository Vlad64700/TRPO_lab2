using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab2
{
 
    public class TProc
    {
        public TPNumber Lop_Res; // левый операнд
        public TPNumber Rop; // правый операнд
        public State Operation; // операция которая будет выолняться
        public bool isActive=false;//кое-что для одноно костыля, для приоритета
        public enum State { None, Add, Sub, Mul, Dvd, Rev, Sqr }
        // конструктор, иницилизирует значениями по-умолчанию
        public TProc() 
        {
            Lop_Res = new TPNumber(0, 10, 5);
            Rop = new TPNumber(0, 10, 5);
            Operation = State.None;
        }

        // сброс процесса, сбрасывает все свойства
        public void ResetProcessor()
        {
            Lop_Res = new TPNumber(0, 10, 5);
            Rop = new TPNumber(0, 10, 5);
            Operation = State.None;
        }
        public void ResetOperation() 
        {
            Operation= State.None;
        }
        public void DoOperation() 
        {

            if (Operation == State.None)
            {
                Lop_Res = Rop;
                return;
            }

            switch (Operation)
            {
                case State.Add:
                    Lop_Res = Lop_Res + Rop;
                    break;
                case State.Sub:
                    Lop_Res = Lop_Res - Rop;
                    break;
                case State.Mul:
                    Lop_Res = Lop_Res * Rop;
                    break;
                case State.Dvd:
                    Lop_Res = Lop_Res / Rop;
                    break;

            }
        }

        public void DoFunction() 
        {

            switch (Operation)
            {
                case State.Sqr:
                    Rop = Rop.Square();
                    break;
                case State.Rev:
                    Rop = Rop.Invert();
                    break;
            }

        }

        public TPNumber GetLeftOperand() 
        {
            return Lop_Res.Copy();
        }
        public void SetLeftOperand(TPNumber r)
        {
            Lop_Res = r;
        }

        public TPNumber GetRightOperand()
        {
            return Rop.Copy();
        }
        public void SetRightOperand(TPNumber r)
        {
            Rop = r;
        }

        public State GetState() 
        {
            return Operation;
        }

        public void SetOperation(State st) => Operation = st;


    }



}
