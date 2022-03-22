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
            label1.Text = $"Основание: {trackBar1.Value}";
        }

        private void button28_Click(object sender, EventArgs e)
        {

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
            control.DoFunction(TProc.State.Sqr);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            control.DoFunction(TProc.State.Rev);
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
            label2.Text= control.SetStartStateOfCalculator();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            control.CalculateExpression();
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
    }
}
