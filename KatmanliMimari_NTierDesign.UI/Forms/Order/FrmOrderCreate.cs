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

namespace KatmanliMimari_NTierDesign.UI.Forms.Order
{
    public partial class FrmOrderCreate : Form
    {
        public FrmOrderCreate()
        {
            InitializeComponent();
        }
        OrderRepository cls_Order = new OrderRepository();
        EmployeeRepository cls_Employee = new EmployeeRepository();
        ProductRepository cls_Product = new ProductRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {

            cls_Order.EmployeeID = cls_Employee.FindID(cmb_EmployeeID.SelectedItem.ToString());
            cls_Order.ProductID = cls_Product.FindID(cmb_ProductID.SelectedItem.ToString());
            cls_Order.Quantity = Convert.ToInt32(nud_Quantity.Value);

            bool answer = cls_Order.Save();
            MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label2.Text), answer, CrudTypes.Insert));

        }

        public void Fill_Employee_Combobox()
        {
            cmb_EmployeeID.Items.Clear();
            SqlDataReader employeeList = cls_Employee.Select();

            while (employeeList.Read())
            {
                cmb_EmployeeID.Items.Add(employeeList[2] + " " + employeeList[1]);
            }
        }
        public void Fill_Product_Combobox()
        {
            cmb_ProductID.Items.Clear();
            SqlDataReader productList = cls_Product.Select();

            while (productList.Read())
            {
                cmb_ProductID.Items.Add(productList[1]);
            }
        }

        private void FrmOrderCreate_Load(object sender, EventArgs e)
        {
            Fill_Employee_Combobox();
            Fill_Product_Combobox();
        }
    }
}
