﻿using AbstractPrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AbstractPrintingHouseClientView
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            LoadList();
        }

        private void LoadList()
        {
            try
            {
                dataGridView.DataSource = APIClient.GetRequest<List<OrderViewModel>>($"api/main/getorders?clientId={Program.Client.Id}");

                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[3].Visible = false;
                dataGridView.Columns[4].Visible = false;
                dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUpdateData();

            form.ShowDialog();
        }

        private void CreateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCreateOrder();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }

        private void UpdateOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
