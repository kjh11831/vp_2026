namespace _009_checkbox
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
            this.apple = new System.Windows.Forms.CheckBox();
            this.question_label = new System.Windows.Forms.Label();
            this.pear = new System.Windows.Forms.CheckBox();
            this.strawberry = new System.Windows.Forms.CheckBox();
            this.banana = new System.Windows.Forms.CheckBox();
            this.orange = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apple
            // 
            this.apple.AutoSize = true;
            this.apple.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.apple.Location = new System.Drawing.Point(44, 84);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(66, 27);
            this.apple.TabIndex = 0;
            this.apple.Text = "사과";
            this.apple.UseVisualStyleBackColor = true;
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.question_label.Location = new System.Drawing.Point(40, 36);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(310, 23);
            this.question_label.TabIndex = 1;
            this.question_label.Text = "질문: 좋아하는 과일을 모두 선택하세요";
            // 
            // pear
            // 
            this.pear.AutoSize = true;
            this.pear.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pear.Location = new System.Drawing.Point(44, 117);
            this.pear.Name = "pear";
            this.pear.Size = new System.Drawing.Size(49, 27);
            this.pear.TabIndex = 2;
            this.pear.Text = "배";
            this.pear.UseVisualStyleBackColor = true;
            // 
            // strawberry
            // 
            this.strawberry.AutoSize = true;
            this.strawberry.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.strawberry.Location = new System.Drawing.Point(44, 150);
            this.strawberry.Name = "strawberry";
            this.strawberry.Size = new System.Drawing.Size(66, 27);
            this.strawberry.TabIndex = 3;
            this.strawberry.Text = "딸기";
            this.strawberry.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.banana.Location = new System.Drawing.Point(44, 183);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(83, 27);
            this.banana.TabIndex = 4;
            this.banana.Text = "바나나";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // orange
            // 
            this.orange.AutoSize = true;
            this.orange.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orange.Location = new System.Drawing.Point(44, 216);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(83, 27);
            this.orange.TabIndex = 5;
            this.orange.Text = "오렌지";
            this.orange.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(255, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(386, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.banana);
            this.Controls.Add(this.strawberry);
            this.Controls.Add(this.pear);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.apple);
            this.Name = "Form1";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox apple;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.CheckBox pear;
        private System.Windows.Forms.CheckBox strawberry;
        private System.Windows.Forms.CheckBox banana;
        private System.Windows.Forms.CheckBox orange;
        private System.Windows.Forms.Button button1;
    }
}

