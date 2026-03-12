using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_label_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.Text = "라파엘로 산치오, 이탈리아, 르네상스 3대 거장, 1483~1520";
            l.Text = "라파엘로(Raphael, Faffaello Sanzio da Urbino)는 동시대의 대가인 미켈란젤로, 레오나르도 다빈치와 함께 르네상스 3대 거장으로 알려져 있습니다. 가장 유명한 작품은 <아테네 학당(The School of Athens)>으로 바티칸 궁(Apostolic Palace)에 있는 프레스코 벽화입니다. 라파엘로는 1483년 이탈리아 우르비노에서 태어나 1520년에 사망했습니다. 그의 작품은 아름다운 인물 묘사와 조화로운 구도로 유명하며, 르네상스 예술의 정수를 보여줍니다.";
        }
    }
}
