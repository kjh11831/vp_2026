using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_basic_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_button_Click(object sender, EventArgs e)
        {
            // 입력된 텍스트가 비어있는지 확인
            if (string.IsNullOrWhiteSpace(name_textbox.Text))
            {
                MessageBox.Show("이름을 입력하세요."," Warning");
                welcome_label.Text = "";
            }

            else
            {
                // 이름이 제대로 입력되었을 때만 출력
                welcome_label.Text = name_textbox.Text.Trim() + "님! 안녕하세요!";
            }
        }
    }
}
