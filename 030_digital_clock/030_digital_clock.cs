using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _030_digital_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아날로그 시계는 아직 구현되지 않았습니다.", "경고");
        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10; //1000ms = 1s // 10ms = 0.01s
            timer1.Tick += Timer1_Tick;

            // 소스코드로 label의 폰트 설정
            date_label.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
            date_label.ForeColor = Color.OrangeRed;

            time_label.Font = new Font("맑은 고딕", 20, FontStyle.Bold | FontStyle.Italic);
            time_label.ForeColor = Color.DarkBlue;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            date_label.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");
            time_label.Text = DateTime.Now.ToString("tt h:mm:ss:fff");

            date_label.Location = new Point((this.ClientSize.Width - date_label.Width) / 2, this.ClientSize.Height / 2 - date_label.Height);
            time_label.Location = new Point((this.ClientSize.Width - time_label.Width) / 2, this.ClientSize.Height / 2);

            // date_label.Location = new Point((this.ClientSize.Width / 2 - date_label.Width / 2), this.ClientSize.Height / 2 - date_label.Height / 2 - 30);
            // time_label.Location = new Point((this.ClientSize.Width / 2 - time_label.Width / 2), this.ClientSize.Height / 2 + time_label.Height / 2 + 30);

            // date_label.Left = (this.ClientSize.Width - date_label.Width) / 2;
            // time_label.Left = (this.ClientSize.Width - time_label.Width) / 2;
        }

        private void stopGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }

            else
            {
                timer1.Enabled = true;
            }
        }
    }
}