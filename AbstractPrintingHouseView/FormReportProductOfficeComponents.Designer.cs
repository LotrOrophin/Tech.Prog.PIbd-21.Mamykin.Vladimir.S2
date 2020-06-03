namespace AbstractPrintingHouseView
{
    partial class FormReportProductOfficeComponents
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
            this.ReportProductOfficeComponentViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonSaveToPdf = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ReportProductOfficeComponentViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportProductOfficeComponentViewModelBindingSource
            // 
            this.ReportProductOfficeComponentViewModelBindingSource.DataSource = typeof(AbstractPrintingHouseBusinessLogic.ViewModels.ReportProductOfficeComponentViewModel);
            // 
            // ButtonSaveToPdf
            // 
            this.ButtonSaveToPdf.Location = new System.Drawing.Point(670, 8);
            this.ButtonSaveToPdf.Name = "ButtonSaveToPdf";
            this.ButtonSaveToPdf.Size = new System.Drawing.Size(118, 23);
            this.ButtonSaveToPdf.TabIndex = 1;
            this.ButtonSaveToPdf.Text = "Сохранить в PDF";
            this.ButtonSaveToPdf.UseVisualStyleBackColor = true;
            this.ButtonSaveToPdf.Click += new System.EventHandler(this.buttonToPdf_Click);
            // 
            // reportViewer
            // 
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "AbstractPrintingHouseView.ReportProductComponent.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(1, 41);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 409);
            this.reportViewer.TabIndex = 2;
            // 
            // FormReportProductOfficeComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.ButtonSaveToPdf);
            this.Name = "FormReportProductOfficeComponents";
            this.Text = "FormReportProductOfficeComponents";
            this.Load += new System.EventHandler(this.FormReportProductOfficeComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportProductOfficeComponentViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSaveToPdf;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ReportProductOfficeComponentViewModelBindingSource;
    }
}