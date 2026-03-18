namespace _010_radio_button
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
            this.gender_groupbox = new System.Windows.Forms.GroupBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.nationality_groupbox = new System.Windows.Forms.GroupBox();
            this.korea_radiobutton = new System.Windows.Forms.RadioButton();
            this.china_radiobutton = new System.Windows.Forms.RadioButton();
            this.japan_radiobutton = new System.Windows.Forms.RadioButton();
            this.others_radiobutton = new System.Windows.Forms.RadioButton();
            this.male_radiobutton = new System.Windows.Forms.RadioButton();
            this.female_radiobutton = new System.Windows.Forms.RadioButton();
            this.gender_groupbox.SuspendLayout();
            this.nationality_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gender_groupbox
            // 
            this.gender_groupbox.Controls.Add(this.female_radiobutton);
            this.gender_groupbox.Controls.Add(this.male_radiobutton);
            this.gender_groupbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gender_groupbox.Location = new System.Drawing.Point(204, 36);
            this.gender_groupbox.Name = "gender_groupbox";
            this.gender_groupbox.Size = new System.Drawing.Size(149, 82);
            this.gender_groupbox.TabIndex = 32;
            this.gender_groupbox.TabStop = false;
            this.gender_groupbox.Text = "성별";
            // 
            // submit_button
            // 
            this.submit_button.AutoSize = true;
            this.submit_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.submit_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.submit_button.FlatAppearance.BorderSize = 2;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.submit_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submit_button.Location = new System.Drawing.Point(263, 179);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(90, 37);
            this.submit_button.TabIndex = 31;
            this.submit_button.Text = "제출";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // nationality_groupbox
            // 
            this.nationality_groupbox.Controls.Add(this.others_radiobutton);
            this.nationality_groupbox.Controls.Add(this.japan_radiobutton);
            this.nationality_groupbox.Controls.Add(this.china_radiobutton);
            this.nationality_groupbox.Controls.Add(this.korea_radiobutton);
            this.nationality_groupbox.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nationality_groupbox.Location = new System.Drawing.Point(36, 36);
            this.nationality_groupbox.Name = "nationality_groupbox";
            this.nationality_groupbox.Size = new System.Drawing.Size(144, 180);
            this.nationality_groupbox.TabIndex = 30;
            this.nationality_groupbox.TabStop = false;
            this.nationality_groupbox.Text = "국적";
            // 
            // korea_radiobutton
            // 
            this.korea_radiobutton.AutoSize = true;
            this.korea_radiobutton.Location = new System.Drawing.Point(19, 39);
            this.korea_radiobutton.Name = "korea_radiobutton";
            this.korea_radiobutton.Size = new System.Drawing.Size(105, 27);
            this.korea_radiobutton.TabIndex = 33;
            this.korea_radiobutton.TabStop = true;
            this.korea_radiobutton.Text = " 대한민국";
            this.korea_radiobutton.UseVisualStyleBackColor = true;
            // 
            // china_radiobutton
            // 
            this.china_radiobutton.AutoSize = true;
            this.china_radiobutton.Location = new System.Drawing.Point(19, 72);
            this.china_radiobutton.Name = "china_radiobutton";
            this.china_radiobutton.Size = new System.Drawing.Size(65, 27);
            this.china_radiobutton.TabIndex = 34;
            this.china_radiobutton.TabStop = true;
            this.china_radiobutton.Text = "중국";
            this.china_radiobutton.UseVisualStyleBackColor = true;
            // 
            // japan_radiobutton
            // 
            this.japan_radiobutton.AutoSize = true;
            this.japan_radiobutton.Location = new System.Drawing.Point(19, 105);
            this.japan_radiobutton.Name = "japan_radiobutton";
            this.japan_radiobutton.Size = new System.Drawing.Size(65, 27);
            this.japan_radiobutton.TabIndex = 35;
            this.japan_radiobutton.TabStop = true;
            this.japan_radiobutton.Text = "일본";
            this.japan_radiobutton.UseVisualStyleBackColor = true;
            // 
            // others_radiobutton
            // 
            this.others_radiobutton.AutoSize = true;
            this.others_radiobutton.Location = new System.Drawing.Point(19, 138);
            this.others_radiobutton.Name = "others_radiobutton";
            this.others_radiobutton.Size = new System.Drawing.Size(111, 27);
            this.others_radiobutton.TabIndex = 36;
            this.others_radiobutton.TabStop = true;
            this.others_radiobutton.Text = "그 외 국가";
            this.others_radiobutton.UseVisualStyleBackColor = true;
            // 
            // male_radiobutton
            // 
            this.male_radiobutton.AutoSize = true;
            this.male_radiobutton.Location = new System.Drawing.Point(17, 39);
            this.male_radiobutton.Name = "male_radiobutton";
            this.male_radiobutton.Size = new System.Drawing.Size(48, 27);
            this.male_radiobutton.TabIndex = 37;
            this.male_radiobutton.TabStop = true;
            this.male_radiobutton.Text = "남";
            this.male_radiobutton.UseVisualStyleBackColor = true;
            this.male_radiobutton.CheckedChanged += new System.EventHandler(this.male_radiobutton_CheckedChanged);
            // 
            // female_radiobutton
            // 
            this.female_radiobutton.AutoSize = true;
            this.female_radiobutton.Location = new System.Drawing.Point(81, 39);
            this.female_radiobutton.Name = "female_radiobutton";
            this.female_radiobutton.Size = new System.Drawing.Size(48, 27);
            this.female_radiobutton.TabIndex = 38;
            this.female_radiobutton.TabStop = true;
            this.female_radiobutton.Text = "여";
            this.female_radiobutton.UseVisualStyleBackColor = true;
            this.female_radiobutton.CheckedChanged += new System.EventHandler(this.female_radiobutton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 249);
            this.Controls.Add(this.gender_groupbox);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.nationality_groupbox);
            this.Name = "Form1";
            this.Text = "RadioButton";
            this.gender_groupbox.ResumeLayout(false);
            this.gender_groupbox.PerformLayout();
            this.nationality_groupbox.ResumeLayout(false);
            this.nationality_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gender_groupbox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.GroupBox nationality_groupbox;
        private System.Windows.Forms.RadioButton female_radiobutton;
        private System.Windows.Forms.RadioButton male_radiobutton;
        private System.Windows.Forms.RadioButton others_radiobutton;
        private System.Windows.Forms.RadioButton japan_radiobutton;
        private System.Windows.Forms.RadioButton china_radiobutton;
        private System.Windows.Forms.RadioButton korea_radiobutton;
    }
}

