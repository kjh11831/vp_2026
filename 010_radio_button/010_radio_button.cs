using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_radio_button
{
    public partial class Form1 : Form
    {

        private RadioButton checkedRB;

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string result = "";
            
            if (korea_radiobutton.Checked)
            {
                result += "국적: 대한민국\n";
            }

            else if (china_radiobutton.Checked)
            {
                result += "국적: 중국\n";
            }

            else if (japan_radiobutton.Checked)
            {
                result += "국적: 일본\n";
            }

            else if (others_radiobutton.Checked)
            {
                result += "국적: 그 외 국가\n";
            }

            if (checkedRB == male_radiobutton)
            {
                result += "성별: 남성";
            }

            else if (checkedRB == female_radiobutton)
            {
                result += "성별: 여성";
            }

            MessageBox.Show(result, "Result");
        }

        private void male_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = male_radiobutton;
        }

        private void female_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = female_radiobutton;
        }
    }
}
