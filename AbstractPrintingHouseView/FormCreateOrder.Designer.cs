namespace AbstractPrintingHouseView
{
    partial class FormCreateOrder
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
            this.comboBoxPrintProduct = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.labelEzdel = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSumm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPrintProduct
            // 
            this.comboBoxPrintProduct.FormattingEnabled = true;
            this.comboBoxPrintProduct.Location = new System.Drawing.Point(100, 12);
            this.comboBoxPrintProduct.Name = "comboBoxPrintProduct";
            this.comboBoxPrintProduct.Size = new System.Drawing.Size(338, 21);
            this.comboBoxPrintProduct.TabIndex = 0;
            this.comboBoxPrintProduct.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrintingProduct_SelectedIndexChanged);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(100, 39);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(337, 20);
            this.textBoxCount.TabIndex = 1;
            this.textBoxCount.TextChanged += new System.EventHandler(this.TextBoxCount_TextChanged);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(101, 65);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(337, 20);
            this.textBoxSum.TabIndex = 2;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(352, 108);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(84, 20);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(262, 108);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(84, 20);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelEzdel
            // 
            this.labelEzdel.AutoSize = true;
            this.labelEzdel.Location = new System.Drawing.Point(24, 15);
            this.labelEzdel.Name = "labelEzdel";
            this.labelEzdel.Size = new System.Drawing.Size(51, 13);
            this.labelEzdel.TabIndex = 5;
            this.labelEzdel.Text = "Изделие";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(24, 42);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "Количество";
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(24, 72);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(41, 13);
            this.labelSumm.TabIndex = 7;
            this.labelSumm.Text = "Сумма";
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 141);
            this.Controls.Add(this.labelSumm);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelEzdel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxPrintProduct);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPrintProduct;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label labelEzdel;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelSumm;
    }
}