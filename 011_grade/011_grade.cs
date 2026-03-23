using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(language_textbox.Text) + Convert.ToDouble(math_textbox.Text) + Convert.ToDouble(english_textbox.Text);

            double average = sum / 3;

            sum_textbox.Text = sum.ToString();
            average_textbox.Text = average.ToString("0.0");
        }
    }
}