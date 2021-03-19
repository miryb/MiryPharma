
namespace MiryPharma
{
    partial class AddDrugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDrugForm));
            this.DrugNameLabel = new System.Windows.Forms.Label();
            this.DrugNameTextBox = new System.Windows.Forms.TextBox();
            this.DrugQuantityTextBox = new System.Windows.Forms.TextBox();
            this.DrugQuantityLabel = new System.Windows.Forms.Label();
            this.QtyUnitsComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugExpiryLabel = new System.Windows.Forms.Label();
            this.ExpirationDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.DrugMedType = new System.Windows.Forms.Label();
            this.DrugTypeHomeopathRadioButton = new System.Windows.Forms.RadioButton();
            this.DrugTypeOtherRadioButton = new System.Windows.Forms.RadioButton();
            this.DrugActiveIngredientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.DrugMiscellanousCheckedListBox = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // DrugNameLabel
            // 
            this.DrugNameLabel.AutoSize = true;
            this.DrugNameLabel.Location = new System.Drawing.Point(13, 29);
            this.DrugNameLabel.Name = "DrugNameLabel";
            this.DrugNameLabel.Size = new System.Drawing.Size(53, 17);
            this.DrugNameLabel.TabIndex = 0;
            this.DrugNameLabel.Text = "Name: ";
            // 
            // DrugNameTextBox
            // 
            this.DrugNameTextBox.Location = new System.Drawing.Point(140, 29);
            this.DrugNameTextBox.Name = "DrugNameTextBox";
            this.DrugNameTextBox.Size = new System.Drawing.Size(339, 22);
            this.DrugNameTextBox.TabIndex = 1;
            // 
            // DrugQuantityTextBox
            // 
            this.DrugQuantityTextBox.Location = new System.Drawing.Point(140, 110);
            this.DrugQuantityTextBox.Name = "DrugQuantityTextBox";
            this.DrugQuantityTextBox.Size = new System.Drawing.Size(90, 22);
            this.DrugQuantityTextBox.TabIndex = 3;
            this.DrugQuantityTextBox.Text = "1";
            this.DrugQuantityTextBox.TextChanged += new System.EventHandler(this.DrugQuantityTextBox_TextChanged);
            // 
            // DrugQuantityLabel
            // 
            this.DrugQuantityLabel.AutoSize = true;
            this.DrugQuantityLabel.Location = new System.Drawing.Point(13, 108);
            this.DrugQuantityLabel.Name = "DrugQuantityLabel";
            this.DrugQuantityLabel.Size = new System.Drawing.Size(69, 17);
            this.DrugQuantityLabel.TabIndex = 2;
            this.DrugQuantityLabel.Text = "Quantity: ";
            // 
            // QtyUnitsComboBox1
            // 
            this.QtyUnitsComboBox1.FormattingEnabled = true;
            this.QtyUnitsComboBox1.Location = new System.Drawing.Point(271, 108);
            this.QtyUnitsComboBox1.Name = "QtyUnitsComboBox1";
            this.QtyUnitsComboBox1.Size = new System.Drawing.Size(208, 24);
            this.QtyUnitsComboBox1.TabIndex = 4;
            // 
            // DrugExpiryLabel
            // 
            this.DrugExpiryLabel.AutoSize = true;
            this.DrugExpiryLabel.Location = new System.Drawing.Point(13, 70);
            this.DrugExpiryLabel.Name = "DrugExpiryLabel";
            this.DrugExpiryLabel.Size = new System.Drawing.Size(82, 17);
            this.DrugExpiryLabel.TabIndex = 5;
            this.DrugExpiryLabel.Text = "Expiration:  ";
            // 
            // ExpirationDateTimePicker1
            // 
            this.ExpirationDateTimePicker1.Location = new System.Drawing.Point(140, 70);
            this.ExpirationDateTimePicker1.Name = "ExpirationDateTimePicker1";
            this.ExpirationDateTimePicker1.Size = new System.Drawing.Size(339, 22);
            this.ExpirationDateTimePicker1.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(140, 149);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Allopathic";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // DrugMedType
            // 
            this.DrugMedType.AutoSize = true;
            this.DrugMedType.Location = new System.Drawing.Point(13, 153);
            this.DrugMedType.Name = "DrugMedType";
            this.DrugMedType.Size = new System.Drawing.Size(71, 17);
            this.DrugMedType.TabIndex = 8;
            this.DrugMedType.Text = "Med Type";
            // 
            // DrugTypeHomeopathRadioButton
            // 
            this.DrugTypeHomeopathRadioButton.AutoSize = true;
            this.DrugTypeHomeopathRadioButton.Location = new System.Drawing.Point(271, 149);
            this.DrugTypeHomeopathRadioButton.Name = "DrugTypeHomeopathRadioButton";
            this.DrugTypeHomeopathRadioButton.Size = new System.Drawing.Size(102, 21);
            this.DrugTypeHomeopathRadioButton.TabIndex = 9;
            this.DrugTypeHomeopathRadioButton.TabStop = true;
            this.DrugTypeHomeopathRadioButton.Text = "Homeopath";
            this.DrugTypeHomeopathRadioButton.UseVisualStyleBackColor = true;
            // 
            // DrugTypeOtherRadioButton
            // 
            this.DrugTypeOtherRadioButton.AutoSize = true;
            this.DrugTypeOtherRadioButton.Location = new System.Drawing.Point(414, 149);
            this.DrugTypeOtherRadioButton.Name = "DrugTypeOtherRadioButton";
            this.DrugTypeOtherRadioButton.Size = new System.Drawing.Size(65, 21);
            this.DrugTypeOtherRadioButton.TabIndex = 10;
            this.DrugTypeOtherRadioButton.TabStop = true;
            this.DrugTypeOtherRadioButton.Text = "Other";
            this.DrugTypeOtherRadioButton.UseVisualStyleBackColor = true;
            // 
            // DrugActiveIngredientLabel
            // 
            this.DrugActiveIngredientLabel.AutoSize = true;
            this.DrugActiveIngredientLabel.Location = new System.Drawing.Point(13, 186);
            this.DrugActiveIngredientLabel.Name = "DrugActiveIngredientLabel";
            this.DrugActiveIngredientLabel.Size = new System.Drawing.Size(121, 17);
            this.DrugActiveIngredientLabel.TabIndex = 11;
            this.DrugActiveIngredientLabel.Text = "Active Ingredient: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "First time using it",
            "Allergic",
            "Antibiotic",
            "Prescription required",
            "Based on prescription"});
            this.checkedListBox1.Location = new System.Drawing.Point(140, 233);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 106);
            this.checkedListBox1.TabIndex = 13;
            // 
            // DrugMiscellanousCheckedListBox
            // 
            this.DrugMiscellanousCheckedListBox.AutoSize = true;
            this.DrugMiscellanousCheckedListBox.Location = new System.Drawing.Point(13, 233);
            this.DrugMiscellanousCheckedListBox.Name = "DrugMiscellanousCheckedListBox";
            this.DrugMiscellanousCheckedListBox.Size = new System.Drawing.Size(94, 17);
            this.DrugMiscellanousCheckedListBox.TabIndex = 14;
            this.DrugMiscellanousCheckedListBox.Text = "Miscelannous";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(414, 233);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox2.TabIndex = 15;
            // 
            // AddDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 631);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.DrugMiscellanousCheckedListBox);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrugActiveIngredientLabel);
            this.Controls.Add(this.DrugTypeOtherRadioButton);
            this.Controls.Add(this.DrugTypeHomeopathRadioButton);
            this.Controls.Add(this.DrugMedType);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ExpirationDateTimePicker1);
            this.Controls.Add(this.DrugExpiryLabel);
            this.Controls.Add(this.QtyUnitsComboBox1);
            this.Controls.Add(this.DrugQuantityTextBox);
            this.Controls.Add(this.DrugQuantityLabel);
            this.Controls.Add(this.DrugNameTextBox);
            this.Controls.Add(this.DrugNameLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDrugForm";
            this.Text = "AddDrugForm";
            this.Load += new System.EventHandler(this.AddDrugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DrugNameLabel;
        private System.Windows.Forms.TextBox DrugNameTextBox;
        private System.Windows.Forms.TextBox DrugQuantityTextBox;
        private System.Windows.Forms.Label DrugQuantityLabel;
        private System.Windows.Forms.ComboBox QtyUnitsComboBox1;
        private System.Windows.Forms.Label DrugExpiryLabel;
        private System.Windows.Forms.DateTimePicker ExpirationDateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label DrugMedType;
        private System.Windows.Forms.RadioButton DrugTypeHomeopathRadioButton;
        private System.Windows.Forms.RadioButton DrugTypeOtherRadioButton;
        private System.Windows.Forms.Label DrugActiveIngredientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label DrugMiscellanousCheckedListBox;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}