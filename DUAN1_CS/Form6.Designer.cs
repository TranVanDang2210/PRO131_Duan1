namespace DUAN1_CS
{
    partial class form_tinhtien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tinhtien_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dsmon = new System.Windows.Forms.ListBox();
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dU_AN_1DataSet2 = new DUAN1_CS.DU_AN_1DataSet2();
            this.bILLTableAdapter = new DUAN1_CS.DU_AN_1DataSet2TableAdapters.BILLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(251, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tinhtien_bt
            // 
            this.tinhtien_bt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tinhtien_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tinhtien_bt.ForeColor = System.Drawing.Color.Black;
            this.tinhtien_bt.Location = new System.Drawing.Point(125, 346);
            this.tinhtien_bt.Name = "tinhtien_bt";
            this.tinhtien_bt.Size = new System.Drawing.Size(228, 55);
            this.tinhtien_bt.TabIndex = 1;
            this.tinhtien_bt.Text = "Tính Tiền";
            this.tinhtien_bt.UseVisualStyleBackColor = true;
            this.tinhtien_bt.Click += new System.EventHandler(this.tinhtien_bt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Món";
            // 
            // dsmon
            // 
            this.dsmon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dsmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dsmon.FormattingEnabled = true;
            this.dsmon.ItemHeight = 25;
            this.dsmon.Location = new System.Drawing.Point(125, 90);
            this.dsmon.Name = "dsmon";
            this.dsmon.Size = new System.Drawing.Size(228, 204);
            this.dsmon.TabIndex = 6;
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.dU_AN_1DataSet2;
            // 
            // dU_AN_1DataSet2
            // 
            this.dU_AN_1DataSet2.DataSetName = "DU_AN_1DataSet2";
            this.dU_AN_1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLTableAdapter
            // 
            this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // form_tinhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(774, 424);
            this.Controls.Add(this.dsmon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tinhtien_bt);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "form_tinhtien";
            this.Text = "TÍNH TIỀN";
            this.Load += new System.EventHandler(this.form_tinhtien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dU_AN_1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tinhtien_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox dsmon;
        private DU_AN_1DataSet2 dU_AN_1DataSet2;
        private System.Windows.Forms.BindingSource bILLBindingSource;
        private DU_AN_1DataSet2TableAdapters.BILLTableAdapter bILLTableAdapter;
    }
}