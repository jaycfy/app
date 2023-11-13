namespace Kimphat
{
    partial class UC_Main_Products
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DGV_UC_Products_A = new DataGridView();
            label1 = new Label();
            CKB_UC_Products_See_Mine = new CheckBox();
            TXT_Search = new TextBox();
            pictureBox1 = new PictureBox();
            PCB_UC_Product_Image = new PictureBox();
            PCB_UC_Product_UPC = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGV_UC_Products_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_UPC).BeginInit();
            SuspendLayout();
            // 
            // DGV_UC_Products_A
            // 
            DGV_UC_Products_A.AllowUserToAddRows = false;
            DGV_UC_Products_A.AllowUserToDeleteRows = false;
            DGV_UC_Products_A.AllowUserToOrderColumns = true;
            DGV_UC_Products_A.AllowUserToResizeRows = false;
            DGV_UC_Products_A.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_UC_Products_A.BackgroundColor = Color.White;
            DGV_UC_Products_A.BorderStyle = BorderStyle.None;
            DGV_UC_Products_A.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_UC_Products_A.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_UC_Products_A.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_UC_Products_A.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_UC_Products_A.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_UC_Products_A.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_UC_Products_A.GridColor = Color.White;
            DGV_UC_Products_A.Location = new Point(23, 65);
            DGV_UC_Products_A.MultiSelect = false;
            DGV_UC_Products_A.Name = "DGV_UC_Products_A";
            DGV_UC_Products_A.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Gotham", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_UC_Products_A.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGV_UC_Products_A.RowHeadersVisible = false;
            DGV_UC_Products_A.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGV_UC_Products_A.RowTemplate.Height = 25;
            DGV_UC_Products_A.RowTemplate.ReadOnly = true;
            DGV_UC_Products_A.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_UC_Products_A.Size = new Size(1587, 522);
            DGV_UC_Products_A.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Gotham", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(227, 15, 44);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 4;
            label1.Text = "Produits";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CKB_UC_Products_See_Mine
            // 
            CKB_UC_Products_See_Mine.AutoSize = true;
            CKB_UC_Products_See_Mine.Checked = true;
            CKB_UC_Products_See_Mine.CheckState = CheckState.Checked;
            CKB_UC_Products_See_Mine.Font = new Font("Gotham", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CKB_UC_Products_See_Mine.ForeColor = Color.FromArgb(40, 40, 40);
            CKB_UC_Products_See_Mine.Location = new Point(128, 34);
            CKB_UC_Products_See_Mine.Name = "CKB_UC_Products_See_Mine";
            CKB_UC_Products_See_Mine.Size = new Size(129, 21);
            CKB_UC_Products_See_Mine.TabIndex = 5;
            CKB_UC_Products_See_Mine.Text = "Voir les miens";
            CKB_UC_Products_See_Mine.UseVisualStyleBackColor = true;
            CKB_UC_Products_See_Mine.CheckedChanged += CKB_UC_Products_See_Mine_CheckedChanged;
            // 
            // TXT_Search
            // 
            TXT_Search.Cursor = Cursors.IBeam;
            TXT_Search.Font = new Font("Gotham", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Search.ForeColor = Color.FromArgb(40, 40, 40);
            TXT_Search.Location = new Point(1136, 33);
            TXT_Search.Name = "TXT_Search";
            TXT_Search.Size = new Size(474, 26);
            TXT_Search.TabIndex = 6;
            TXT_Search.TextChanged += TXT_Search_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow;
            pictureBox1.Location = new Point(1100, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // PCB_UC_Product_Image
            // 
            PCB_UC_Product_Image.Location = new Point(23, 740);
            PCB_UC_Product_Image.Name = "PCB_UC_Product_Image";
            PCB_UC_Product_Image.Size = new Size(325, 261);
            PCB_UC_Product_Image.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_Product_Image.TabIndex = 8;
            PCB_UC_Product_Image.TabStop = false;
            // 
            // PCB_UC_Product_UPC
            // 
            PCB_UC_Product_UPC.Location = new Point(23, 662);
            PCB_UC_Product_UPC.Name = "PCB_UC_Product_UPC";
            PCB_UC_Product_UPC.Size = new Size(325, 62);
            PCB_UC_Product_UPC.SizeMode = PictureBoxSizeMode.Zoom;
            PCB_UC_Product_UPC.TabIndex = 9;
            PCB_UC_Product_UPC.TabStop = false;
            // 
            // UC_Main_Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(PCB_UC_Product_UPC);
            Controls.Add(PCB_UC_Product_Image);
            Controls.Add(pictureBox1);
            Controls.Add(TXT_Search);
            Controls.Add(CKB_UC_Products_See_Mine);
            Controls.Add(label1);
            Controls.Add(DGV_UC_Products_A);
            Name = "UC_Main_Products";
            Size = new Size(1634, 1037);
            Load += UC_Main_Products_A_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_UC_Products_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCB_UC_Product_UPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_UC_Products_A;
        private Label label1;
        private CheckBox CKB_UC_Products_See_Mine;
        private TextBox TXT_Search;
        private PictureBox pictureBox1;
        private PictureBox PCB_UC_Product_Image;
        private PictureBox PCB_UC_Product_UPC;
    }
}
