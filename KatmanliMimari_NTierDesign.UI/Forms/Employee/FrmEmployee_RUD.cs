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

namespace KatmanliMimari_NTierDesign.UI.Forms.Employee
{
    public partial class FrmEmployee_RUD : Form
    {
        public FrmEmployee_RUD()
        {
            InitializeComponent();
        }

        EmployeeRepository cls_Employee = new EmployeeRepository();
        int ListviewID = 0;

        private void FrmEmployee_RUD_Load(object sender, EventArgs e)
        {
            FillListview();
            lbl_info.Text = Common_Messages.Info;
        }

        void FillListview()
        {
            lst_EmployeeList.Items.Clear();
            SqlDataReader employeeList = cls_Employee.Select();

            while (employeeList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = employeeList[0].ToString();
                listViewItem.SubItems.Add(employeeList[2].ToString() + " " + employeeList[1].ToString());
                lst_EmployeeList.Items.Add(listViewItem);
            }
        }

        private void lst_EmployeeList_Click(object sender, EventArgs e)
        {
            ListviewID = Convert.ToInt32(lst_EmployeeList.FocusedItem.SubItems[0].Text);
            txt_EmployeeName.Text = lst_EmployeeList.FocusedItem.SubItems[1].Text;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
            else
            {
                cls_Employee.EmployeeID = ListviewID;
                cls_Employee.EmployeeName = txt_EmployeeName.Text;
                bool result = cls_Employee.Update();

                txt_EmployeeName.Text = "";
                FillListview();
                MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), result, CrudTypes.Update));
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ListviewID == 0)
            {
                MessageBox.Show(Common_Messages.Dont_Choose_From_List);
            }
            else
            {
                cls_Employee.EmployeeID = ListviewID;
                bool result = cls_Employee.Delete();

                txt_EmployeeName.Text = "";
                FillListview();
                MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), result, CrudTypes.Delete));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
