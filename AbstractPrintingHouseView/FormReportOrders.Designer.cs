namespace AbstractPrintingHouseView
{
    partial class FormReportOrders
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
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonToExcel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxTextResult = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(283, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerTo.TabIndex = 0;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(58, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(699, 12);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(227, 23);
            this.buttonMake.TabIndex = 2;
            this.buttonMake.Text = "Сформировать";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonForm_Click);
            // 
            // buttonToExcel
            // 
            this.buttonToExcel.Location = new System.Drawing.Point(1131, 13);
            this.buttonToExcel.Name = "buttonToExcel";
            this.buttonToExcel.Size = new System.Drawing.Size(227, 23);
            this.buttonToExcel.TabIndex = 3;
            this.buttonToExcel.Text = "В Excel";
            this.buttonToExcel.UseVisualStyleBackColor = true;
            this.buttonToExcel.Click += new System.EventHandler(this.buttonToExcel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1363, 426);
            this.dataGridView.TabIndex = 4;
            // 
            // textBoxTextResult
            // 
            this.textBoxTextResult.Location = new System.Drawing.Point(1099, 528);
            this.textBoxTextResult.Name = "textBoxTextResult";
            this.textBoxTextResult.Size = new System.Drawing.Size(41, 20);
            this.textBoxTextResult.TabIndex = 5;
            this.textBoxTextResult.Text = "Итого:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(1158, 528);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(142, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 617);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxTextResult);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonToExcel);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Name = "FormReportOrders";
            this.Text = "FormClientOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Button buttonToExcel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxTextResult;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}