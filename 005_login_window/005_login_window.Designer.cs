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
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_result
            // 
            this.login_result.AutoSize = true;
            this.login_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_result.Font = new System.Drawing.Font("굴림", 10F);
            this.login_result.Location = new System.Drawing.Point(437, 248);
            this.login_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_result.Name = "login_result";
            this.login_result.Size = new System.Drawing.Size(0, 24);
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
            this.login_button.Location = new System.Drawing.Point(366, 186);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(104, 41);
            this.login_button.TabIndex = 16;
            this.login_button.Text = "로그인";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_textbox.Location = new System.Drawing.Point(186, 60);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_textbox.Multiline = true;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(284, 40);
            this.id_textbox.TabIndex = 14;
            this.id_textbox.Text = "\r\n\r\n";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("굴림", 10F);
            this.password.Location = new System.Drawing.Point(54, 132);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(106, 24);
            this.password.TabIndex = 13;
            this.password.Text = "패스워드";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("굴림", 10F);
            this.id.Location = new System.Drawing.Point(77, 69);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(82, 24);
            this.id.TabIndex = 12;
            this.id.Text = "아이디";
            // 
            // password_textbox
            // 
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textbox.Location = new System.Drawing.Point(186, 122);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_textbox.Multiline = true;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(284, 40);
            this.password_textbox.TabIndex = 18;
            this.password_textbox.Text = "\r\n\r\n";
            // 
            // result_textbox
            // 
            this.result_textbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Location = new System.Drawing.Point(186, 248);
            this.result_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result_textbox.Multiline = true;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(284, 40);
            this.result_textbox.TabIndex = 19;
            this.result_textbox.Text = "\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 346);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_result);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_result;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox result_textbox;
    }
}

