using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.BusinessLogics;
using Microsoft.Reporting.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;
namespace AbstractPrintingHouseView
{
    public partial class FormReportOrders : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic logic;

        public FormReportOrders(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            dataGridView.Columns.Add("DateCreate", "Дата создания");
            dataGridView.Columns.Add("ProductName", "Кондитерское изделие");
            dataGridView.Columns.Add("Sum", "Сумма");
            dataGridView.Columns[0].Width = 250;
            dataGridView.Columns[1].Width = 250;
            dataGridView.Columns[2].Width = 250;
            textBoxResult.Text = "0";
        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date > dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var dataSource = logic.GetOrders(new ReportBindingModel
                {
                    DateFrom = dateTimePickerFrom.Value,
                    DateTo = dateTimePickerTo.Value
                });
                if (dataSource != null)
                {
                    dataGridView.Rows.Clear();
                    DateTime date = new DateTime();
                    bool first = true;
                    decimal? sum = 0;
                    foreach (var order in dataSource)
                    {
                        if (first)
                        {
                            first = false;
                            dataGridView.Rows.Add(new object[] { order.DateCreate, "", "" });
                            dataGridView.Rows.Add(new object[] { "", order.PrintingProductName, order.Sum });
                            date = order.DateCreate.Date;
                        }
                        else
                        if (order.DateCreate.Date != date.Date)
                        {
                            dataGridView.Rows.Add(new object[] { "Итого:", "", sum });
                            sum = 0;
                            date = order.DateCreate.Date;
                            dataGridView.Rows.Add(new object[] { order.DateCreate, "", "" });
                            dataGridView.Rows.Add(new object[] { "", order.PrintingProductName, order.Sum });
    
                        }
                        else
                        {
                            sum += order.Sum;
                            dataGridView.Rows.Add(new object[] { "", order.PrintingProductName, order.Sum });
                        }
                    }
                    dataGridView.Rows.Add(new object[] { "Итого:", "", sum });
                    textBoxResult.Text = (dataSource.Sum(x => x.Sum)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonToExcel_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date > dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveOrdersToExcelFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                            DateFrom = dateTimePickerFrom.Value,
                            DateTo = dateTimePickerTo.Value
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

