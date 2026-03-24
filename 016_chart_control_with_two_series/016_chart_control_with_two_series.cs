using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_chart_control_with_two_series
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");

            chart1.Series.Add("Series2");

            chart1.Series[0].LegendText = "수학";
            chart1.Series[1].LegendText = "영어";

            // Random 객체 r 생성
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101));
                chart1.Series[1].Points.AddXY(i, r.Next(101));
            }
        }

        private void one_chart_button_Click(object sender, EventArgs e)
        {
            // 두번째 ChartArea 제거
            chart1.ChartAreas.RemoveAt(1);
            chart1.Series[1].ChartArea = "ChartArea1";
        }

        private void two_chart_button_Click(object sender, EventArgs e)
        {
            // ChartArea1은 디폴트로 존재함
            // ChartArea2만 생성
            chart1.ChartAreas.Add("ChartArea2");
            chart1.Series[1].ChartArea = "ChartArea2";
        }
    }
}
