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
    public partial class FrmOrder_RUD : Form
    {
        public FrmOrder_RUD()
        {
            InitializeComponent();
        }
        OrderRepository cls_Order = new OrderRepository();

        private void FrmOrder_RUD_Load(object sender, EventArgs e)
        {
            Fill_Listview();
            lbl_info.Text = Common_Messages.Info;
        }

        void Fill_Listview()
        {
            lst_OrderList.Items.Clear();
            SqlDataReader orderList = cls_Order.Select();

            while (orderList.Read())
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = orderList[0].ToString();
                listViewItem.SubItems.Add(orderList[1].ToString());
                listViewItem.SubItems.Add(orderList[2].ToString());
                listViewItem.SubItems.Add(orderList[3].ToString());
                lst_OrderList.Items.Add(listViewItem);
            }
        }
    }
}
