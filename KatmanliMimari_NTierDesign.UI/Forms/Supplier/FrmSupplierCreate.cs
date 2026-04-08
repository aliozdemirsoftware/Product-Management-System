using KatmanliMimari_NTierDesign.BusinessLayer;
using KatmanliMimari_NTierDesign.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimari_NTierDesign.UI.Forms.Supplier
{
    public partial class FrmSupplierCreate : Form
    {
        public FrmSupplierCreate()
        {
            InitializeComponent();
        }

        SupplierRepository cls_supplier = new SupplierRepository();

        private void FrmSupplierCreate_Load(object sender, EventArgs e)
        {
            btn_Save.Visible = false;
            lbl_info.Text = Common_Messages.Info;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //kullanıcıdan marka adını aldık
            //SupplierName değişkenine koyduk
            cls_supplier.CompanyName = txt_SupplierName.Text;

            // metodtan dönen sonucu answer değişkenine attım
            bool answer = cls_supplier.Save();

            txt_SupplierName.Text = "";
            MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), answer, CrudTypes.Insert));
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if(txt_SupplierName.Text.Length > 0)
            {
                btn_Save.Visible = true;
            }
            else
            {
                btn_Save.Visible = false;
            }
        }
    }
}
