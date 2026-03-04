using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        // 섭씨 -> 화씨
        private void btnC2F_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtC.Text);
            double f = c * 9 / 5 + 32;

            txtF.Text = f.ToString("0.0");
        }

        // 화씨 -> 섭씨
        private void btnF_C_Click(object sender, EventArgs e)
        {
            double f = double.Parse(txtF.Text);
            double c = (f - 32) * 5 / 9;

            txtC.Text = c.ToString("0.0");
        }
    }
}
