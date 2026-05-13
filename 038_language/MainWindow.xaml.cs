using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _038_language
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 투표하기 버튼 클릭 이벤트 처리 메소드
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // CheckBox[] cbs = new CheckBox[5] { cbC, cbCPP, cbCS, cbPython, cbJava };
            // CheckBox[] cbs = new CheckBox[] { cbC, cbCPP, cbCS, cbPython, cbJava };
            CheckBox[] cbs = { cbC, cbCPP, cbCS, cbPython, cbJava };

            //string s = "";
            string s = string.Empty; // 초기화

            foreach(var x in cbs)
            {
                if (x.IsChecked == true)
                {
                    s += x.Content + ", ";
                }
            }
            s += " 선택되었습니다!";

            MessageBox.Show(s, "좋아하는 언어!");
        }

        // 끝내기 버튼 클릭 이벤트 처리 메소드
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
