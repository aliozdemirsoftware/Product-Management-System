using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KatmanliMimari_NTierDesign.BusinessLayer;
using KatmanliMimari_NTierDesign.TypeLayer;

namespace KatmanliMimari_NTierDesign.UI.Forms.Category
{
    public partial class FrmCategoryCreate : Form
    {
        public FrmCategoryCreate()
        {
            InitializeComponent();
        }

        // Cls_Category clasına ulaşmak için new ile nesne oluşturdum
        CategoryRepository cls_category = new CategoryRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //kullanıcıdan aldığımız kategori adını property ye gönderdik
            cls_category.CategoryName = txt_CategoryName.Text;

            // save metodunu tetikledik
            bool answer = cls_category.Save();

            MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), answer, CrudTypes.Insert));
        }

        private void FrmCategoryCreate_Load(object sender, EventArgs e)
        {
            btn_Save.Visible = false;
            lbl_info.Text = Common_Messages.Info;
        }

        private void txt_CategoryName_TextChanged(object sender, EventArgs e)
        {
            // txt_CategoryName textbox ına her karakter yazıldığında buraya gelir
            if(txt_CategoryName.Text.Length > 0)
            {
                // textbox içi dolu
                // visible görünme özelliği , enabled tıklanma özelliği
                btn_Save.Visible = true;
                // btn_Save.Enabled = true;
            }
            else
            {
                // textbox içi boş
                btn_Save.Visible = false;
            }
        }

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {
            btn_Save.BackColor = Color.Orange;
            btn_Save.ForeColor = Color.White;
        }

        private void txt_CategoryName_Click(object sender, EventArgs e)
        {
            txt_CategoryName.BackColor = Color.Orange;
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.BackColor = Color.SkyBlue;
            btn_Save.ForeColor = Color.Black;

        }
    }
}
