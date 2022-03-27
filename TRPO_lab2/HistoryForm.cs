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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        public HistoryForm(Form1 f)
        {
            InitializeComponent();
            var his = f.control.GetHistory();
            label1.Text += "Внимание! Порядок операций прямой для наглядности!" + "\n";
            foreach (var item in his)
            {
                label1.Text += item + "\n";
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
