namespace _004_bmi_수정
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
            this.H = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.H_textbox = new System.Windows.Forms.TextBox();
            this.W_textbox = new System.Windows.Forms.TextBox();
            this.bmi_button = new System.Windows.Forms.Button();
            this.bmi_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.result_color = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.result_color)).BeginInit();
            this.SuspendLayout();
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("굴림", 10F);
            this.H.Location = new System.Drawing.Point(73, 74);
            this.H.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(81, 24);
            this.H.TabIndex = 6;
            this.H.Text = "키(cm)";
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Font = new System.Drawing.Font("굴림", 10F);
            this.W.Location = new System.Drawing.Point(73, 140);
            this.W.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(97, 24);
            this.W.TabIndex = 7;
            this.W.Text = "체중(kg)";
            // 
            // H_textbox
            // 
            this.H_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.H_textbox.Location = new System.Drawing.Point(187, 69);
            this.H_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.H_textbox.Multiline = true;
            this.H_textbox.Name = "H_textbox";
            this.H_textbox.Size = new System.Drawing.Size(137, 34);
            this.H_textbox.TabIndex = 8;
            this.H_textbox.Text = "\r\n\r\n";
            this.H_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // W_textbox
            // 
            this.W_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.W_textbox.Location = new System.Drawing.Point(187, 134);
            this.W_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.W_textbox.Name = "W_textbox";
            this.W_textbox.Size = new System.Drawing.Size(137, 32);
            this.W_textbox.TabIndex = 9;
            this.W_textbox.Text = "\r\n\r\n";
            this.W_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmi_button
            // 
            this.bmi_button.AutoSize = true;
            this.bmi_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bmi_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmi_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bmi_button.Location = new System.Drawing.Point(187, 202);
            this.bmi_button.Margin = new System.Windows.Forms.Padding(4);
            this.bmi_button.Name = "bmi_button";
            this.bmi_button.Size = new System.Drawing.Size(138, 38);
            this.bmi_button.TabIndex = 10;
            this.bmi_button.Text = "BMI 계산";
            this.bmi_button.UseVisualStyleBackColor = false;
            this.bmi_button.Click += new System.EventHandler(this.bmi_button_Click);
            // 
            // bmi_label
            // 
            this.bmi_label.AutoSize = true;
            this.bmi_label.Font = new System.Drawing.Font("굴림", 10F);
            this.bmi_label.Location = new System.Drawing.Point(73, 284);
            this.bmi_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bmi_label.Name = "bmi_label";
            this.bmi_label.Size = new System.Drawing.Size(75, 24);
            this.bmi_label.TabIndex = 11;
            this.bmi_label.Text = "BMI = ";
            this.bmi_label.Click += new System.EventHandler(this.bmi_label_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("굴림", 10F);
            this.result_label.Location = new System.Drawing.Point(73, 342);
            this.result_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(82, 24);
            this.result_label.TabIndex = 12;
            this.result_label.Text = "판정 : ";
            // 
            // result_color
            // 
            this.result_color.Location = new System.Drawing.Point(242, 284);
            this.result_color.Margin = new System.Windows.Forms.Padding(4);
            this.result_color.Name = "result_color";
            this.result_color.Size = new System.Drawing.Size(82, 81);
            this.result_color.TabIndex = 13;
            this.result_color.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 435);
            this.Controls.Add(this.result_color);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.bmi_label);
            this.Controls.Add(this.bmi_button);
            this.Controls.Add(this.W_textbox);
            this.Controls.Add(this.H_textbox);
            this.Controls.Add(this.W);
            this.Controls.Add(this.H);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BMI 계산기";
            ((System.ComponentModel.ISupportInitialize)(this.result_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.TextBox H_textbox;
        private System.Windows.Forms.TextBox W_textbox;
        private System.Windows.Forms.Button bmi_button;
        private System.Windows.Forms.Label bmi_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.PictureBox result_color;
    }
}

