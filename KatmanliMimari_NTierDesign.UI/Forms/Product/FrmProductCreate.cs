using KatmanliMimari_NTierDesign.BusinessLayer;
using KatmanliMimari_NTierDesign.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimari_NTierDesign.UI.Forms.Product
{
    public partial class FrmProductCreate : Form
    {
        public FrmProductCreate()
        {
            InitializeComponent();
        }
        // nesne oluşturma
        ProductRepository cls_Product = new ProductRepository();
        CategoryRepository cls_Category = new CategoryRepository();
        SupplierRepository cls_Supplier = new SupplierRepository();
        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //kullanıcıdan aldığmız verileri , property lere gönderdik

            cls_Product.ProductName = txt_productName.Text;
            cls_Product.UnitsInStock = Convert.ToInt32(txt_UnitsInStock.Text);
            cls_Product.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);
            cls_Product.CategoryID = cls_Category.FindID(cmb_CategoryID.SelectedItem.ToString());
            cls_Product.SupplierID = cls_Supplier.FindID(cmb_SupplierID.SelectedItem.ToString());

            // metodtan dönen sonucu answer değişkenine attım
            bool answer = cls_Product.Save();
            
            CleanProperty();
            MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), answer, CrudTypes.Insert));
        }

        void CleanProperty()
        {
            txt_productName.Text = txt_UnitPrice.Text = txt_UnitsInStock.Text = "";
            cmb_CategoryID.SelectedIndex = cmb_SupplierID.SelectedIndex = -1;
        }

        private void FrmProductCreate_Load(object sender, EventArgs e)
        {
            Fill_Category_Combobox();
            Fill_Supplier_Combobox();
            lbl_info.Text = Common_Messages.Info;
        }

        void Fill_Category_Combobox()
        {
            cmb_CategoryID.Items.Clear();
            SqlDataReader categoryList = cls_Category.Select();

            while (categoryList.Read())
            {
                cmb_CategoryID.Items.Add(categoryList[1]);
            }
        }

        void Fill_Supplier_Combobox()
        {
            cmb_SupplierID.Items.Clear();
            SqlDataReader supplierList = cls_Supplier.Select();

            while (supplierList.Read())
            {
                cmb_SupplierID.Items.Add(supplierList[1]);
            }
        }
    }
}
