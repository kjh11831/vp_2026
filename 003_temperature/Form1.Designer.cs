namespace _003_temperature
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
            this.C = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.btnF_C = new System.Windows.Forms.Button();
            this.btnC2F = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("굴림", 10F);
            this.C.Location = new System.Drawing.Point(57, 42);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(81, 17);
            this.C.TabIndex = 1;
            this.C.Text = "섭씨 온도";
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("굴림", 10F);
            this.F.Location = new System.Drawing.Point(267, 42);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(81, 17);
            this.F.TabIndex = 2;
            this.F.Text = "화씨 온도";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("굴림", 10F);
            this.txtC.Location = new System.Drawing.Point(47, 74);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 27);
            this.txtC.TabIndex = 3;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("굴림", 10F);
            this.txtF.Location = new System.Drawing.Point(257, 74);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 27);
            this.txtF.TabIndex = 4;
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnF_C
            // 
            this.btnF_C.Font = new System.Drawing.Font("굴림", 10F);
            this.btnF_C.Location = new System.Drawing.Point(165, 90);
            this.btnF_C.Name = "btnF_C";
            this.btnF_C.Size = new System.Drawing.Size(75, 23);
            this.btnF_C.TabIndex = 5;
            this.btnF_C.Text = "←";
            this.btnF_C.UseVisualStyleBackColor = true;
            this.btnF_C.Click += new System.EventHandler(this.btnF_C_Click);
            // 
            // btnC2F
            // 
            this.btnC2F.Font = new System.Drawing.Font("굴림", 10F);
            this.btnC2F.Location = new System.Drawing.Point(165, 61);
            this.btnC2F.Name = "btnC2F";
            this.btnC2F.Size = new System.Drawing.Size(75, 23);
            this.btnC2F.TabIndex = 6;
            this.btnC2F.Text = "→";
            this.btnC2F.UseVisualStyleBackColor = true;
            this.btnC2F.Click += new System.EventHandler(this.btnC2F_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 155);
            this.Controls.Add(this.btnC2F);
            this.Controls.Add(this.btnF_C);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.F);
            this.Controls.Add(this.C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button btnF_C;
        private System.Windows.Forms.Button btnC2F;
    }
}

