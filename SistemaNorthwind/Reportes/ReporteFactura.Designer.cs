namespace SistemaNorthwind.Reportes
{
    partial class ReporteFactura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataReporte = new SistemaNorthwind.Reportes.DataReporte();
            this.Reporte_Detalle_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_FacturaTableAdapter = new SistemaNorthwind.Reportes.DataReporteTableAdapters.Reporte_FacturaTableAdapter();
            this.Reporte_Detalle_FacturaTableAdapter = new SistemaNorthwind.Reportes.DataReporteTableAdapters.Reporte_Detalle_FacturaTableAdapter();
            this.txtIdorden = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Detalle_FacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataReporte";
            reportDataSource1.Value = this.Reporte_FacturaBindingSource;
            reportDataSource2.Name = "DataSetDetalleFactura";
            reportDataSource2.Value = this.Reporte_Detalle_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaNorthwind.Reportes.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_FacturaBindingSource
            // 
            this.Reporte_FacturaBindingSource.DataMember = "Reporte_Factura";
            this.Reporte_FacturaBindingSource.DataSource = this.DataReporte;
            // 
            // DataReporte
            // 
            this.DataReporte.DataSetName = "DataReporte";
            this.DataReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_Detalle_FacturaBindingSource
            // 
            this.Reporte_Detalle_FacturaBindingSource.DataMember = "Reporte_Detalle_Factura";
            this.Reporte_Detalle_FacturaBindingSource.DataSource = this.DataReporte;
            // 
            // Reporte_FacturaTableAdapter
            // 
            this.Reporte_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Detalle_FacturaTableAdapter
            // 
            this.Reporte_Detalle_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdorden
            // 
            this.txtIdorden.Location = new System.Drawing.Point(30, 25);
            this.txtIdorden.Name = "txtIdorden";
            this.txtIdorden.Size = new System.Drawing.Size(253, 20);
            this.txtIdorden.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdorden);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura";
            this.Text = "ReporteFactura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Detalle_FacturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_FacturaBindingSource;
        private DataReporte DataReporte;
        private System.Windows.Forms.BindingSource Reporte_Detalle_FacturaBindingSource;
        private DataReporteTableAdapters.Reporte_FacturaTableAdapter Reporte_FacturaTableAdapter;
        private DataReporteTableAdapters.Reporte_Detalle_FacturaTableAdapter Reporte_Detalle_FacturaTableAdapter;
        private System.Windows.Forms.TextBox txtIdorden;
        private System.Windows.Forms.Button button1;
    }
}