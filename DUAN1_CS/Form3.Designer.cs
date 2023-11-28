namespace DUAN1_CS
{
    partial class form_qlnv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten_ip = new System.Windows.Forms.TextBox();
            this.sdt_ip = new System.Windows.Forms.TextBox();
            this.nam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nu = new System.Windows.Forms.RadioButton();
            this.diachi_ip = new System.Windows.Forms.TextBox();
            this.chucvu_cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vitrilam_cbb = new System.Windows.Forms.ComboBox();
            this.them_bt = new System.Windows.Forms.Button();
            this.sua_bt = new System.Windows.Forms.Button();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // ten_ip
            // 
            this.ten_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ten_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ten_ip.Location = new System.Drawing.Point(214, 83);
            this.ten_ip.Multiline = true;
            this.ten_ip.Name = "ten_ip";
            this.ten_ip.Size = new System.Drawing.Size(265, 39);
            this.ten_ip.TabIndex = 1;
            // 
            // sdt_ip
            // 
            this.sdt_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdt_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sdt_ip.Location = new System.Drawing.Point(214, 149);
            this.sdt_ip.Multiline = true;
            this.sdt_ip.Name = "sdt_ip";
            this.sdt_ip.Size = new System.Drawing.Size(265, 43);
            this.sdt_ip.TabIndex = 2;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(3, 14);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(68, 26);
            this.nam.TabIndex = 3;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.nu);
            this.panel1.Controls.Add(this.nam);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(214, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 50);
            this.panel1.TabIndex = 4;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(112, 14);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(54, 26);
            this.nu.TabIndex = 5;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // diachi_ip
            // 
            this.diachi_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diachi_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diachi_ip.Location = new System.Drawing.Point(665, 83);
            this.diachi_ip.Multiline = true;
            this.diachi_ip.Name = "diachi_ip";
            this.diachi_ip.Size = new System.Drawing.Size(213, 39);
            this.diachi_ip.TabIndex = 5;
            // 
            // chucvu_cbb
            // 
            this.chucvu_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chucvu_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chucvu_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chucvu_cbb.FormattingEnabled = true;
            this.chucvu_cbb.Items.AddRange(new object[] {
            "Quản lý\t",
            "Nhân viên thu ngân",
            "Nhân viên pha chế",
            "Nhân viên phục vụ"});
            this.chucvu_cbb.Location = new System.Drawing.Point(665, 221);
            this.chucvu_cbb.Name = "chucvu_cbb";
            this.chucvu_cbb.Size = new System.Drawing.Size(213, 33);
            this.chucvu_cbb.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên ";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(123, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "SĐT";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(569, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa Chỉ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(543, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vị Trí Làm";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(558, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chức Vụ";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // vitrilam_cbb
            // 
            this.vitrilam_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vitrilam_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vitrilam_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.vitrilam_cbb.FormattingEnabled = true;
            this.vitrilam_cbb.Items.AddRange(new object[] {
            "KHU A",
            "KHU B",
            "KHU C",
            "KHU D",
            "QUẦY THU NGÂN",
            "QUẦY PHA CHẾ"});
            this.vitrilam_cbb.Location = new System.Drawing.Point(665, 159);
            this.vitrilam_cbb.Name = "vitrilam_cbb";
            this.vitrilam_cbb.Size = new System.Drawing.Size(213, 33);
            this.vitrilam_cbb.TabIndex = 13;
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.Location = new System.Drawing.Point(245, 551);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(146, 52);
            this.them_bt.TabIndex = 14;
            this.them_bt.Text = "THÊM";
            this.them_bt.UseVisualStyleBackColor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // sua_bt
            // 
            this.sua_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua_bt.Location = new System.Drawing.Point(492, 551);
            this.sua_bt.Name = "sua_bt";
            this.sua_bt.Size = new System.Drawing.Size(146, 52);
            this.sua_bt.TabIndex = 15;
            this.sua_bt.Text = "SỬA";
            this.sua_bt.UseVisualStyleBackColor = true;
            this.sua_bt.Click += new System.EventHandler(this.sua_bt_Click);
            // 
            // xoa_bt
            // 
            this.xoa_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa_bt.Location = new System.Drawing.Point(732, 551);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(146, 52);
            this.xoa_bt.TabIndex = 16;
            this.xoa_bt.Text = "XÓA";
            this.xoa_bt.UseVisualStyleBackColor = true;
            this.xoa_bt.Click += new System.EventHandler(this.xoa_bt_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(94, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới Tính";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // form_qlnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1100, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xoa_bt);
            this.Controls.Add(this.sua_bt);
            this.Controls.Add(this.them_bt);
            this.Controls.Add(this.vitrilam_cbb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chucvu_cbb);
            this.Controls.Add(this.diachi_ip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sdt_ip);
            this.Controls.Add(this.ten_ip);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "form_qlnv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.form_qlnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ten_ip;
        private System.Windows.Forms.TextBox sdt_ip;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.TextBox diachi_ip;
        private System.Windows.Forms.ComboBox chucvu_cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vitrilam_cbb;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.Button sua_bt;
        private System.Windows.Forms.Button xoa_bt;
        private System.Windows.Forms.Label label6;
    }
}