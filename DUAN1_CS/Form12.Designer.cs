namespace DUAN1_CS
{
    partial class form_dkll
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.them_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calam_ip
            // 
            this.calam_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calam_ip.Location = new System.Drawing.Point(165, 209);
            this.calam_ip.Multiline = true;
            this.calam_ip.Name = "calam_ip";
            this.calam_ip.Size = new System.Drawing.Size(169, 41);
            this.calam_ip.TabIndex = 25;
            // 
            // ngaylam_ip
            // 
            this.ngaylam_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngaylam_ip.Location = new System.Drawing.Point(165, 114);
            this.ngaylam_ip.Multiline = true;
            this.ngaylam_ip.Name = "ngaylam_ip";
            this.ngaylam_ip.Size = new System.Drawing.Size(169, 41);
            this.ngaylam_ip.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ca làm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày làm";
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them_bt.Location = new System.Drawing.Point(165, 309);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(169, 77);
            this.them_bt.TabIndex = 21;
            this.them_bt.Text = "Đăng Kí Lịch Làm";
            this.them_bt.UseVisualStyleBackColor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 302);
            this.dataGridView1.TabIndex = 20;
            // 
            // form_dkll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 471);
            this.Controls.Add(this.calam_ip);
            this.Controls.Add(this.ngaylam_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.them_bt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_dkll";
            this.Text = "ĐĂNG KÍ LỊCH LÀM";
            this.Load += new System.EventHandler(this.form_dkll_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calam_ip;
        private System.Windows.Forms.TextBox ngaylam_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}