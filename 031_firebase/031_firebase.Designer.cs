namespace _031_firebase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id_number = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.id_number = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.txt_phone_number = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(607, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_id_number
            // 
            this.txt_id_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id_number.Location = new System.Drawing.Point(109, 308);
            this.txt_id_number.Multiline = true;
            this.txt_id_number.Name = "txt_id_number";
            this.txt_id_number.PasswordChar = '*';
            this.txt_id_number.Size = new System.Drawing.Size(207, 29);
            this.txt_id_number.TabIndex = 22;
            this.txt_id_number.Text = "\r\n\r\n";
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(109, 264);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 29);
            this.txt_id.TabIndex = 21;
            this.txt_id.Text = "\r\n\r\n";
            // 
            // id_number
            // 
            this.id_number.AutoSize = true;
            this.id_number.Font = new System.Drawing.Font("굴림", 10F);
            this.id_number.Location = new System.Drawing.Point(15, 315);
            this.id_number.Name = "id_number";
            this.id_number.Size = new System.Drawing.Size(42, 17);
            this.id_number.TabIndex = 20;
            this.id_number.Text = "학번";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("굴림", 10F);
            this.id.Location = new System.Drawing.Point(15, 270);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 17);
            this.id.TabIndex = 19;
            this.id.Text = "ID";
            // 
            // txt_phone_number
            // 
            this.txt_phone_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone_number.Location = new System.Drawing.Point(109, 401);
            this.txt_phone_number.Multiline = true;
            this.txt_phone_number.Name = "txt_phone_number";
            this.txt_phone_number.PasswordChar = '*';
            this.txt_phone_number.Size = new System.Drawing.Size(207, 29);
            this.txt_phone_number.TabIndex = 26;
            this.txt_phone_number.Text = "\r\n\r\n";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(109, 357);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 29);
            this.txt_name.TabIndex = 25;
            this.txt_name.Text = "\r\n\r\n";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Font = new System.Drawing.Font("굴림", 10F);
            this.phone_number.Location = new System.Drawing.Point(15, 408);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(76, 17);
            this.phone_number.TabIndex = 24;
            this.phone_number.Text = "전화번호";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 10F);
            this.name.Location = new System.Drawing.Point(15, 363);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 17);
            this.name.TabIndex = 23;
            this.name.Text = "이름";
            // 
            // btn_view_all
            // 
            this.btn_view_all.AutoSize = true;
            this.btn_view_all.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_view_all.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_view_all.FlatAppearance.BorderSize = 2;
            this.btn_view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_all.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_view_all.Location = new System.Drawing.Point(401, 264);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(94, 29);
            this.btn_view_all.TabIndex = 27;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(401, 308);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_search.FlatAppearance.BorderSize = 2;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_search.Location = new System.Drawing.Point(401, 352);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_clear.FlatAppearance.BorderSize = 2;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(401, 401);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_end
            // 
            this.btn_end.AutoSize = true;
            this.btn_end.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_end.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_end.FlatAppearance.BorderSize = 2;
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_end.Location = new System.Drawing.Point(525, 401);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(94, 29);
            this.btn_end.TabIndex = 33;
            this.btn_end.Text = "종료";
            this.btn_end.UseVisualStyleBackColor = false;
            // 
            // btn_fix
            // 
            this.btn_fix.AutoSize = true;
            this.btn_fix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_fix.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_fix.FlatAppearance.BorderSize = 2;
            this.btn_fix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_fix.Location = new System.Drawing.Point(525, 352);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(94, 29);
            this.btn_fix.TabIndex = 32;
            this.btn_fix.Text = "수정";
            this.btn_fix.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_delete.FlatAppearance.BorderSize = 2;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(525, 308);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.txt_phone_number);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txt_id_number);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.id_number);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "전화번호부";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id_number;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label id_number;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txt_phone_number;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_delete;
    }
}

