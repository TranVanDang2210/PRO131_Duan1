namespace DUAN1_CS
{
    partial class form_order
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
            this.components = new System.ComponentModel.Container();
            this.maban_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mon_cbb = new System.Windows.Forms.ComboBox();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dU_AN_1DataSet = new DUAN1_CS.DU_AN_1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.them_bt = new System.Windows.Forms.Button();
            this.sua_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.soluong_ip = new System.Windows.Forms.TextBox();
            this.xoa_bt = new System.Windows.Forms.Button();
            this.mENUTableAdapter = new DUAN1_CS.DU_AN_1DataSetTableAdapters.MENUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maban_ip
            // 
            this.maban_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maban_ip.Location = new System.Drawing.Point(203, 70);
            this.maban_ip.Multiline = true;
            this.maban_ip.Name = "maban_ip";
            this.maban_ip.Size = new System.Drawing.Size(207, 43);
            this.maban_ip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Bàn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(66, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Món";
            // 
            // mon_cbb
            // 
            this.mon_cbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mon_cbb.DataSource = this.mENUBindingSource;
            this.mon_cbb.DisplayMember = "tenMon";
            this.mon_cbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mon_cbb.FormattingEnabled = true;
            this.mon_cbb.Location = new System.Drawing.Point(203, 144);
            this.mon_cbb.Name = "mon_cbb";
            this.mon_cbb.Size = new System.Drawing.Size(207, 33);
            this.mon_cbb.TabIndex = 7;
            this.mon_cbb.ValueMember = "tenMon";
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.dU_AN_1DataSet;
            // 
            // dU_AN_1DataSet
            // 
            this.dU_AN_1DataSet.DataSetName = "DU_AN_1DataSet";
            this.dU_AN_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(295, 302);
            this.dataGridView1.TabIndex = 8;
            // 
            // them_bt
            // 
            this.them_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them_bt.Location = new System.Drawing.Point(68, 307);
            this.them_bt.Name = "them_bt";
            this.them_bt.Size = new System.Drawing.Size(120, 51);
            this.them_bt.TabIndex = 9;
            this.them_bt.Text = "THÊM";
            this.them_bt.UseVisualStyleBackColor = true;
            this.them_bt.Click += new System.EventHandler(this.them_bt_Click);
            // 
            // sua_bt
            // 
            this.sua_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua_bt.Location = new System.Drawing.Point(203, 307);
            this.sua_bt.Name = "sua_bt";
            this.sua_bt.Size = new System.Drawing.Size(102, 51);
            this.sua_bt.TabIndex = 10;
            this.sua_bt.Text = "SỬA";
            this.sua_bt.UseVisualStyleBackColor = true;
            this.sua_bt.Click += new System.EventHandler(this.sua_bt_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(66, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Lượng";
            // 
            // soluong_ip
            // 
            this.soluong_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soluong_ip.Location = new System.Drawing.Point(203, 204);
            this.soluong_ip.Multiline = true;
            this.soluong_ip.Name = "soluong_ip";
            this.soluong_ip.Size = new System.Drawing.Size(207, 43);
            this.soluong_ip.TabIndex = 12;
            // 
            // xoa_bt
            // 
            this.xoa_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa_bt.Location = new System.Drawing.Point(329, 307);
            this.xoa_bt.Name = "xoa_bt";
            this.xoa_bt.Size = new System.Drawing.Size(99, 51);
            this.xoa_bt.TabIndex = 13;
            this.xoa_bt.Text = "XÓA";
            this.xoa_bt.UseVisualStyleBackColor = true;
            this.xoa_bt.Click += new System.EventHandler(this.xoa_bt_Click);
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // form_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(796, 479);
            this.Controls.Add(this.xoa_bt);
            this.Controls.Add(this.soluong_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sua_bt);
            this.Controls.Add(this.them_bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mon_cbb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maban_ip);
            this.Controls.Add(this.label1);
            this.Name = "form_order";
            this.Text = "ORDER";
            this.Load += new System.EventHandler(this.form_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maban_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mon_cbb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them_bt;
        private System.Windows.Forms.Button sua_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soluong_ip;
        private System.Windows.Forms.Button xoa_bt;
        private DU_AN_1DataSet dU_AN_1DataSet;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private DU_AN_1DataSetTableAdapters.MENUTableAdapter mENUTableAdapter;
    }
}