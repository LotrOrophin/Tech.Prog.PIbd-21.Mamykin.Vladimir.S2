namespace AbstractPrintingHouseView
{
    partial class FormPritntingProduct
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.officeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeComponents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonUpd = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonRef = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officeID,
            this.officeComponents,
            this.Cout});
            this.dataGridView.Location = new System.Drawing.Point(2, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(595, 380);
            this.dataGridView.TabIndex = 0;
            // 
            // officeID
            // 
            this.officeID.HeaderText = "Column1";
            this.officeID.Name = "officeID";
            this.officeID.Visible = false;
            // 
            // officeComponents
            // 
            this.officeComponents.HeaderText = "Канцелярский компонент";
            this.officeComponents.Name = "officeComponents";
            // 
            // Cout
            // 
            this.Cout.HeaderText = "Количество";
            this.Cout.Name = "Cout";
            // 
            // ButtonSave
            // 
            this.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonSave.Location = new System.Drawing.Point(626, 465);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(85, 34);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(717, 465);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(85, 34);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(411, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(75, 31);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(99, 20);
            this.textBoxPrice.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Название";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 34);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(33, 13);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Цена";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(636, 16);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(129, 38);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUpd
            // 
            this.ButtonUpd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonUpd.Location = new System.Drawing.Point(636, 60);
            this.ButtonUpd.Name = "ButtonUpd";
            this.ButtonUpd.Size = new System.Drawing.Size(129, 38);
            this.ButtonUpd.TabIndex = 7;
            this.ButtonUpd.Text = "Обновить";
            this.ButtonUpd.UseVisualStyleBackColor = true;
            this.ButtonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonDel.Location = new System.Drawing.Point(636, 104);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(129, 38);
            this.ButtonDel.TabIndex = 8;
            this.ButtonDel.Text = "Удалить";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonRef
            // 
            this.ButtonRef.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonRef.Location = new System.Drawing.Point(636, 148);
            this.ButtonRef.Name = "ButtonRef";
            this.ButtonRef.Size = new System.Drawing.Size(129, 38);
            this.ButtonRef.TabIndex = 9;
            this.ButtonRef.Text = "Удалить";
            this.ButtonRef.UseVisualStyleBackColor = true;
            this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // groupBox1
            // 
            this.groupBox.Controls.Add(this.ButtonRef);
            this.groupBox.Controls.Add(this.ButtonDel);
            this.groupBox.Controls.Add(this.ButtonUpd);
            this.groupBox.Controls.Add(this.ButtonAdd);
            this.groupBox.Controls.Add(this.dataGridView);
            this.groupBox.Location = new System.Drawing.Point(10, 57);
            this.groupBox.Name = "groupBox1";
            this.groupBox.Size = new System.Drawing.Size(792, 402);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Компоненты";
            // 
            // FormPritntingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(857, 547);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Name = "FormPritntingProduct";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonUpd;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonRef;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cout;
    }
}