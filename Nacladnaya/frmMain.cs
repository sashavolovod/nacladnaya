using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nacladnaya
{
    
    public partial class frmMain : Form
    {
        const int ROW_COUNT_IN_REPORT = 8;
        private DateTimePicker dtpOrderDate;
        private BindingList<OrderEntity> orderList;
        public static Properties.Settings settings;

        public frmMain()
        {
            settings = new Properties.Settings();
            InitializeComponent();

            dataGridViewTextBoxColumn3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            orderList = new BindingList<OrderEntity>();
            tbDocsNumber.Text = settings.lastDocsNumber.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpOrderDate = new DateTimePicker();
            dtpOrderDate.Width = 170;
            dtpOrderDate.Value = DateTime.Today;
            tsMain.Items.Add(new ToolStripControlHost(dtpOrderDate));
            bsOrders.DataSource = orderList;
        }

        private void tsbAddOrder_Click(object sender, EventArgs e)
        {
            int c = bsOrders.Count;
            Form frmOrderAdd = new frmOrderNumber(orderList);
            frmOrderAdd.ShowDialog();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            orderList.Clear();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            int DocNumber;

            if ( int.TryParse(tbDocsNumber.Text, out DocNumber))
                settings.lastDocsNumber = ++DocNumber;

            settings.Save();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            bsOrders.EndEdit();
            dgvOrders.EndEdit();
            if (orderList.Count == 0)
            {
                MessageBox.Show("Не выбраны заказы для печати накладной", "Нет заказов для печати", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BindingList<OrderEntity> orderListForPrint = new BindingList<OrderEntity>();

            foreach(OrderEntity order in orderList)
                orderListForPrint.Add(order);

            while(orderListForPrint.Count<ROW_COUNT_IN_REPORT)
                orderListForPrint.Add(new OrderEntity());

            DataSetEntity ds = new DataSetEntity();
            ds.EntityList = orderListForPrint;
            ds.DocDate = dtpOrderDate.Value;
            ds.DocNumber = tbDocsNumber.Text;

            Form frmReport = new frmReportViewer(ds);
            frmReport.Show();
        }

        private void miClearList_Click(object sender, EventArgs e)
        {
            orderList.Clear();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для печати приемо-сдаточных накладных\nРазработчик: Воловод А.А. т. 66-16\n(c) inc.gefest.org 2013",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog(); 
        }
    }
}
