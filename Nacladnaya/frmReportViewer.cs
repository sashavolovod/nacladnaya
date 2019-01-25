﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nacladnaya
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer(DataSetEntity ds)
        {
            InitializeComponent();
            bsDataSetEntity.DataSource = ds;
            bsOrderEntity.DataSource = ds.EntityList;
            if (ds.EntityList[0].OrderNumber.StartsWith("23-"))
                reportViewer1.LocalReport.ReportEmbeddedResource = "Nacladnaya.Nacladnaya-23.rdlc";
            else
                reportViewer1.LocalReport.ReportEmbeddedResource = "Nacladnaya.Nacladnaya.rdlc";
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}