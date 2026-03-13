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

        private void login_button_Click(object sender, EventArgs e)
        {
            if (id_textbox.Text.Trim() == "abcd" && password_textbox.Text.Trim() == "1234")
            {
                result_textbox.Text = "로그인 성공";
            }

            else
            {
                result_textbox.Text = "로그인 실패";
            }
        }
    }
}