using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmi_수정
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //button1을 클릭했을 때 실행되는 이벤트 처리 함수
        private void bmi_button_Click(object sender, EventArgs e)
        {
            double h = double.Parse(H_text.Text);
            double w = double.Parse(W_text.Text);

            h /= 100; // m 단위 환산
            double bmi = w / (h * h);

            // 컨트롤.속성 = String.Format("{0 : F1}", 텍스트박스); 소수점 한자리
            // 컨트롤.속성 = 텍스트박스.ToString("F1"); 소수점 한자리

            // .Tostring()은 문자열로 바꾸어 준다.
            bmi_label.Text = "BMI = " + bmi.ToString("0.00");

            // bmi 수치에 따른 결과 표시
            if (bmi < 20)
            {
                result_label.Text += "저체중";
                result_color.BackColor = Color.LightBlue;
            }

            if (bmi >= 20 && bmi < 25)
            {
                result_label.Text += "정상체중";
                result_color.BackColor = Color.LightGreen;
            }

            if (bmi >= 25 && bmi < 30)
            {
                result_label.Text += "경도비만";
                result_color.BackColor = Color.Yellow;
            }

            if (bmi >= 30 && bmi < 35)
            {
                result_label.Text += "비만";
                result_color.BackColor = Color.Orange;
            }

            if (bmi >= 35 && bmi < 40)
            {
                result_label.Text += "고도비만";
                result_color.BackColor = Color.Red;
            }
        }

        private void bmi_label_Click(object sender, EventArgs e)
        {

        }
    }
}
