namespace DUAN1_CS
{
    partial class form_qlll
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
            this.calam_ip = new System.Windows.Forms.TextBox();
            this.ngaylam_ip = new System.Windows.Forms.TextBox();
            this.manv_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.sua_bt = new System.Windows.Forms.Button();
            this.them_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calam_ip
            // 
            this.calam_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calam_ip.Location = new System.Drawing.Point(208, 247);
            this.calam_ip.Multiline = true;
            this.calam_ip.Name = "calam_ip";
            this.calam_ip.Size = new System.Drawing.Size(207, 41);
            this.calam_ip.TabIndex = 19;
            // 
            // ngaylam_ip
            // 
            this.ngaylam_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngaylam_ip.Location = new System.Drawing.Point(208, 170);
            this.ngaylam_ip.Multiline = true;
            this.ngaylam_ip.Name = "ngaylam_ip";
            this.ngaylam_ip.Size = new System.Drawing.Size(207, 41);
            this.ngaylam_ip.TabIndex = 18;
            // 
            // manv_ip
            // 
            this.manv_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manv_ip.Location = new System.Drawing.Point(208, 86);
            this.manv_ip.Multiline = true;
            this.manv_ip.Name = "manv_ip";
            this.manv_ip.Size = new System.Drawing.Size(207, 41);
            this.manv_ip.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(108, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ca làm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(88, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày làm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(47, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã nhân viên ";
            // 
            // xoa_bt
            // 
            this.xoa_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa_bt.Location = new System.Drawing.Point(331, 348);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(84, 77);
            this.xoa_bt.TabIndex = 13;
            this.xoa_bt.Text = "Xóa";
            this.xoa_bt.UseVisualStyleBackColor = true;
            this.xoa_bt.Click += new System.EventHandler(this.xoa_bt_Click_1);
            // 
            // sua_bt
            // 
            this.sua_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua_bt.Location = new System.Drawing.Point(208, 348);
            this.sua_bt.Name = "sua_bt";
            this.sua_bt.Size = new System.Drawing.Size(89, 77);
            this.sua_bt.TabIndex = 12;
            this.sua_bt.Text = "Sửa ";
            this.sua_bt.UseVisualStyleBackColor = true;
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them_bt.Location = new System.Drawing.Point(64, 348);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(99, 77);
            this.them_bt.TabIndex = 11;
            this.them_bt.Text = "Thêm";
            this.them_bt.UseVisualStyleBackColor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 447);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(64, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 69);
            this.button1.TabIndex = 20;
            this.button1.Text = "DUYỆT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(208, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 69);
            this.button2.TabIndex = 21;
            this.button2.Text = "TỪ CHỐI DUYỆT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form_qlll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1066, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calam_ip);
            this.Controls.Add(this.ngaylam_ip);
            this.Controls.Add(this.manv_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoa_bt);
            this.Controls.Add(this.sua_bt);
            this.Controls.Add(this.them_bt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_qlll";
            this.Text = "QUẢN LÝ LỊCH LÀM";
            this.Load += new System.EventHandler(this.form_qlll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calam_ip;
        private System.Windows.Forms.TextBox ngaylam_ip;
        private System.Windows.Forms.TextBox manv_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xoa_bt;
        private System.Windows.Forms.Button sua_bt;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}