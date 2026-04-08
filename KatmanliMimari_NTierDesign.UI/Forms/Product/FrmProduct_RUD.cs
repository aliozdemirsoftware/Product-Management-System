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
    public partial class FrmProduct_RUD : Form
    {
        public FrmProduct_RUD()
        {
            InitializeComponent();
        }

        ProductRepository cls_Product = new ProductRepository();
        CategoryRepository cls_Category = new CategoryRepository();
        SupplierRepository cls_Supplier = new SupplierRepository();
        int ListviewID = 0;

        private void FrmProduct_RUD_Load(object sender, EventArgs e)
        {
            Fill_Listview("load");
            Fill_Sort_Combobox();
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

        void Fill_Sort_Combobox()
        {
            cmb_Sort.Items.Add("Ada göre A-Z");
            cmb_Sort.Items.Add("Ada göre Z-A");
            cmb_Sort.Items.Add("Fiyata göre A-Z");
            cmb_Sort.Items.Add("Fiyata göre Z-A");
            cmb_Sort.Items.Add("Stoğa göre A-Z");
            cmb_Sort.Items.Add("Stoğa göre Z-A");
        }

        void Fill_Listview(string Text)
        {
            lst_ProductList.Items.Clear();
            SqlDataReader productList;
            int count = 0;

            if (Text == "load")
            {
                //formun load ı
                productList = cls_Product.Select();
            }
            else if(Text == "TextChanged")
            {
                // arama - search
                productList = cls_Product.Select(txt_Search.Text);
            }
            else
            {
                // sıralama combobox ı
                productList = cls_Product.Sort(Text);
            }

            while (productList.Read())
            {   
                count ++;
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = productList[0].ToString();
                listViewItem.SubItems.Add(productList[1].ToString());
                listViewItem.SubItems.Add(productList[2].ToString());
                listViewItem.SubItems.Add(productList[3].ToString());
                listViewItem.SubItems.Add(productList[4].ToString());
                listViewItem.SubItems.Add(productList[5].ToString());
                lst_ProductList.Items.Add(listViewItem);
            }
            lbl_Count.Text = count.ToString() + " ADET ÜRÜN" ;
        }

        private void lst_ProductList_Click(object sender, EventArgs e)
        {
            ListviewID = Convert.ToInt32(lst_ProductList.FocusedItem.SubItems[0].Text);
            txt_ProductName.Text = lst_ProductList.FocusedItem.SubItems[1].Text;
            txt_UnitsInStok.Text = lst_ProductList.FocusedItem.SubItems[2].Text;
            txt_UnitPrice.Text = lst_ProductList.FocusedItem.SubItems[3].Text;
            cmb_CategoryID.Text = lst_ProductList.FocusedItem.SubItems[4].Text;
            cmb_SupplierID.Text = lst_ProductList.FocusedItem.SubItems[5].Text;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
            else
            {
                cls_Product.ProductID = ListviewID;
                cls_Product.ProductName = txt_ProductName.Text;
                cls_Product.UnitsInStock = Convert.ToInt32(txt_UnitsInStok.Text);
                cls_Product.UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text);
                cls_Product.CategoryID = cls_Category.FindID(cmb_CategoryID.SelectedItem.ToString());
                cls_Product.SupplierID = cls_Supplier.FindID(cmb_SupplierID.SelectedItem.ToString());

                bool result = cls_Product.Update();

                Clear();
                Fill_Listview("load");
                MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), result, CrudTypes.Update));

            }
        }

        void Clear()
        {
            txt_ProductName.Text = txt_UnitPrice.Text = txt_UnitsInStok.Text = "";
            cmb_CategoryID.SelectedIndex = cmb_SupplierID.SelectedIndex = -1;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
            else
            {
                cls_Product.ProductID = ListviewID;

                bool result = cls_Product.Delete();

                Clear();
                Fill_Listview("load");
                MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), result, CrudTypes.Delete));
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            Fill_Listview("TextChanged");
        }

        private void cmb_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Sort.Text == "Ada göre A-Z")
            {
                Fill_Listview("ProductName");
            }
            else if(cmb_Sort.Text == "Ada göre Z-A")
            {
                Fill_Listview("ProductName desc");
            }
            else if (cmb_Sort.Text == "Fiyata göre A-Z")
            {
                Fill_Listview("UnitPrice");
            }
            else if (cmb_Sort.Text == "Fiyata göre Z-A")
            {
                Fill_Listview("UnitPrice desc");
            }
            else if (cmb_Sort.Text == "Stoğa göre A-Z")
            {
                Fill_Listview("UnitsInStock");
            }
            else if(cmb_Sort.Text == "Stoğa göre Z-A")
            {
                Fill_Listview("UnitsInStock desc");
            }
            else
            {
                Fill_Listview("ProductID");
            }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            if(ListviewID > 0)
            {
                FrmProductDetails frmProductDetails = new FrmProductDetails(ListviewID);
                frmProductDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
        }
    }
}
