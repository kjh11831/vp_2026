using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkStates = "";

            CheckBox[] checkboxes = { apple, pear, strawberry, banana, orange };

            foreach (var item in checkboxes)
            {
                checkStates += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }

            MessageBox.Show(checkStates, "checkStates");

            string summary = string.Format("좋아하는 과일은 : ");

            foreach (var item in checkboxes)
            {
                if (item.Checked == true)
                {
                    summary += item.Text + " ";
                }
            }

            MessageBox.Show(summary, "summary");
        }
    }
}