using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_lab2
{
    public partial class Form1 : Form
    {
        TCtrl control = new TCtrl();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            control = new TCtrl(trackBar1.Value);
            label2.Text ="0";
            label1.Text = $"Основание: {trackBar1.Value}";
            var baseNumber = trackBar1.Value;
            switch (baseNumber) 
            {
                case 2:
                    button11.Enabled = false; //2
                    button15.Enabled = false; //3
                    button6.Enabled = false; //4
                    button10.Enabled = false; //5
                    button14.Enabled = false; //6
                    button5.Enabled = false; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 3:
                    button11.Enabled = true; //2
                    button15.Enabled = false; //3
                    button6.Enabled = false; //4
                    button10.Enabled = false; //5
                    button14.Enabled = false; //6
                    button5.Enabled = false; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 4:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = false; //4
                    button10.Enabled = false; //5
                    button14.Enabled = false; //6
                    button5.Enabled = false; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 5:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = false; //5
                    button14.Enabled = false; //6
                    button5.Enabled = false; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 6:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = false; //6
                    button5.Enabled = false; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 7:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = false; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 8:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = false; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 9:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = false; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 10:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = false; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 11:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = true; //10
                    button29.Enabled = false; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 12:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = true; //10
                    button29.Enabled = true; //11
                    button30.Enabled = false; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 13:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = true; //10
                    button29.Enabled = true; //11
                    button30.Enabled = true; //12
                    button31.Enabled = false; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 14:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = true; //10
                    button29.Enabled = true; //11
                    button30.Enabled = true; //12
                    button31.Enabled = true; //13
                    button32.Enabled = false; //14
                    button33.Enabled = false; //15
                    break;
                case 15:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = true; //10
                    button29.Enabled = true; //11
                    button30.Enabled = true; //12
                    button31.Enabled = true; //13
                    button32.Enabled = true; //14
                    button33.Enabled = false; //15
                    break;
                case 16:
                    button11.Enabled = true; //2
                    button15.Enabled = true; //3
                    button6.Enabled = true; //4
                    button10.Enabled = true; //5
                    button14.Enabled = true; //6
                    button5.Enabled = true; //7
                    button9.Enabled = true; //8
                    button13.Enabled = true; //9
                    button28.Enabled = true; //10
                    button29.Enabled = true; //11
                    button30.Enabled = true; //12
                    button31.Enabled = true; //13
                    button32.Enabled = true; //14
                    button33.Enabled = true; //15
                    break;

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'A');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            control.DoOperation(TProc.State.Add);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            control.DoOperation(TProc.State.Sub);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            control.DoOperation(TProc.State.Mul);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            control.DoOperation(TProc.State.Dvd);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label2.Text = control.DoFunction(TProc.State.Sqr);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label2.Text = control.DoFunction(TProc.State.Rev);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '1');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '2');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '3');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '4');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try 
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '5');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '6');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '7');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '8');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '9');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {   
            label2.Text= control.DoCommandOfEditor(TEditor.CommandOfEditor.Clear);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text = control.CalculateExpression();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '.');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.Backspace);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label2.Text = control.SetStartStateOfCalculator();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = control.ChangeSign();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '0');
                        break;
                    case Keys.D1:
                        if (control.BaseNumber > 1)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '1');
                        break;
                    case Keys.D2:
                        if (control.BaseNumber > 2)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '2');
                        break;
                    case Keys.D3:
                        if (control.BaseNumber > 3)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '3');
                        break;
                    case Keys.D4:
                        if (control.BaseNumber > 4)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '4');
                        break;
                    case Keys.D5:
                        if (control.BaseNumber > 5)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '5');
                        break;
                    case Keys.D6:
                        if (control.BaseNumber > 6)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '6');
                        break;
                    case Keys.D7:
                        if (control.BaseNumber > 7)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '7');
                        break;
                    case Keys.D8:
                        if (control.BaseNumber > 8)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '8');
                        break;
                    case Keys.D9:
                        if (control.BaseNumber > 9)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, '9');
                        break;
                    case Keys.A:
                        if (control.BaseNumber > 10)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'A');
                        break;
                    case Keys.B:
                        if (control.BaseNumber > 11)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'B');
                        break;
                    case Keys.C:
                        if (control.BaseNumber > 12)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'C');
                        break;
                    case Keys.D:
                        if (control.BaseNumber > 13)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'D');
                        break;
                    case Keys.E:
                        if (control.BaseNumber > 14)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'E');
                        break;
                    case Keys.F:
                        if (control.BaseNumber > 15)
                            label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'F');
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'B');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'C');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'D');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'E');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = control.DoCommandOfEditor(TEditor.CommandOfEditor.AddDigit, 'F');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
