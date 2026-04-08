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

namespace KatmanliMimari_NTierDesign.UI.Forms.Employee
{
    public partial class FrmEmployeeCreate : Form
    {
        public FrmEmployeeCreate()
        {
            InitializeComponent();
        }

        EmployeeRepository cls_Employee = new EmployeeRepository();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cls_Employee.EmployeeName = txt_EmployeeName.Text;

            bool answer = cls_Employee.Save();
            txt_EmployeeName.Text = "";
            MessageBox.Show(Common_Messages.CRUD_Message(Common_Messages.Find_TableName(label1.Text), answer, CrudTypes.Insert));

        }
    }
}
