using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab2
{
    
    class TMemory
    {
        //число, хранящееся в памяти
        private TPNumber _fNumber;

        //состояние памяти
        private State _fState;

        enum State
        {
            _Off,
            _On
        };

        public TMemory()
        {
            //храним нулевое число - это значение по умолчанию
            _fNumber = new TPNumber(0, 10, 5);
            _fState = State._Off;
        }

        // В объект «память»в поле FNumber записывается копия объекта
        // память устанавливается в состояние «Включена», 
        public void Write(TPNumber num)
        {
            _fNumber = num.Copy();
            _fState = State._On;
        }

        // Создаёт и возвращает копию объекта хранящегося в объекте «память» 
        public TPNumber Take()
        {
            _fState = State._On;
            return _fNumber.Copy();
        }

        // В поле FNumber объекта «память» (тип TMemory) записывается объект
        // полученный в результате сложения числа num
        // и числа, хранящегося в памяти в поле FNumber. 
        public void Add(TPNumber num)
        {
            if (_fState == State._Off)
            {
                Write(num);
            }
            else _fNumber = _fNumber + num;

        }
        
        //В поле числа(FNumber) объекта «память» (тип TMemory) записывается значение по умолчанию
        //Память(поле _fState) устанавливается в состояние _Off.
        public void Clear()
        {
            //храним нулевое число - это значение по умолчанию
            _fNumber = new TPNumber(0, 10, 5);
            _fState = State._Off;
        }

        public string GetState() => _fState.ToString();

        public TPNumber GetNumber() => _fNumber;

    }
}
