namespace _014_credit_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.subject1_textbox = new System.Windows.Forms.TextBox();
            this.average_credit_button = new System.Windows.Forms.Button();
            this.subject_label = new System.Windows.Forms.Label();
            this.subject2_textbox = new System.Windows.Forms.TextBox();
            this.subject3_textbox = new System.Windows.Forms.TextBox();
            this.subject4_textbox = new System.Windows.Forms.TextBox();
            this.subject5_textbox = new System.Windows.Forms.TextBox();
            this.subject6_textbox = new System.Windows.Forms.TextBox();
            this.subject7_textbox = new System.Windows.Forms.TextBox();
            this.credit1_combobox = new System.Windows.Forms.ComboBox();
            this.credit2_combobox = new System.Windows.Forms.ComboBox();
            this.credit3_combobox = new System.Windows.Forms.ComboBox();
            this.credit4_combobox = new System.Windows.Forms.ComboBox();
            this.credit5_combobox = new System.Windows.Forms.ComboBox();
            this.credit6_combobox = new System.Windows.Forms.ComboBox();
            this.credit7_combobox = new System.Windows.Forms.ComboBox();
            this.grade7_combobox = new System.Windows.Forms.ComboBox();
            this.grade6_combobox = new System.Windows.Forms.ComboBox();
            this.grade5_combobox = new System.Windows.Forms.ComboBox();
            this.grade4_combobox = new System.Windows.Forms.ComboBox();
            this.grade3_combobox = new System.Windows.Forms.ComboBox();
            this.grade2_combobox = new System.Windows.Forms.ComboBox();
            this.grade1_combobox = new System.Windows.Forms.ComboBox();
            this.credit_label = new System.Windows.Forms.Label();
            this.grade_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subject1_textbox
            // 
            this.subject1_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject1_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject1_textbox.Location = new System.Drawing.Point(51, 75);
            this.subject1_textbox.Multiline = true;
            this.subject1_textbox.Name = "subject1_textbox";
            this.subject1_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject1_textbox.TabIndex = 26;
            this.subject1_textbox.Text = "\r\n\r\n";
            // 
            // average_credit_button
            // 
            this.average_credit_button.AutoSize = true;
            this.average_credit_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.average_credit_button.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.average_credit_button.FlatAppearance.BorderSize = 2;
            this.average_credit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.average_credit_button.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average_credit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.average_credit_button.Location = new System.Drawing.Point(256, 398);
            this.average_credit_button.Name = "average_credit_button";
            this.average_credit_button.Size = new System.Drawing.Size(146, 37);
            this.average_credit_button.TabIndex = 25;
            this.average_credit_button.Text = "평균평점";
            this.average_credit_button.UseVisualStyleBackColor = false;
            this.average_credit_button.Click += new System.EventHandler(this.average_credit_button_Click);
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject_label.Location = new System.Drawing.Point(95, 38);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(61, 23);
            this.subject_label.TabIndex = 24;
            this.subject_label.Text = "과목명";
            // 
            // subject2_textbox
            // 
            this.subject2_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject2_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject2_textbox.Location = new System.Drawing.Point(51, 121);
            this.subject2_textbox.Multiline = true;
            this.subject2_textbox.Name = "subject2_textbox";
            this.subject2_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject2_textbox.TabIndex = 27;
            this.subject2_textbox.Text = "\r\n\r\n";
            // 
            // subject3_textbox
            // 
            this.subject3_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject3_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject3_textbox.Location = new System.Drawing.Point(51, 167);
            this.subject3_textbox.Multiline = true;
            this.subject3_textbox.Name = "subject3_textbox";
            this.subject3_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject3_textbox.TabIndex = 28;
            this.subject3_textbox.Text = "\r\n\r\n";
            // 
            // subject4_textbox
            // 
            this.subject4_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject4_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject4_textbox.Location = new System.Drawing.Point(51, 213);
            this.subject4_textbox.Multiline = true;
            this.subject4_textbox.Name = "subject4_textbox";
            this.subject4_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject4_textbox.TabIndex = 29;
            this.subject4_textbox.Text = "\r\n\r\n";
            // 
            // subject5_textbox
            // 
            this.subject5_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject5_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject5_textbox.Location = new System.Drawing.Point(51, 259);
            this.subject5_textbox.Multiline = true;
            this.subject5_textbox.Name = "subject5_textbox";
            this.subject5_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject5_textbox.TabIndex = 30;
            this.subject5_textbox.Text = "\r\n\r\n";
            // 
            // subject6_textbox
            // 
            this.subject6_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject6_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject6_textbox.Location = new System.Drawing.Point(51, 305);
            this.subject6_textbox.Multiline = true;
            this.subject6_textbox.Name = "subject6_textbox";
            this.subject6_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject6_textbox.TabIndex = 31;
            this.subject6_textbox.Text = "\r\n\r\n";
            // 
            // subject7_textbox
            // 
            this.subject7_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subject7_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.subject7_textbox.Location = new System.Drawing.Point(51, 351);
            this.subject7_textbox.Multiline = true;
            this.subject7_textbox.Name = "subject7_textbox";
            this.subject7_textbox.Size = new System.Drawing.Size(146, 28);
            this.subject7_textbox.TabIndex = 32;
            this.subject7_textbox.Text = "\r\n\r\n";
            // 
            // credit1_combobox
            // 
            this.credit1_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit1_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit1_combobox.FormattingEnabled = true;
            this.credit1_combobox.Location = new System.Drawing.Point(256, 74);
            this.credit1_combobox.Name = "credit1_combobox";
            this.credit1_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit1_combobox.TabIndex = 33;
            // 
            // credit2_combobox
            // 
            this.credit2_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit2_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit2_combobox.FormattingEnabled = true;
            this.credit2_combobox.Location = new System.Drawing.Point(256, 120);
            this.credit2_combobox.Name = "credit2_combobox";
            this.credit2_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit2_combobox.TabIndex = 34;
            // 
            // credit3_combobox
            // 
            this.credit3_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit3_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit3_combobox.FormattingEnabled = true;
            this.credit3_combobox.Location = new System.Drawing.Point(256, 166);
            this.credit3_combobox.Name = "credit3_combobox";
            this.credit3_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit3_combobox.TabIndex = 35;
            // 
            // credit4_combobox
            // 
            this.credit4_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit4_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit4_combobox.FormattingEnabled = true;
            this.credit4_combobox.Location = new System.Drawing.Point(256, 214);
            this.credit4_combobox.Name = "credit4_combobox";
            this.credit4_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit4_combobox.TabIndex = 36;
            // 
            // credit5_combobox
            // 
            this.credit5_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit5_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit5_combobox.FormattingEnabled = true;
            this.credit5_combobox.Location = new System.Drawing.Point(256, 260);
            this.credit5_combobox.Name = "credit5_combobox";
            this.credit5_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit5_combobox.TabIndex = 37;
            // 
            // credit6_combobox
            // 
            this.credit6_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit6_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit6_combobox.FormattingEnabled = true;
            this.credit6_combobox.Location = new System.Drawing.Point(256, 306);
            this.credit6_combobox.Name = "credit6_combobox";
            this.credit6_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit6_combobox.TabIndex = 38;
            // 
            // credit7_combobox
            // 
            this.credit7_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.credit7_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit7_combobox.FormattingEnabled = true;
            this.credit7_combobox.Location = new System.Drawing.Point(256, 352);
            this.credit7_combobox.Name = "credit7_combobox";
            this.credit7_combobox.Size = new System.Drawing.Size(146, 31);
            this.credit7_combobox.TabIndex = 39;
            // 
            // grade7_combobox
            // 
            this.grade7_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade7_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade7_combobox.FormattingEnabled = true;
            this.grade7_combobox.Location = new System.Drawing.Point(456, 352);
            this.grade7_combobox.Name = "grade7_combobox";
            this.grade7_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade7_combobox.TabIndex = 46;
            // 
            // grade6_combobox
            // 
            this.grade6_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade6_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade6_combobox.FormattingEnabled = true;
            this.grade6_combobox.Location = new System.Drawing.Point(456, 306);
            this.grade6_combobox.Name = "grade6_combobox";
            this.grade6_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade6_combobox.TabIndex = 45;
            // 
            // grade5_combobox
            // 
            this.grade5_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade5_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade5_combobox.FormattingEnabled = true;
            this.grade5_combobox.Location = new System.Drawing.Point(456, 260);
            this.grade5_combobox.Name = "grade5_combobox";
            this.grade5_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade5_combobox.TabIndex = 44;
            // 
            // grade4_combobox
            // 
            this.grade4_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade4_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade4_combobox.FormattingEnabled = true;
            this.grade4_combobox.Location = new System.Drawing.Point(456, 214);
            this.grade4_combobox.Name = "grade4_combobox";
            this.grade4_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade4_combobox.TabIndex = 43;
            // 
            // grade3_combobox
            // 
            this.grade3_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade3_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade3_combobox.FormattingEnabled = true;
            this.grade3_combobox.Location = new System.Drawing.Point(456, 166);
            this.grade3_combobox.Name = "grade3_combobox";
            this.grade3_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade3_combobox.TabIndex = 42;
            // 
            // grade2_combobox
            // 
            this.grade2_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade2_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade2_combobox.FormattingEnabled = true;
            this.grade2_combobox.Location = new System.Drawing.Point(456, 120);
            this.grade2_combobox.Name = "grade2_combobox";
            this.grade2_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade2_combobox.TabIndex = 41;
            // 
            // grade1_combobox
            // 
            this.grade1_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade1_combobox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade1_combobox.FormattingEnabled = true;
            this.grade1_combobox.Location = new System.Drawing.Point(456, 74);
            this.grade1_combobox.Name = "grade1_combobox";
            this.grade1_combobox.Size = new System.Drawing.Size(146, 31);
            this.grade1_combobox.TabIndex = 40;
            // 
            // credit_label
            // 
            this.credit_label.AutoSize = true;
            this.credit_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.credit_label.Location = new System.Drawing.Point(308, 38);
            this.credit_label.Name = "credit_label";
            this.credit_label.Size = new System.Drawing.Size(44, 23);
            this.credit_label.TabIndex = 47;
            this.credit_label.Text = "학점";
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grade_label.Location = new System.Drawing.Point(508, 38);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(44, 23);
            this.grade_label.TabIndex = 48;
            this.grade_label.Text = "성적";
            // 
            // result_textbox
            // 
            this.result_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_textbox.Location = new System.Drawing.Point(456, 398);
            this.result_textbox.Multiline = true;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(146, 37);
            this.result_textbox.TabIndex = 49;
            this.result_textbox.Text = "\r\n\r\n";
            this.result_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 479);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.credit_label);
            this.Controls.Add(this.grade7_combobox);
            this.Controls.Add(this.grade6_combobox);
            this.Controls.Add(this.grade5_combobox);
            this.Controls.Add(this.grade4_combobox);
            this.Controls.Add(this.grade3_combobox);
            this.Controls.Add(this.grade2_combobox);
            this.Controls.Add(this.grade1_combobox);
            this.Controls.Add(this.credit7_combobox);
            this.Controls.Add(this.credit6_combobox);
            this.Controls.Add(this.credit5_combobox);
            this.Controls.Add(this.credit4_combobox);
            this.Controls.Add(this.credit3_combobox);
            this.Controls.Add(this.credit2_combobox);
            this.Controls.Add(this.credit1_combobox);
            this.Controls.Add(this.subject7_textbox);
            this.Controls.Add(this.subject6_textbox);
            this.Controls.Add(this.subject5_textbox);
            this.Controls.Add(this.subject4_textbox);
            this.Controls.Add(this.subject3_textbox);
            this.Controls.Add(this.subject2_textbox);
            this.Controls.Add(this.subject1_textbox);
            this.Controls.Add(this.average_credit_button);
            this.Controls.Add(this.subject_label);
            this.Name = "Form1";
            this.Text = "학점계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject1_textbox;
        private System.Windows.Forms.Button average_credit_button;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox subject2_textbox;
        private System.Windows.Forms.TextBox subject3_textbox;
        private System.Windows.Forms.TextBox subject4_textbox;
        private System.Windows.Forms.TextBox subject5_textbox;
        private System.Windows.Forms.TextBox subject6_textbox;
        private System.Windows.Forms.TextBox subject7_textbox;
        private System.Windows.Forms.ComboBox credit1_combobox;
        private System.Windows.Forms.ComboBox credit2_combobox;
        private System.Windows.Forms.ComboBox credit3_combobox;
        private System.Windows.Forms.ComboBox credit4_combobox;
        private System.Windows.Forms.ComboBox credit5_combobox;
        private System.Windows.Forms.ComboBox credit6_combobox;
        private System.Windows.Forms.ComboBox credit7_combobox;
        private System.Windows.Forms.ComboBox grade7_combobox;
        private System.Windows.Forms.ComboBox grade6_combobox;
        private System.Windows.Forms.ComboBox grade5_combobox;
        private System.Windows.Forms.ComboBox grade4_combobox;
        private System.Windows.Forms.ComboBox grade3_combobox;
        private System.Windows.Forms.ComboBox grade2_combobox;
        private System.Windows.Forms.ComboBox grade1_combobox;
        private System.Windows.Forms.Label credit_label;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.TextBox result_textbox;
    }
}

