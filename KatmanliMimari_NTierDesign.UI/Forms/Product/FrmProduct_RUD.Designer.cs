namespace KatmanliMimari_NTierDesign.UI.Forms.Product
{
    partial class FrmProduct_RUD
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
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lst_ProductList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Details = new System.Windows.Forms.Button();
            this.txt_UnitsInStok = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.cmb_CategoryID = new System.Windows.Forms.ComboBox();
            this.cmb_SupplierID = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Sort = new System.Windows.Forms.ComboBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(104, 444);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(119, 20);
            this.txt_ProductName.TabIndex = 13;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(307, 480);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 42);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "SİL";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Update.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(91, 480);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(152, 42);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lst_ProductList
            // 
            this.lst_ProductList.BackColor = System.Drawing.Color.Gray;
            this.lst_ProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lst_ProductList.FullRowSelect = true;
            this.lst_ProductList.GridLines = true;
            this.lst_ProductList.HideSelection = false;
            this.lst_ProductList.Location = new System.Drawing.Point(22, 133);
            this.lst_ProductList.Margin = new System.Windows.Forms.Padding(2);
            this.lst_ProductList.Name = "lst_ProductList";
            this.lst_ProductList.Size = new System.Drawing.Size(724, 299);
            this.lst_ProductList.TabIndex = 10;
            this.lst_ProductList.UseCompatibleStateImageBehavior = false;
            this.lst_ProductList.View = System.Windows.Forms.View.Details;
            this.lst_ProductList.Click += new System.EventHandler(this.lst_ProductList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 51;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÜRÜN ADI";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STOK";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FİYAT";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KATEGORİ";
            this.columnHeader5.Width = 193;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MARKA";
            this.columnHeader6.Width = 215;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "ÜRÜN GÜNCELLEME SİLME FORMU";
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Details.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Details.Location = new System.Drawing.Point(525, 480);
            this.btn_Details.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(152, 42);
            this.btn_Details.TabIndex = 12;
            this.btn_Details.Text = "DETAY";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // txt_UnitsInStok
            // 
            this.txt_UnitsInStok.Location = new System.Drawing.Point(230, 444);
            this.txt_UnitsInStok.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UnitsInStok.Name = "txt_UnitsInStok";
            this.txt_UnitsInStok.Size = new System.Drawing.Size(89, 20);
            this.txt_UnitsInStok.TabIndex = 13;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(338, 444);
            this.txt_UnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(81, 20);
            this.txt_UnitPrice.TabIndex = 13;
            // 
            // cmb_CategoryID
            // 
            this.cmb_CategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CategoryID.FormattingEnabled = true;
            this.cmb_CategoryID.Location = new System.Drawing.Point(434, 444);
            this.cmb_CategoryID.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CategoryID.Name = "cmb_CategoryID";
            this.cmb_CategoryID.Size = new System.Drawing.Size(110, 21);
            this.cmb_CategoryID.TabIndex = 14;
            // 
            // cmb_SupplierID
            // 
            this.cmb_SupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SupplierID.FormattingEnabled = true;
            this.cmb_SupplierID.Location = new System.Drawing.Point(560, 444);
            this.cmb_SupplierID.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_SupplierID.Name = "cmb_SupplierID";
            this.cmb_SupplierID.Size = new System.Drawing.Size(117, 21);
            this.cmb_SupplierID.TabIndex = 14;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(91, 63);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(152, 20);
            this.txt_Search.TabIndex = 15;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "ARA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "SIRALA";
            // 
            // cmb_Sort
            // 
            this.cmb_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sort.FormattingEnabled = true;
            this.cmb_Sort.Location = new System.Drawing.Point(560, 60);
            this.cmb_Sort.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Sort.Name = "cmb_Sort";
            this.cmb_Sort.Size = new System.Drawing.Size(152, 21);
            this.cmb_Sort.TabIndex = 14;
            this.cmb_Sort.SelectedIndexChanged += new System.EventHandler(this.cmb_Sort_SelectedIndexChanged);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(648, 103);
            this.lbl_Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(98, 19);
            this.lbl_Count.TabIndex = 17;
            this.lbl_Count.Text = "0 ADET ÜRÜN VAR";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(11, 532);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(13, 13);
            this.lbl_info.TabIndex = 18;
            this.lbl_info.Text = "0";
            // 
            // FrmProduct_RUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 554);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cmb_SupplierID);
            this.Controls.Add(this.cmb_Sort);
            this.Controls.Add(this.cmb_CategoryID);
            this.Controls.Add(this.txt_UnitPrice);
            this.Controls.Add(this.txt_UnitsInStok);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lst_ProductList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProduct_RUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct_RUD";
            this.Load += new System.EventHandler(this.FrmProduct_RUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ListView lst_ProductList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.TextBox txt_UnitsInStok;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.ComboBox cmb_CategoryID;
        private System.Windows.Forms.ComboBox cmb_SupplierID;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Sort;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_info;
    }
}