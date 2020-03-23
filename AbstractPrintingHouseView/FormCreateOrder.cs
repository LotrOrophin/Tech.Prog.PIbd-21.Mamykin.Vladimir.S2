
using AbstractPrintingHouseBusinessLogic.BusinessLogics;
using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using AbstractPrintingHouseListImplement.Implements;
using System.Collections.Generic;

namespace AbstractPrintingHouseView
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IPrintingProductLogic logicPrint;
        private readonly MainLogic logicM;
        public FormCreateOrder(IPrintingProductLogic logicPrint, MainLogic logicM)
        {
            InitializeComponent();
            this.logicPrint = logicPrint;
            this.logicM = logicM;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<PrintingProductViewModel> list = logicPrint.Read(null);
                if (list != null)
                {
                    comboBoxPrintProduct.DisplayMember = "ProductName";
                    comboBoxPrintProduct.ValueMember = "Id";
                    comboBoxPrintProduct.DataSource = list;
                    comboBoxPrintProduct.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (comboBoxPrintProduct.SelectedValue != null &&
           !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxPrintProduct.SelectedValue);
                    PrintingProductViewModel product = logicPrint.Read(new PrintingProductBindingModel
                    {
                        Id =
                    id
                    })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * product?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ComboBoxPrintingProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxPrintProduct.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicM.CreateOrder(new CreateOrderBindingModel
                {
                    ProductId = Convert.ToInt32(comboBoxPrintProduct.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

