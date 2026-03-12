using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_login_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bmi_button_Click(object sender, EventArgs e)
        {
            if (id_text.Text == "abcd" && password_text.Text == "1234")
            {
                result_text.Text = "로그인 성공";
            }

            else
            {
                result_text.Text = "로그인 실패";
            }
        }
    }
}