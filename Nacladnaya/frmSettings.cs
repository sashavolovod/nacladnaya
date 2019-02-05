using Nacladnaya.Properties;
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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tbName.Text = Settings.Default.employee;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.employee = tbName.Text;
            Settings.Default.Save();
        }

    }
}
