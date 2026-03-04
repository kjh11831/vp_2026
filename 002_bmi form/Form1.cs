using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //button1을 클릭했을 때 실행되는 이벤트 처리 함수
        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);

            h /= 100; // m 단위 환산
            double bmi = w / (h * h);

            // .Tostring()은 문자열로 바꾸어 준다.
            lblBMI.Text = "BMI = " + bmi.ToString();
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
