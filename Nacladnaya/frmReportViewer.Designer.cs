namespace Nacladnaya
{
    partial class frmReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewer));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsOrderEntity = new System.Windows.Forms.BindingSource(this.components);
            this.bsDataSetEntity = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataSetEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.bsOrderEntity;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.bsDataSetEntity;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Nacladnaya.Nacladnaya.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(773, 566);
            this.reportViewer1.TabIndex = 0;
            // 
            // bsOrderEntity
            // 
            this.bsOrderEntity.DataMember = "EntityList";
            this.bsOrderEntity.DataSource = typeof(Nacladnaya.DataSetEntity);
            // 
            // bsDataSetEntity
            // 
            this.bsDataSetEntity.DataSource = typeof(Nacladnaya.DataSetEntity);
            // 
            // DataSetEntityBindingSource
            // 
            this.DataSetEntityBindingSource.DataMember = "EntityList";
            this.DataSetEntityBindingSource.DataSource = typeof(Nacladnaya.DataSetEntity);
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 566);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewer";
            this.Text = "Просмотр отчета";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDataSetEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsOrderEntity;
        private System.Windows.Forms.BindingSource bsDataSetEntity;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataSetEntityBindingSource;
    }
}