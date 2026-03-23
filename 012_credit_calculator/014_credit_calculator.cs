using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_credit_calculator
{
    public partial class Form1 : Form
    {
        TextBox[] subjectArray; // 교과목 TextBox 배열
        ComboBox[] creditArray; // 학점 ComboBox 배열
        ComboBox[] gradeArray; // 성적 ComboBox 배열

        public Form1() // 생성자
        {
            InitializeComponent();
        }

        // 폼이 처음 열릴 때 실행되는 설정
        private void Form1_Load(object sender, EventArgs e)
        {
            subject1_textbox.Text = "인체의 구조와 기능I";
            subject2_textbox.Text = "일반수학I";
            subject3_textbox.Text = "디지털공학및실험";
            subject4_textbox.Text = "자료구조";
            subject5_textbox.Text = "비주얼프로그래밍";
            subject6_textbox.Text = "기업가정신";

            subjectArray = new TextBox[] {
                subject1_textbox, subject2_textbox, subject3_textbox,
                subject4_textbox, subject5_textbox, subject6_textbox, subject7_textbox
            };

            creditArray = new ComboBox[] {
                credit1_combobox, credit2_combobox, credit3_combobox,
                credit4_combobox, credit5_combobox, credit6_combobox, credit7_combobox
            };

            gradeArray = new ComboBox[] {
                grade1_combobox, grade2_combobox, grade3_combobox,
                grade4_combobox, grade5_combobox, grade6_combobox, grade7_combobox
            };

            // 2. 학점 선택 항목 초기화 (1~5학점)
            int[] creditList = { 1, 2, 3, 4, 5 };

            foreach (var combo in creditArray)
            {
                foreach (var item in creditList)
                {
                    combo.Items.Add(item);
                }
                combo.SelectedItem = 3; // 대학 수업 기본값인 3학점으로 초기설정
            }

            // 3. 성적 선택 항목 초기화 (A+ ~ F)
            List<String> gradeList = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach (var combo in gradeArray)
            {
                foreach (var item in gradeList)
                {
                    combo.Items.Add(item);
                }
                //
                // 기본적으로 A+이 선택되어 있게 하거나 빈칸이 아니게 함
                combo.SelectedIndex = 0;
            }
        }

        // [평균평점] 버튼 클릭 시 실행되는 계산 로직
        private void average_credit_button_Click_1(object sender, EventArgs e)
        {
            double totalGradePoint = 0; // (각 과목 학점 * 성적 점수)의 총합
            int totalCreditCount = 0;   // 사용자가 입력한 총 학점 수

            for (int i = 0; i < subjectArray.Length; i++)
            {
                // 과목명(TextBox)에 글자가 한 글자라도 써져 있는 경우만 계산
                if (!string.IsNullOrWhiteSpace(subjectArray[i].Text))
                {
                    // 1. 선택된 학점(숫자) 가져오기
                    if (creditArray[i].SelectedItem != null)
                    {
                        int currentCredit = int.Parse(creditArray[i].SelectedItem.ToString());
                        totalCreditCount += currentCredit;

                        // 2. 선택된 성적 등급을 숫자 점수로 환산하여 합산
                        if (gradeArray[i].SelectedItem != null)
                        {
                            string selectedGradeName = gradeArray[i].SelectedItem.ToString();
                            // (학점 * 환산점수)를 누적해서 더함
                            totalGradePoint += currentCredit * CalculateGradeScore(selectedGradeName);
                        }
                    }
                }
            }

            // 3. 최종 결과 출력 (result_textbox)
            if (totalCreditCount > 0)
            {
                // 평균평점 = 총점수 / 총학점
                double averageGPA = totalGradePoint / totalCreditCount;
                // ToString("0.00")은 소수점 둘째 자리까지만 표시하라는 뜻입니다.
                result_textbox.Text = averageGPA.ToString("0.00");
            }
            else
            {
                MessageBox.Show("계산할 과목명을 입력해 주세요!", "알림");
            }
        }

        // 성적 등급 문자열을 숫자 점수로 바꿔주는 도우미 메소드
        private double CalculateGradeScore(string gradeName)
        {
            switch (gradeName)
            {
                case "A+": return 4.5;
                case "A0": return 4.0;
                case "B+": return 3.5;
                case "B0": return 3.0;
                case "C+": return 2.5;
                case "C0": return 2.0;
                case "D+": return 1.5;
                case "D0": return 1.0;
                default: return 0.0; // F학점 및 기타
            }
        }
    }
}