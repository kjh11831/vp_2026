namespace _016_chart_control_with_two_series
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.one_chart_button = new System.Windows.Forms.Button();
            this.two_chart_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 25);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(612, 465);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // one_chart_button
            // 
            this.one_chart_button.AutoSize = true;
            this.one_chart_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.one_chart_button.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.one_chart_button.FlatAppearance.BorderSize = 2;
            this.one_chart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_chart_button.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.one_chart_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.one_chart_button.Location = new System.Drawing.Point(129, 505);
            this.one_chart_button.Name = "one_chart_button";
            this.one_chart_button.Size = new System.Drawing.Size(132, 37);
            this.one_chart_button.TabIndex = 21;
            this.one_chart_button.Text = "합쳐서 그리기";
            this.one_chart_button.UseVisualStyleBackColor = false;
            this.one_chart_button.Click += new System.EventHandler(this.one_chart_button_Click);
            // 
            // two_chart_button
            // 
            this.two_chart_button.AutoSize = true;
            this.two_chart_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.two_chart_button.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.two_chart_button.FlatAppearance.BorderSize = 2;
            this.two_chart_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_chart_button.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.two_chart_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.two_chart_button.Location = new System.Drawing.Point(395, 505);
            this.two_chart_button.Name = "two_chart_button";
            this.two_chart_button.Size = new System.Drawing.Size(132, 37);
            this.two_chart_button.TabIndex = 22;
            this.two_chart_button.Text = "나누어 그리기";
            this.two_chart_button.UseVisualStyleBackColor = false;
            this.two_chart_button.Click += new System.EventHandler(this.two_chart_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(667, 580);
            this.Controls.Add(this.two_chart_button);
            this.Controls.Add(this.one_chart_button);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Using Chart Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button one_chart_button;
        private System.Windows.Forms.Button two_chart_button;
    }
}

