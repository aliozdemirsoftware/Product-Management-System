using KatmanliMimari_NTierDesign.UI.Forms.Category;
using KatmanliMimari_NTierDesign.UI.Forms.Employee;
using KatmanliMimari_NTierDesign.UI.Forms.Order;
using KatmanliMimari_NTierDesign.UI.Forms.Product;
using KatmanliMimari_NTierDesign.UI.Forms.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimari_NTierDesign.UI.Forms
{
    public partial class FrmMenus : Form
    {
        public FrmMenus()
        {
            InitializeComponent();
        }

        private void gİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoryCreate frmCategoryCreate = new FrmCategoryCreate();
            frmCategoryCreate.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSupplierCreate frmSupplierCreate = new FrmSupplierCreate();
            frmSupplierCreate.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProductCreate frmProductCreate = new FrmProductCreate();
            frmProductCreate.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEmployeeCreate frmEmployeeCreate = new FrmEmployeeCreate();
            frmEmployeeCreate.ShowDialog();
        }

        private void gİRİŞFORMUToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmOrderCreate frmOrderCreate = new FrmOrderCreate();
            frmOrderCreate.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategory_RUD frmCategory_RUD = new FrmCategory_RUD();
            frmCategory_RUD.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEmployee_RUD frmEmployee_RUD = new FrmEmployee_RUD();
            frmEmployee_RUD.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmOrder_RUD frmOrder_RUD = new FrmOrder_RUD();
            frmOrder_RUD.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProduct_RUD frmProduct_RUD = new FrmProduct_RUD();
            frmProduct_RUD.ShowDialog();
        }

        private void lİSTELEGÜNCELLESİLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSupplier_RUD frmSupplier_RUD = new FrmSupplier_RUD();
            frmSupplier_RUD.ShowDialog();
        }

    }
}
