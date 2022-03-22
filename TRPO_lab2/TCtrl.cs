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
        public TCtrl() 
        {
            Editor = new TEditor();
            Proc = new TProc();
            Memory = new TMemory();
            Number = new TPNumber(0,10);
            History = new List<string>();
            State = CtrlState.Start;
        }

        public void DoCommandOfCalculator(CommandOfCalculator command) 
        {
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
                    SetStartStateOfCalculator();
                    break;
                case CommandOfCalculator.C:
                    Editor.Clear();
                    break;
            }
        }

        public string DoCommandOfEditor (TEditor.CommandOfEditor command, char ch='0')
        {
            switch (command)
            {
                case TEditor.CommandOfEditor.AddDigit:
                    Editor.AddDigit(ch);
                    break;
                case TEditor.CommandOfEditor.Backspace:
                    Editor.Bs();
                    break;
                case TEditor.CommandOfEditor.Clear:
                    Editor.Clear();
                    break;
            }
            return Editor.Number;
        }

        public string DoOperation(TProc.State command)
        {
            //получаем число и записываем в левый операнд
            var number = new TPNumber(Editor.Number, BaseNumber, AccuracyNumber);
            Proc.SetLeftOperand(number);
            //устанавливем операцию
            Proc.SetOperation(command);
            Editor.Clear();
            return Editor.Number;
        }
        public string DoFunction(TProc.State command)
        {
            //получаем число и записываем в левый операнд
            var number = new TPNumber(Editor.Number, BaseNumber, AccuracyNumber);
            Proc.SetLeftOperand(number);
            //устанавливем операцию
            Proc.SetOperation(command);
            Editor.Clear();
            return Editor.Number;
        }

        public string CalculateExpression() 
        {
            
            // запоминаем правый операнд если последним действием не было нажатие клавиши равно
            var number = new TPNumber(Editor.Number, BaseNumber, AccuracyNumber);
            Proc.SetRightOperand(number);

            //выполняем операцию или функцию по факту выполнится один фиг что-то одно, но по методе надо именно так)))))
            Proc.DoOperation();
            Proc.DoFunction();

            Editor.Number = Proc.GetLeftOperand().GetNumberString();
            

            return Editor.Number;
        }
        
        public string SetStartStateOfCalculator()
        {
            Editor.Clear();
            Proc.SetOperation(TProc.State.None);
            return Editor.Number;
        }

    }
}
