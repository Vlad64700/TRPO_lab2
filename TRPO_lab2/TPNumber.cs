using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab2
{
    public class TPNumber
    {
        private UPNumber _number;

        //конструктор, принимает вещественное число, систему счисления и точность
        public TPNumber(double n, int b, int c=6)
        {
            if (b < 2 || b > 16)
                throw new Exception("Недопустимая система счисления");
            //внутреннее представление числа
            //храним в десятичной системе счисления!
            //Поэтому если число не десятичное - переводим.
            if (b != 10)
                n = Conver_p_10.dval(n.ToString(), b);
            _number = new UPNumber
            {
                B = b,
                N = n,
                C = c
            };
        }

        //конструктор, принимает строковое представление числа
        public TPNumber(string n, int b, int c=6)
        {
            if (b < 2 || b > 16)
                throw new Exception("Недопустимая система счисления");

            if (b != 10)
                n = Conver_p_10.dval(n, b).ToString();
            _number = new UPNumber
            {
                B = b,
                N = double.Parse(n),
                C = c
            };
        }

        //геттеры, сеттеры для всех полей класса

        //получить число в 10-й системе счисления
        public double GetNumberDoubleDecimal() => _number.N;

        //переводим число из 10-й системы, в которой храним, в систему по основанию b
        public double GetNumberDouble() => _number.B != 10? 
            double.Parse(Conver_10_p.Do(_number.N, _number.B)) : _number.N;

        public string GetNumberString() => _number.B != 10 ?
            Conver_10_p.Do(_number.N, _number.B) : _number.N.ToString();

        public int GetBaseNumber() => _number.B;

        public string GetBaseString() => _number.B.ToString();

        public int GetAccuracyNumber() => _number.C;

        public string GetAccuracyString() => _number.C.ToString();

        public void SetBaseNumber(int b) => _number.B = b;

        public void SetBaseString(string b) => _number.B = int.Parse(b);

        public void SetAccuracyNumber(int c) => _number.C = c;

        public void SetAccuracyString(string c) => _number.C = int.Parse(c);

        public TPNumber Copy() => new TPNumber(_number.N, _number.B, _number.C);

        //перегружаем арифметические операторы 
        public static TPNumber operator +(TPNumber num1, TPNumber num2)
            => new TPNumber(num1.GetNumberDoubleDecimal() + num2.GetNumberDoubleDecimal(),
                num1.GetBaseNumber(), num1.GetAccuracyNumber());

        public static TPNumber operator -(TPNumber num1, TPNumber num2)
            => new TPNumber(num1.GetNumberDoubleDecimal() - num2.GetNumberDoubleDecimal(),
                num1.GetBaseNumber(), num1.GetAccuracyNumber());

        public static TPNumber operator *(TPNumber num1, TPNumber num2)
            => new TPNumber(num1.GetNumberDoubleDecimal() * num2.GetNumberDoubleDecimal(),
                num1.GetBaseNumber(), num1.GetAccuracyNumber());

        public static TPNumber operator /(TPNumber num1, TPNumber num2)
            => new TPNumber(num1.GetNumberDoubleDecimal() / num2.GetNumberDoubleDecimal(),
                num1.GetBaseNumber(), num1.GetAccuracyNumber());

        public TPNumber Invert() => new TPNumber(1 / _number.N, _number.B, _number.C);

        public TPNumber Square() => new TPNumber(_number.N * _number.N, _number.B, _number.C);

    }
}
