namespace _005_login_window
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
            this.login_result = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.id_text = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.result_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_result
            // 
            this.login_result.AutoSize = true;
            this.login_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_result.Font = new System.Drawing.Font("굴림", 10F);
            this.login_result.Location = new System.Drawing.Point(318, 177);
            this.login_result.Name = "login_result";
            this.login_result.Size = new System.Drawing.Size(0, 17);
            this.login_result.TabIndex = 17;
            // 
            // login_button
            // 
            this.login_button.AutoSize = true;
            this.login_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.login_button.FlatAppearance.BorderSize = 2;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_button.Location = new System.Drawing.Point(266, 133);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(76, 29);
            this.login_button.TabIndex = 16;
            this.login_button.Text = "로그인";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.bmi_button_Click);
            // 
            // id_text
            // 
            this.id_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_text.Location = new System.Drawing.Point(135, 43);
            this.id_text.Multiline = true;
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(207, 29);
            this.id_text.TabIndex = 14;
            this.id_text.Text = "\r\n\r\n";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("굴림", 10F);
            this.password.Location = new System.Drawing.Point(39, 94);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(76, 17);
            this.password.TabIndex = 13;
            this.password.Text = "패스워드";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("굴림", 10F);
            this.id.Location = new System.Drawing.Point(56, 49);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 17);
            this.id.TabIndex = 12;
            this.id.Text = "아이디";
            // 
            // password_text
            // 
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_text.Location = new System.Drawing.Point(135, 87);
            this.password_text.Multiline = true;
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(207, 29);
            this.password_text.TabIndex = 18;
            this.password_text.Text = "\r\n\r\n";
            // 
            // result_text
            // 
            this.result_text.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_text.Location = new System.Drawing.Point(135, 177);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(207, 29);
            this.result_text.TabIndex = 19;
            this.result_text.Text = "\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 247);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_result);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_result;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox result_text;
    }
}

