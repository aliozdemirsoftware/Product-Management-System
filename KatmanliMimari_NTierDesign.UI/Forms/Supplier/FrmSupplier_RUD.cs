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

namespace KatmanliMimari_NTierDesign.UI.Forms.Supplier
{
    public partial class FrmSupplier_RUD : Form
    {
        SupplierRepository cls_Supplier = new SupplierRepository();
        int ListviewID = 0;

        public FrmSupplier_RUD()
        {
            InitializeComponent();
        }

        private void FrmSupplier_RUD_Load(object sender, EventArgs e)
        {
            txt_SupplierName.Enabled = false;
            Fill_Listview();
            lbl_info.Text = Common_Messages.Info;
        }

        void Fill_Listview()
        {
            lst_SupplierList.Items.Clear();
            SqlDataReader supplierList = cls_Supplier.Select();

            while (supplierList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = supplierList[0].ToString(); // 1.kolon
                listViewItem.SubItems.Add(supplierList[1].ToString()); // 2.kolon
                lst_SupplierList.Items.Add(listViewItem);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(ListviewID == 0)
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
            else
            {
                cls_Supplier.SupplierID = ListviewID;
                cls_Supplier.CompanyName = txt_SupplierName.Text;

                bool result = cls_Supplier.Update();

                Fill_Listview();
                txt_SupplierName.Text = "";
                MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), result, CrudTypes.Update));
            }
        }

        private void lst_SupplierList_Click(object sender, EventArgs e)
        {
            txt_SupplierName.Enabled = true;
            ListviewID = Convert.ToInt32(lst_SupplierList.FocusedItem.SubItems[0].Text);
            txt_SupplierName.Text = lst_SupplierList.FocusedItem.SubItems[1].Text;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
            else
            {
                cls_Supplier.SupplierID = ListviewID;

                bool result = cls_Supplier.Delete();

                Fill_Listview();
                txt_SupplierName.Text = "";
                MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), result, CrudTypes.Delete));
            }
        }
    }
}
