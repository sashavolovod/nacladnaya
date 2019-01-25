using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nacladnaya
{
    public partial class frmOrderNumber : Form
    {
        private BindingList<OrderEntity> _orderList;
        public frmOrderNumber(BindingList<OrderEntity> orderList)
        {
            _orderList = orderList;
            InitializeComponent();
            tbOrderNumber.Text = frmMain.settings.lastOrderNumber.ToString();
        }

        private void frmOrderNumber_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int id = 0;
                if (int.TryParse(tbOrderNumber.Text, out id) == false)
                {
                    return;
                }
                OrderEntity order = DAL.GetOrderById(id);
                if (order.OrderId != 0)
                {
                    _orderList.Add(order);
                }
                else
                {
                    MessageBox.Show("Заказ с номеером " + tbOrderNumber.Text + " не найден.","Внинание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmMain.settings.lastOrderNumber = id;
                frmMain.settings.Save();
            }
        }
    }
}
