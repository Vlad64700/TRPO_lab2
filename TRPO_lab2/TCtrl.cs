using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_lab2
{
    public class TCtrl
    {
        TEditor Editor; //Редактор
        TProc Proc; // процессор
        TMemory Memory; // память
        TPNumber Number; // число
        CtrlState State; // состояние

        bool isLastClickEnter = false; // флаг, устанавливающий, была ли нажата клавиша = в последнйи раз
        bool isLastClickOperation = false; //флаг, устонавливающий была ли нажата клавиша операции в последний раз
        int countOfSwitchOperation = 0;

        // основание системы сч. числа и точность
        public int BaseNumber = 10;
        public int AccuracyNumber = 5;

        public enum CommandOfCalculator
        {
            MC, //отчистить память
            MR, //вывести на экран значения из памяти
            MS, //сохранить число на экране в память
            M_Plus, // добавить к числу в памяти число на экране
            BS, //Забой символа
            CE, // полная отчистка ваще
            C // отчистка поля для ввода
        }
        public enum CtrlState
        {
            Start, //начальное состояние
            Editing, // Ввод и редактирования
            ExpressionDone, // выражение вычислено
            OperationDone, // Операция выполнена
            ValueDone, // значение выведено
            OperationChanged, // операция изменена
            Error // ошибка 
        }

        private List<string> History;

        //конструктор, в нем иницилизируется все значения
        public TCtrl(int BaseNumber=10, bool onlyInteger=false) 
        {
            this.BaseNumber = BaseNumber;
            Editor = new TEditor();
            Proc = new TProc();
            Memory = new TMemory();
            Number = new TPNumber(0, BaseNumber);
            History = new List<string>();
            State = CtrlState.Start;
            Editor.OnlyInteger = onlyInteger;
        }

        public void DoCommandOfCalculator(CommandOfCalculator command) 
        {
            isLastClickOperation = false;
            switch (command) 
            {
                case CommandOfCalculator.MC:
                    break;
                case CommandOfCalculator.MR:
                    break;
                case CommandOfCalculator.MS:
                    break;
                case CommandOfCalculator.M_Plus:
                    break;
                case CommandOfCalculator.BS:
                    DoCommandOfEditor(TEditor.CommandOfEditor.Backspace);
                    break;
                case CommandOfCalculator.CE:
                    Editor.Clear();
                    break;
                case CommandOfCalculator.C:
                    SetStartStateOfCalculator();
                    break;
            }
        }

        public string DoCommandOfEditor (TEditor.CommandOfEditor command, char ch='0')
        {

            isLastClickOperation = false;
            switch (command)
            {
                case TEditor.CommandOfEditor.AddDigit:
                    if (isLastClickEnter == true)
                        Editor.Clear();
                    Editor.AddDigit(ch);
                    isLastClickEnter = false;
                    break;
                case TEditor.CommandOfEditor.Backspace:
                    if (isLastClickEnter == false)
                        Editor.Bs();
                    break;
                case TEditor.CommandOfEditor.Clear:
                    isLastClickEnter = false;
                    Editor.Clear();
                    break;
            }

            return Editor.Number;
        }

        public string DoOperation(TProc.State command)
        {
            countOfSwitchOperation++;
            isLastClickEnter = false;
            var number_temp = Editor.Number;

            if (countOfSwitchOperation>1)
            {
                Proc.SetRightOperand(new TPNumber(Editor.Number, BaseNumber, AccuracyNumber));
                Proc.DoOperation();
                Editor.Number = "0";
                return Proc.GetLeftOperand().GetNumberString(); ;
            }


            //получаем число и записываем в левый операнд
            var number = new TPNumber(Editor.Number, BaseNumber, AccuracyNumber);
            Proc.SetLeftOperand(number);
            //устанавливем операцию
            Proc.SetOperation(command);
            Editor.Clear();
            isLastClickOperation = true; // у нас последее нажатие - нажатие клаивиши операции
            return number_temp;
        }
        public string DoFunction(TProc.State command)
        {
            isLastClickEnter = false;
            isLastClickOperation = false;
            //получаем число и записываем в правый операнд
            var number = new TPNumber(Editor.Number, BaseNumber, AccuracyNumber);
            Proc.SetRightOperand(number);
            //устанавливем операцию
            Proc.SetOperation(command);
            Proc.DoFunction();

            Editor.Number = Proc.GetRightOperand().GetNumberString();
           
            return Editor.Number;
        }

        public string CalculateExpression() 
        {
            countOfSwitchOperation = 0;
            if (isLastClickOperation == true)
            {
                if (isLastClickEnter == false)
                    Proc.SetRightOperand(Proc.GetLeftOperand());
                Proc.DoOperation();
                Editor.Number = Proc.GetLeftOperand().GetNumberString();
                isLastClickEnter = true;

                return Editor.Number;
            }

            if (isLastClickEnter==true)
            {
                Proc.DoOperation();
                Editor.Number = Proc.GetLeftOperand().GetNumberString();

                return Editor.Number;
            }
            isLastClickEnter = true;

            // запоминаем правый операнд если последним действием не было нажатие клавиши равно
            var number = new TPNumber(Editor.Number, BaseNumber, AccuracyNumber);
            Proc.SetRightOperand(number);


            //выполняем операцию или функцию по факту выполнится один фиг что-то одно, но по методе надо именно так)))))
            Proc.DoOperation();

            Editor.Number = Proc.GetLeftOperand().GetNumberString();

            isLastClickOperation = false;
            return Editor.Number;
            
        }
        public string ChangeSign()
        {
            Editor.ChangeSign();
            return Editor.Number;
        }
        
        public string SetStartStateOfCalculator()
        {
            countOfSwitchOperation = 0;
            isLastClickOperation = false;
            isLastClickEnter = false;
            Editor.Clear();
            Proc.ResetProcessor();
            return Editor.Number;
        }

    }
}
