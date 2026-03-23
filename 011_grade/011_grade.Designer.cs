namespace _011_grade
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
            this.gradeinput_groupbox = new System.Windows.Forms.GroupBox();
            this.english_label = new System.Windows.Forms.Label();
            this.math_label = new System.Windows.Forms.Label();
            this.math_textbox = new System.Windows.Forms.TextBox();
            this.english_textbox = new System.Windows.Forms.TextBox();
            this.language_label = new System.Windows.Forms.Label();
            this.language_textbox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.result_groupbox = new System.Windows.Forms.GroupBox();
            this.average_label = new System.Windows.Forms.Label();
            this.average_textbox = new System.Windows.Forms.TextBox();
            this.sum_label = new System.Windows.Forms.Label();
            this.sum_textbox = new System.Windows.Forms.TextBox();
            this.gradeinput_groupbox.SuspendLayout();
            this.result_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradeinput_groupbox
            // 
            this.gradeinput_groupbox.Controls.Add(this.english_label);
            this.gradeinput_groupbox.Controls.Add(this.math_label);
            this.gradeinput_groupbox.Controls.Add(this.math_textbox);
            this.gradeinput_groupbox.Controls.Add(this.english_textbox);
            this.gradeinput_groupbox.Controls.Add(this.language_label);
            this.gradeinput_groupbox.Controls.Add(this.language_textbox);
            this.gradeinput_groupbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gradeinput_groupbox.Location = new System.Drawing.Point(43, 41);
            this.gradeinput_groupbox.Name = "gradeinput_groupbox";
            this.gradeinput_groupbox.Size = new System.Drawing.Size(198, 192);
            this.gradeinput_groupbox.TabIndex = 0;
            this.gradeinput_groupbox.TabStop = false;
            this.gradeinput_groupbox.Text = "성적입력";
            // 
            // english_label
            // 
            this.english_label.AutoSize = true;
            this.english_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.english_label.Location = new System.Drawing.Point(23, 138);
            this.english_label.Name = "english_label";
            this.english_label.Size = new System.Drawing.Size(44, 23);
            this.english_label.TabIndex = 27;
            this.english_label.Text = "영어";
            // 
            // math_label
            // 
            this.math_label.AutoSize = true;
            this.math_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.math_label.Location = new System.Drawing.Point(23, 90);
            this.math_label.Name = "math_label";
            this.math_label.Size = new System.Drawing.Size(44, 23);
            this.math_label.TabIndex = 25;
            this.math_label.Text = "수학";
            // 
            // math_textbox
            // 
            this.math_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.math_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.math_textbox.Location = new System.Drawing.Point(81, 88);
            this.math_textbox.Multiline = true;
            this.math_textbox.Name = "math_textbox";
            this.math_textbox.Size = new System.Drawing.Size(90, 29);
            this.math_textbox.TabIndex = 26;
            this.math_textbox.Text = "\r\n\r\n";
            this.math_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // english_textbox
            // 
            this.english_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.english_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.english_textbox.Location = new System.Drawing.Point(81, 136);
            this.english_textbox.Multiline = true;
            this.english_textbox.Name = "english_textbox";
            this.english_textbox.Size = new System.Drawing.Size(90, 29);
            this.english_textbox.TabIndex = 28;
            this.english_textbox.Text = "\r\n\r\n";
            this.english_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // language_label
            // 
            this.language_label.AutoSize = true;
            this.language_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.language_label.Location = new System.Drawing.Point(23, 41);
            this.language_label.Name = "language_label";
            this.language_label.Size = new System.Drawing.Size(44, 23);
            this.language_label.TabIndex = 20;
            this.language_label.Text = "국어";
            // 
            // language_textbox
            // 
            this.language_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.language_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.language_textbox.Location = new System.Drawing.Point(81, 39);
            this.language_textbox.Multiline = true;
            this.language_textbox.Name = "language_textbox";
            this.language_textbox.Size = new System.Drawing.Size(90, 29);
            this.language_textbox.TabIndex = 24;
            this.language_textbox.Text = "\r\n\r\n";
            this.language_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_button
            // 
            this.calculate_button.AutoSize = true;
            this.calculate_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculate_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.calculate_button.FlatAppearance.BorderSize = 2;
            this.calculate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate_button.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.calculate_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculate_button.Location = new System.Drawing.Point(364, 196);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(90, 37);
            this.calculate_button.TabIndex = 17;
            this.calculate_button.Text = "계산";
            this.calculate_button.UseVisualStyleBackColor = false;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // result_groupbox
            // 
            this.result_groupbox.Controls.Add(this.average_label);
            this.result_groupbox.Controls.Add(this.average_textbox);
            this.result_groupbox.Controls.Add(this.sum_label);
            this.result_groupbox.Controls.Add(this.sum_textbox);
            this.result_groupbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_groupbox.Location = new System.Drawing.Point(283, 41);
            this.result_groupbox.Name = "result_groupbox";
            this.result_groupbox.Size = new System.Drawing.Size(198, 142);
            this.result_groupbox.TabIndex = 29;
            this.result_groupbox.TabStop = false;
            this.result_groupbox.Text = "결과";
            // 
            // average_label
            // 
            this.average_label.AutoSize = true;
            this.average_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average_label.Location = new System.Drawing.Point(23, 90);
            this.average_label.Name = "average_label";
            this.average_label.Size = new System.Drawing.Size(44, 23);
            this.average_label.TabIndex = 25;
            this.average_label.Text = "평균";
            // 
            // average_textbox
            // 
            this.average_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.average_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.average_textbox.Location = new System.Drawing.Point(81, 88);
            this.average_textbox.Multiline = true;
            this.average_textbox.Name = "average_textbox";
            this.average_textbox.ReadOnly = true;
            this.average_textbox.Size = new System.Drawing.Size(90, 29);
            this.average_textbox.TabIndex = 26;
            this.average_textbox.Text = "\r\n\r\n";
            this.average_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sum_label
            // 
            this.sum_label.AutoSize = true;
            this.sum_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_label.Location = new System.Drawing.Point(23, 41);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(44, 23);
            this.sum_label.TabIndex = 20;
            this.sum_label.Text = "총점";
            // 
            // sum_textbox
            // 
            this.sum_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sum_textbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_textbox.Location = new System.Drawing.Point(81, 39);
            this.sum_textbox.Multiline = true;
            this.sum_textbox.Name = "sum_textbox";
            this.sum_textbox.ReadOnly = true;
            this.sum_textbox.Size = new System.Drawing.Size(90, 29);
            this.sum_textbox.TabIndex = 24;
            this.sum_textbox.Text = "\r\n\r\n";
            this.sum_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.result_groupbox);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.gradeinput_groupbox);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.gradeinput_groupbox.ResumeLayout(false);
            this.gradeinput_groupbox.PerformLayout();
            this.result_groupbox.ResumeLayout(false);
            this.result_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gradeinput_groupbox;
        private System.Windows.Forms.TextBox language_textbox;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label english_label;
        private System.Windows.Forms.Label math_label;
        private System.Windows.Forms.TextBox math_textbox;
        private System.Windows.Forms.TextBox english_textbox;
        private System.Windows.Forms.Label language_label;
        private System.Windows.Forms.GroupBox result_groupbox;
        private System.Windows.Forms.Label average_label;
        private System.Windows.Forms.TextBox average_textbox;
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.TextBox sum_textbox;
    }
}

