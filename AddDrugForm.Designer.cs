
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
            this.DrugActiveIngredientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SymptomsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SymptomsLabel = new System.Windows.Forms.Label();
            this.DrugMedType = new System.Windows.Forms.Label();
            this.MedTypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugAgeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugAgeLabel = new System.Windows.Forms.Label();
            this.DrugScopeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugScopeLabel = new System.Windows.Forms.Label();
            this.DrugTakingComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugTakingLabel = new System.Windows.Forms.Label();
            this.DrugFormatComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugFormatLabel = new System.Windows.Forms.Label();
            this.MiscellanousGroupBox1 = new System.Windows.Forms.GroupBox();
            this.PrescriptionAvailableCheckBox4 = new System.Windows.Forms.CheckBox();
            this.RequiresPrescriptionCheckBox3 = new System.Windows.Forms.CheckBox();
            this.AllergicCheckBox2 = new System.Windows.Forms.CheckBox();
            this.AntibioticCheckBox1 = new System.Windows.Forms.CheckBox();
            this.FirstTimeUseCheckBox1 = new System.Windows.Forms.CheckBox();
            this.AddDrugButton = new System.Windows.Forms.Button();
            this.MiscellanousGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrugNameLabel
            // 
            this.DrugNameLabel.AutoSize = true;
            this.DrugNameLabel.Location = new System.Drawing.Point(22, 69);
            this.DrugNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugNameLabel.Name = "DrugNameLabel";
            this.DrugNameLabel.Size = new System.Drawing.Size(63, 20);
            this.DrugNameLabel.TabIndex = 0;
            this.DrugNameLabel.Text = "Name: ";
            // 
            // DrugNameTextBox
            // 
            this.DrugNameTextBox.Location = new System.Drawing.Point(181, 69);
            this.DrugNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrugNameTextBox.Name = "DrugNameTextBox";
            this.DrugNameTextBox.Size = new System.Drawing.Size(423, 27);
            this.DrugNameTextBox.TabIndex = 1;
            // 
            // DrugQuantityTextBox
            // 
            this.DrugQuantityTextBox.Location = new System.Drawing.Point(181, 135);
            this.DrugQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrugQuantityTextBox.Name = "DrugQuantityTextBox";
            this.DrugQuantityTextBox.Size = new System.Drawing.Size(112, 27);
            this.DrugQuantityTextBox.TabIndex = 3;
            this.DrugQuantityTextBox.Text = "1";
            this.DrugQuantityTextBox.TextChanged += new System.EventHandler(this.DrugQuantityTextBox_TextChanged);
            // 
            // DrugQuantityLabel
            // 
            this.DrugQuantityLabel.AutoSize = true;
            this.DrugQuantityLabel.Location = new System.Drawing.Point(22, 138);
            this.DrugQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugQuantityLabel.Name = "DrugQuantityLabel";
            this.DrugQuantityLabel.Size = new System.Drawing.Size(81, 20);
            this.DrugQuantityLabel.TabIndex = 2;
            this.DrugQuantityLabel.Text = "Quantity: ";
            // 
            // QtyUnitsComboBox1
            // 
            this.QtyUnitsComboBox1.FormattingEnabled = true;
            this.QtyUnitsComboBox1.Location = new System.Drawing.Point(345, 134);
            this.QtyUnitsComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QtyUnitsComboBox1.Name = "QtyUnitsComboBox1";
            this.QtyUnitsComboBox1.Size = new System.Drawing.Size(259, 28);
            this.QtyUnitsComboBox1.TabIndex = 4;
            // 
            // DrugExpiryLabel
            // 
            this.DrugExpiryLabel.AutoSize = true;
            this.DrugExpiryLabel.Location = new System.Drawing.Point(22, 103);
            this.DrugExpiryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugExpiryLabel.Name = "DrugExpiryLabel";
            this.DrugExpiryLabel.Size = new System.Drawing.Size(98, 20);
            this.DrugExpiryLabel.TabIndex = 5;
            this.DrugExpiryLabel.Text = "Expiration:  ";
            // 
            // ExpirationDateTimePicker1
            // 
            this.ExpirationDateTimePicker1.Location = new System.Drawing.Point(181, 103);
            this.ExpirationDateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExpirationDateTimePicker1.Name = "ExpirationDateTimePicker1";
            this.ExpirationDateTimePicker1.Size = new System.Drawing.Size(423, 27);
            this.ExpirationDateTimePicker1.TabIndex = 6;
            // 
            // DrugActiveIngredientLabel
            // 
            this.DrugActiveIngredientLabel.AutoSize = true;
            this.DrugActiveIngredientLabel.Location = new System.Drawing.Point(22, 177);
            this.DrugActiveIngredientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugActiveIngredientLabel.Name = "DrugActiveIngredientLabel";
            this.DrugActiveIngredientLabel.Size = new System.Drawing.Size(143, 20);
            this.DrugActiveIngredientLabel.TabIndex = 11;
            this.DrugActiveIngredientLabel.Text = "Active Ingredient: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 174);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 27);
            this.textBox1.TabIndex = 12;
            // 
            // SymptomsCheckedListBox
            // 
            this.SymptomsCheckedListBox.FormattingEnabled = true;
            this.SymptomsCheckedListBox.Location = new System.Drawing.Point(634, 91);
            this.SymptomsCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SymptomsCheckedListBox.Name = "SymptomsCheckedListBox";
            this.SymptomsCheckedListBox.Size = new System.Drawing.Size(307, 620);
            this.SymptomsCheckedListBox.TabIndex = 15;
            // 
            // SymptomsLabel
            // 
            this.SymptomsLabel.AutoSize = true;
            this.SymptomsLabel.Location = new System.Drawing.Point(630, 69);
            this.SymptomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SymptomsLabel.Name = "SymptomsLabel";
            this.SymptomsLabel.Size = new System.Drawing.Size(88, 20);
            this.SymptomsLabel.TabIndex = 16;
            this.SymptomsLabel.Text = "Symptoms";
            // 
            // DrugMedType
            // 
            this.DrugMedType.AutoSize = true;
            this.DrugMedType.Location = new System.Drawing.Point(22, 213);
            this.DrugMedType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugMedType.Name = "DrugMedType";
            this.DrugMedType.Size = new System.Drawing.Size(117, 20);
            this.DrugMedType.TabIndex = 8;
            this.DrugMedType.Text = "Medicine Type";
            // 
            // MedTypeComboBox1
            // 
            this.MedTypeComboBox1.FormattingEnabled = true;
            this.MedTypeComboBox1.Location = new System.Drawing.Point(181, 210);
            this.MedTypeComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MedTypeComboBox1.Name = "MedTypeComboBox1";
            this.MedTypeComboBox1.Size = new System.Drawing.Size(423, 28);
            this.MedTypeComboBox1.TabIndex = 18;
            // 
            // DrugAgeComboBox1
            // 
            this.DrugAgeComboBox1.FormattingEnabled = true;
            this.DrugAgeComboBox1.Location = new System.Drawing.Point(181, 246);
            this.DrugAgeComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrugAgeComboBox1.Name = "DrugAgeComboBox1";
            this.DrugAgeComboBox1.Size = new System.Drawing.Size(423, 28);
            this.DrugAgeComboBox1.TabIndex = 20;
            // 
            // DrugAgeLabel
            // 
            this.DrugAgeLabel.AutoSize = true;
            this.DrugAgeLabel.Location = new System.Drawing.Point(22, 249);
            this.DrugAgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugAgeLabel.Name = "DrugAgeLabel";
            this.DrugAgeLabel.Size = new System.Drawing.Size(110, 20);
            this.DrugAgeLabel.TabIndex = 19;
            this.DrugAgeLabel.Text = "Age Category";
            // 
            // DrugScopeComboBox1
            // 
            this.DrugScopeComboBox1.FormattingEnabled = true;
            this.DrugScopeComboBox1.Location = new System.Drawing.Point(181, 286);
            this.DrugScopeComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrugScopeComboBox1.Name = "DrugScopeComboBox1";
            this.DrugScopeComboBox1.Size = new System.Drawing.Size(423, 28);
            this.DrugScopeComboBox1.TabIndex = 22;
            // 
            // DrugScopeLabel
            // 
            this.DrugScopeLabel.AutoSize = true;
            this.DrugScopeLabel.Location = new System.Drawing.Point(22, 289);
            this.DrugScopeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugScopeLabel.Name = "DrugScopeLabel";
            this.DrugScopeLabel.Size = new System.Drawing.Size(128, 20);
            this.DrugScopeLabel.TabIndex = 21;
            this.DrugScopeLabel.Text = "Medicine Scope";
            // 
            // DrugTakingComboBox1
            // 
            this.DrugTakingComboBox1.FormattingEnabled = true;
            this.DrugTakingComboBox1.Location = new System.Drawing.Point(181, 331);
            this.DrugTakingComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrugTakingComboBox1.Name = "DrugTakingComboBox1";
            this.DrugTakingComboBox1.Size = new System.Drawing.Size(423, 28);
            this.DrugTakingComboBox1.TabIndex = 24;
            // 
            // DrugTakingLabel
            // 
            this.DrugTakingLabel.AutoSize = true;
            this.DrugTakingLabel.Location = new System.Drawing.Point(22, 334);
            this.DrugTakingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugTakingLabel.Name = "DrugTakingLabel";
            this.DrugTakingLabel.Size = new System.Drawing.Size(121, 20);
            this.DrugTakingLabel.TabIndex = 23;
            this.DrugTakingLabel.Text = "How to take it?";
            // 
            // DrugFormatComboBox1
            // 
            this.DrugFormatComboBox1.FormattingEnabled = true;
            this.DrugFormatComboBox1.Location = new System.Drawing.Point(181, 378);
            this.DrugFormatComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrugFormatComboBox1.Name = "DrugFormatComboBox1";
            this.DrugFormatComboBox1.Size = new System.Drawing.Size(423, 28);
            this.DrugFormatComboBox1.TabIndex = 26;
            // 
            // DrugFormatLabel
            // 
            this.DrugFormatLabel.AutoSize = true;
            this.DrugFormatLabel.Location = new System.Drawing.Point(22, 378);
            this.DrugFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugFormatLabel.Name = "DrugFormatLabel";
            this.DrugFormatLabel.Size = new System.Drawing.Size(147, 20);
            this.DrugFormatLabel.TabIndex = 25;
            this.DrugFormatLabel.Text = "Presentation Form";
            // 
            // MiscellanousGroupBox1
            // 
            this.MiscellanousGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.MiscellanousGroupBox1.BackgroundImage = global::MiryPharma.Properties.Resources.green_wallpapers_14__1_;
            this.MiscellanousGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiscellanousGroupBox1.Controls.Add(this.PrescriptionAvailableCheckBox4);
            this.MiscellanousGroupBox1.Controls.Add(this.RequiresPrescriptionCheckBox3);
            this.MiscellanousGroupBox1.Controls.Add(this.AllergicCheckBox2);
            this.MiscellanousGroupBox1.Controls.Add(this.AntibioticCheckBox1);
            this.MiscellanousGroupBox1.Controls.Add(this.FirstTimeUseCheckBox1);
            this.MiscellanousGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscellanousGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.MiscellanousGroupBox1.ForeColor = System.Drawing.Color.White;
            this.MiscellanousGroupBox1.Location = new System.Drawing.Point(26, 426);
            this.MiscellanousGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.MiscellanousGroupBox1.Name = "MiscellanousGroupBox1";
            this.MiscellanousGroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.MiscellanousGroupBox1.Size = new System.Drawing.Size(578, 276);
            this.MiscellanousGroupBox1.TabIndex = 27;
            this.MiscellanousGroupBox1.TabStop = false;
            this.MiscellanousGroupBox1.Text = "MISCELLANOUS";
            // 
            // PrescriptionAvailableCheckBox4
            // 
            this.PrescriptionAvailableCheckBox4.AutoSize = true;
            this.PrescriptionAvailableCheckBox4.Location = new System.Drawing.Point(34, 238);
            this.PrescriptionAvailableCheckBox4.Margin = new System.Windows.Forms.Padding(4);
            this.PrescriptionAvailableCheckBox4.Name = "PrescriptionAvailableCheckBox4";
            this.PrescriptionAvailableCheckBox4.Size = new System.Drawing.Size(315, 28);
            this.PrescriptionAvailableCheckBox4.TabIndex = 21;
            this.PrescriptionAvailableCheckBox4.Text = "Based on prescription from doctor";
            this.PrescriptionAvailableCheckBox4.UseVisualStyleBackColor = true;
            // 
            // RequiresPrescriptionCheckBox3
            // 
            this.RequiresPrescriptionCheckBox3.AutoSize = true;
            this.RequiresPrescriptionCheckBox3.Location = new System.Drawing.Point(34, 184);
            this.RequiresPrescriptionCheckBox3.Margin = new System.Windows.Forms.Padding(4);
            this.RequiresPrescriptionCheckBox3.Name = "RequiresPrescriptionCheckBox3";
            this.RequiresPrescriptionCheckBox3.Size = new System.Drawing.Size(211, 28);
            this.RequiresPrescriptionCheckBox3.TabIndex = 20;
            this.RequiresPrescriptionCheckBox3.Text = "Requires prescription";
            this.RequiresPrescriptionCheckBox3.UseVisualStyleBackColor = true;
            // 
            // AllergicCheckBox2
            // 
            this.AllergicCheckBox2.AutoSize = true;
            this.AllergicCheckBox2.Location = new System.Drawing.Point(34, 134);
            this.AllergicCheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.AllergicCheckBox2.Name = "AllergicCheckBox2";
            this.AllergicCheckBox2.Size = new System.Drawing.Size(95, 28);
            this.AllergicCheckBox2.TabIndex = 19;
            this.AllergicCheckBox2.Text = "Allergic";
            this.AllergicCheckBox2.UseVisualStyleBackColor = true;
            // 
            // AntibioticCheckBox1
            // 
            this.AntibioticCheckBox1.AutoSize = true;
            this.AntibioticCheckBox1.Location = new System.Drawing.Point(34, 82);
            this.AntibioticCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.AntibioticCheckBox1.Name = "AntibioticCheckBox1";
            this.AntibioticCheckBox1.Size = new System.Drawing.Size(108, 28);
            this.AntibioticCheckBox1.TabIndex = 18;
            this.AntibioticCheckBox1.Text = "Antibiotic";
            this.AntibioticCheckBox1.UseVisualStyleBackColor = true;
            // 
            // FirstTimeUseCheckBox1
            // 
            this.FirstTimeUseCheckBox1.AutoSize = true;
            this.FirstTimeUseCheckBox1.Location = new System.Drawing.Point(34, 34);
            this.FirstTimeUseCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.FirstTimeUseCheckBox1.Name = "FirstTimeUseCheckBox1";
            this.FirstTimeUseCheckBox1.Size = new System.Drawing.Size(171, 28);
            this.FirstTimeUseCheckBox1.TabIndex = 17;
            this.FirstTimeUseCheckBox1.Text = "First time using it";
            this.FirstTimeUseCheckBox1.UseVisualStyleBackColor = true;
            this.FirstTimeUseCheckBox1.CheckedChanged += new System.EventHandler(this.FirstTimeUseCheckBox1_CheckedChanged);
            // 
            // AddDrugButton
            // 
            this.AddDrugButton.BackColor = System.Drawing.Color.Transparent;
            this.AddDrugButton.BackgroundImage = global::MiryPharma.Properties.Resources.green_wallpapers_14__1_;
            this.AddDrugButton.ForeColor = System.Drawing.Color.White;
            this.AddDrugButton.Location = new System.Drawing.Point(948, 635);
            this.AddDrugButton.Name = "AddDrugButton";
            this.AddDrugButton.Size = new System.Drawing.Size(103, 76);
            this.AddDrugButton.TabIndex = 28;
            this.AddDrugButton.Text = "Add";
            this.AddDrugButton.UseVisualStyleBackColor = false;
            // 
            // AddDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 729);
            this.Controls.Add(this.AddDrugButton);
            this.Controls.Add(this.MiscellanousGroupBox1);
            this.Controls.Add(this.DrugFormatComboBox1);
            this.Controls.Add(this.DrugFormatLabel);
            this.Controls.Add(this.DrugTakingComboBox1);
            this.Controls.Add(this.DrugTakingLabel);
            this.Controls.Add(this.DrugScopeComboBox1);
            this.Controls.Add(this.DrugScopeLabel);
            this.Controls.Add(this.DrugAgeComboBox1);
            this.Controls.Add(this.DrugAgeLabel);
            this.Controls.Add(this.MedTypeComboBox1);
            this.Controls.Add(this.SymptomsLabel);
            this.Controls.Add(this.SymptomsCheckedListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrugActiveIngredientLabel);
            this.Controls.Add(this.DrugMedType);
            this.Controls.Add(this.ExpirationDateTimePicker1);
            this.Controls.Add(this.DrugExpiryLabel);
            this.Controls.Add(this.QtyUnitsComboBox1);
            this.Controls.Add(this.DrugQuantityTextBox);
            this.Controls.Add(this.DrugQuantityLabel);
            this.Controls.Add(this.DrugNameTextBox);
            this.Controls.Add(this.DrugNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add your medicine";
            this.Load += new System.EventHandler(this.AddDrugForm_Load);
            this.MiscellanousGroupBox1.ResumeLayout(false);
            this.MiscellanousGroupBox1.PerformLayout();
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
        private System.Windows.Forms.Label DrugActiveIngredientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox SymptomsCheckedListBox;
        private System.Windows.Forms.Label SymptomsLabel;
        private System.Windows.Forms.CheckBox FirstTimeUseCheckBox1;
        private System.Windows.Forms.Label DrugMedType;
        private System.Windows.Forms.ComboBox MedTypeComboBox1;
        private System.Windows.Forms.ComboBox DrugAgeComboBox1;
        private System.Windows.Forms.Label DrugAgeLabel;
        private System.Windows.Forms.ComboBox DrugScopeComboBox1;
        private System.Windows.Forms.Label DrugScopeLabel;
        private System.Windows.Forms.ComboBox DrugTakingComboBox1;
        private System.Windows.Forms.Label DrugTakingLabel;
        private System.Windows.Forms.ComboBox DrugFormatComboBox1;
        private System.Windows.Forms.Label DrugFormatLabel;
        private System.Windows.Forms.GroupBox MiscellanousGroupBox1;
        private System.Windows.Forms.CheckBox PrescriptionAvailableCheckBox4;
        private System.Windows.Forms.CheckBox RequiresPrescriptionCheckBox3;
        private System.Windows.Forms.CheckBox AllergicCheckBox2;
        private System.Windows.Forms.CheckBox AntibioticCheckBox1;
        private System.Windows.Forms.Button AddDrugButton;
    }
}