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
            History.Add("");
            State = CtrlState.Start;
            Editor.OnlyInteger = onlyInteger;
        }

        public string DoCommandOfCalculator(CommandOfCalculator command) 
        {
            isLastClickOperation = false;
            switch (command) 
            {
                case CommandOfCalculator.MC:
                    Memory.Clear();
                    break;
                case CommandOfCalculator.MR:
                    Editor.Number = Memory.Take().GetNumberString();
                    break;
                case CommandOfCalculator.MS:
                    Memory.Write(new TPNumber(Editor.Number, BaseNumber));
                    break;
                case CommandOfCalculator.M_Plus:
                    Memory.Add(new TPNumber(Editor.Number, BaseNumber));
                    break;
                case CommandOfCalculator.BS:
                    DoCommandOfEditor(TEditor.CommandOfEditor.Backspace);
                    break;
                case CommandOfCalculator.CE:
                    Editor.Clear();
                    break;
                case CommandOfCalculator.C:
                    History[History.Count - 1] = "";
                    SetStartStateOfCalculator();
                    break;
            }
            return Memory.Take().GetNumberString();
        }

        public string DoCommandOfEditor (TEditor.CommandOfEditor command, char ch='0')
        { 
            switch (command)
            {
                case TEditor.CommandOfEditor.AddDigit:
                    if (isLastClickEnter == true)
                        Editor.Clear();
                    Editor.AddDigit(ch);
                    isLastClickEnter = false;
                    break;
                case TEditor.CommandOfEditor.Backspace:
                    if (isLastClickEnter == false && isLastClickOperation == false)
                        Editor.Bs();
                    break;
                case TEditor.CommandOfEditor.Clear:
                    isLastClickEnter = false;
                    Editor.Clear();
                    break;
            }
            isLastClickOperation = false;

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
                //для истории
                History[History.Count - 1] += Proc.GetRightOperand().GetNumberString();
                Editor.Number = "0";
                Proc.SetOperation(command);
                //для истории
                History[History.Count - 1] += Proc.GetState().ToString();
                return Proc.GetLeftOperand().GetNumberString(); ;
            }


            //получаем число и записываем в левый операнд
            var number = new TPNumber(Editor.Number, this.BaseNumber, AccuracyNumber);
            Proc.SetLeftOperand(number);

            //для истории
            History[History.Count - 1] += Proc.GetLeftOperand().GetNumberString();
            //устанавливем операцию
            Proc.SetOperation(command);
            //для истории
            History[History.Count - 1] += Proc.GetState().ToString();
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
            var temp_state = Proc.GetState();
            Proc.SetOperation(command);
            //для истории
            History[History.Count - 1] += Proc.GetRightOperand().GetNumberString();
            //для истории
            History[History.Count - 1] += Proc.GetState().ToString();
            Proc.DoFunction();
            Proc.SetOperation(temp_state);

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

            //для истории
            History[History.Count - 1] += Proc.GetRightOperand().GetNumberString();
            History[History.Count - 1] += "="+Proc.GetLeftOperand().GetNumberString();
            History.Add("");

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
            History[History.Count - 1] = "";
            countOfSwitchOperation = 0;
            isLastClickOperation = false;
            isLastClickEnter = false;
            Editor.Clear();
            Proc.ResetProcessor();
            return Editor.Number;
        }

        public List<string> GetHistory() 
        {
            for (int i=0; i<History.Count; i++)
            {
                History[i] = History[i].Replace("Add", "+");
                History[i] = History[i].Replace("Sud", "-");
                History[i] = History[i].Replace("Dvd", "/");
                History[i] = History[i].Replace("Mul", "X");
                History[i] = History[i].Replace("Rev", "(^-1)");
                History[i] = History[i].Replace("Sqr", "(^2)");
            }
            return History;
        }

    }
}
