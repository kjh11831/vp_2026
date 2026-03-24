using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _017_chart_control_with_two_series_fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart2.Titles.Add("성적");

            chart2.Series.Add("Series2");

            chart2.Series[0].LegendText = "수학";
            chart2.Series[1].LegendText = "영어";

            // Random 객체 r 생성
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                chart2.Series[0].Points.AddXY(i, r.Next(101));
                chart2.Series[1].Points.AddXY(i, r.Next(101));
            }
        }

        private void one_chart_button_Click(object sender, EventArgs e)
        {
            if (chart2.ChartAreas.Count == 1)
                return;

            chart2.ChartAreas.RemoveAt(1);
            chart2.Series[1].ChartArea = "ChartArea1";

            two_chart_button.Enabled = true;
            one_chart_button.Enabled = false;
        }

        private void two_chart_button_Click(object sender, EventArgs e)
        {
            if (chart2.ChartAreas.Count >= 2)
                return;

            // ChartArea1은 디폴트로 존재함
            // ChartArea2만 생성
            chart2.ChartAreas.Add("ChartArea2");
            chart2.Series[1].ChartArea = "ChartArea2";

            two_chart_button.Enabled = false;
            one_chart_button.Enabled = true;
        }
    }
}
