using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.BusinessLogics;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using Unity;

namespace AbstractPrintingHouseView
{
    public partial class    FormReportProductOfficeComponents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic logic;

        public FormReportProductOfficeComponents(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormReportProductOfficeComponents_Load(object sender, EventArgs e)
        {
            try
            {
                var dataSource = logic.GetProductOfficeComponent();
                ReportDataSource source = new ReportDataSource("DataSetPC", dataSource);
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reportViewer.RefreshReport();
        }

        private void buttonToPdf_Click(object sender, EventArgs e)  
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveProductComponentToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
