
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
            this.DrugQtyUnitsComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugExpiryLabel = new System.Windows.Forms.Label();
            this.ExpirationDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DrugActiveIngredientLabel = new System.Windows.Forms.Label();
            this.DrugActiveIngredientTextBox1 = new System.Windows.Forms.TextBox();
            this.SymptomsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SymptomsLabel = new System.Windows.Forms.Label();
            this.DrugMedType = new System.Windows.Forms.Label();
            this.DrugMedTypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugAgeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugAgeLabel = new System.Windows.Forms.Label();
            this.DrugScopeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugScopeLabel = new System.Windows.Forms.Label();
            this.DrugTakingComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugTakingLabel = new System.Windows.Forms.Label();
            this.DrugFormatComboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugFormatLabel = new System.Windows.Forms.Label();
            this.ErrorValidateLabel = new System.Windows.Forms.Label();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddDrugButton = new System.Windows.Forms.Button();
            this.MiscellanousGroupBox1 = new System.Windows.Forms.GroupBox();
            this.DrugPrescriptionAvailableCheckBox4 = new System.Windows.Forms.CheckBox();
            this.DrugRequiresPrescriptionCheckBox3 = new System.Windows.Forms.CheckBox();
            this.DrugAllergicCheckBox2 = new System.Windows.Forms.CheckBox();
            this.DrugAntibioticCheckBox1 = new System.Windows.Forms.CheckBox();
            this.DrugFirstTimeUseCheckBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MiscellanousGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrugNameLabel
            // 
            this.DrugNameLabel.AutoSize = true;
            this.DrugNameLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugNameLabel.Location = new System.Drawing.Point(13, 122);
            this.DrugNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugNameLabel.Name = "DrugNameLabel";
            this.DrugNameLabel.Size = new System.Drawing.Size(67, 19);
            this.DrugNameLabel.TabIndex = 0;
            this.DrugNameLabel.Text = "Name: ";
            // 
            // DrugNameTextBox
            // 
            this.DrugNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrugNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugNameTextBox.Location = new System.Drawing.Point(181, 116);
            this.DrugNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrugNameTextBox.Name = "DrugNameTextBox";
            this.DrugNameTextBox.Size = new System.Drawing.Size(423, 28);
            this.DrugNameTextBox.TabIndex = 1;
            // 
            // DrugQuantityTextBox
            // 
            this.DrugQuantityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DrugQuantityTextBox.Location = new System.Drawing.Point(181, 191);
            this.DrugQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrugQuantityTextBox.Name = "DrugQuantityTextBox";
            this.DrugQuantityTextBox.Size = new System.Drawing.Size(112, 28);
            this.DrugQuantityTextBox.TabIndex = 3;
            this.DrugQuantityTextBox.Text = "1";
            // 
            // DrugQuantityLabel
            // 
            this.DrugQuantityLabel.AutoSize = true;
            this.DrugQuantityLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugQuantityLabel.Location = new System.Drawing.Point(13, 194);
            this.DrugQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugQuantityLabel.Name = "DrugQuantityLabel";
            this.DrugQuantityLabel.Size = new System.Drawing.Size(91, 19);
            this.DrugQuantityLabel.TabIndex = 2;
            this.DrugQuantityLabel.Text = "Quantity: ";
            // 
            // DrugQtyUnitsComboBox1
            // 
            this.DrugQtyUnitsComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DrugQtyUnitsComboBox1.FormattingEnabled = true;
            this.DrugQtyUnitsComboBox1.Location = new System.Drawing.Point(345, 192);
            this.DrugQtyUnitsComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugQtyUnitsComboBox1.Name = "DrugQtyUnitsComboBox1";
            this.DrugQtyUnitsComboBox1.Size = new System.Drawing.Size(259, 27);
            this.DrugQtyUnitsComboBox1.TabIndex = 4;
            // 
            // DrugExpiryLabel
            // 
            this.DrugExpiryLabel.AutoSize = true;
            this.DrugExpiryLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugExpiryLabel.Location = new System.Drawing.Point(13, 159);
            this.DrugExpiryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugExpiryLabel.Name = "DrugExpiryLabel";
            this.DrugExpiryLabel.Size = new System.Drawing.Size(111, 19);
            this.DrugExpiryLabel.TabIndex = 5;
            this.DrugExpiryLabel.Text = "Expiration:  ";
            // 
            // ExpirationDateTimePicker1
            // 
            this.ExpirationDateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExpirationDateTimePicker1.Location = new System.Drawing.Point(181, 152);
            this.ExpirationDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.ExpirationDateTimePicker1.Name = "ExpirationDateTimePicker1";
            this.ExpirationDateTimePicker1.Size = new System.Drawing.Size(423, 28);
            this.ExpirationDateTimePicker1.TabIndex = 6;
            // 
            // DrugActiveIngredientLabel
            // 
            this.DrugActiveIngredientLabel.AutoSize = true;
            this.DrugActiveIngredientLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugActiveIngredientLabel.Location = new System.Drawing.Point(13, 237);
            this.DrugActiveIngredientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugActiveIngredientLabel.Name = "DrugActiveIngredientLabel";
            this.DrugActiveIngredientLabel.Size = new System.Drawing.Size(162, 19);
            this.DrugActiveIngredientLabel.TabIndex = 11;
            this.DrugActiveIngredientLabel.Text = "Active Ingredient: ";
            // 
            // DrugActiveIngredientTextBox1
            // 
            this.DrugActiveIngredientTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugActiveIngredientTextBox1.Location = new System.Drawing.Point(181, 227);
            this.DrugActiveIngredientTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugActiveIngredientTextBox1.Name = "DrugActiveIngredientTextBox1";
            this.DrugActiveIngredientTextBox1.Size = new System.Drawing.Size(423, 28);
            this.DrugActiveIngredientTextBox1.TabIndex = 12;
            this.DrugActiveIngredientTextBox1.Text = "-";
            // 
            // SymptomsCheckedListBox
            // 
            this.SymptomsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SymptomsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymptomsCheckedListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SymptomsCheckedListBox.FormattingEnabled = true;
            this.SymptomsCheckedListBox.Location = new System.Drawing.Point(644, 147);
            this.SymptomsCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.SymptomsCheckedListBox.Name = "SymptomsCheckedListBox";
            this.SymptomsCheckedListBox.Size = new System.Drawing.Size(302, 570);
            this.SymptomsCheckedListBox.TabIndex = 15;
            // 
            // SymptomsLabel
            // 
            this.SymptomsLabel.AutoSize = true;
            this.SymptomsLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12.2F);
            this.SymptomsLabel.Location = new System.Drawing.Point(728, 113);
            this.SymptomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SymptomsLabel.Name = "SymptomsLabel";
            this.SymptomsLabel.Size = new System.Drawing.Size(134, 27);
            this.SymptomsLabel.TabIndex = 16;
            this.SymptomsLabel.Text = "SYMPTOMS";
            // 
            // DrugMedType
            // 
            this.DrugMedType.AutoSize = true;
            this.DrugMedType.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugMedType.Location = new System.Drawing.Point(13, 271);
            this.DrugMedType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugMedType.Name = "DrugMedType";
            this.DrugMedType.Size = new System.Drawing.Size(131, 19);
            this.DrugMedType.TabIndex = 8;
            this.DrugMedType.Text = "Medicine Type";
            // 
            // DrugMedTypeComboBox1
            // 
            this.DrugMedTypeComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugMedTypeComboBox1.FormattingEnabled = true;
            this.DrugMedTypeComboBox1.Location = new System.Drawing.Point(181, 261);
            this.DrugMedTypeComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugMedTypeComboBox1.Name = "DrugMedTypeComboBox1";
            this.DrugMedTypeComboBox1.Size = new System.Drawing.Size(423, 27);
            this.DrugMedTypeComboBox1.TabIndex = 18;
            // 
            // DrugAgeComboBox1
            // 
            this.DrugAgeComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugAgeComboBox1.FormattingEnabled = true;
            this.DrugAgeComboBox1.Location = new System.Drawing.Point(181, 296);
            this.DrugAgeComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugAgeComboBox1.Name = "DrugAgeComboBox1";
            this.DrugAgeComboBox1.Size = new System.Drawing.Size(423, 27);
            this.DrugAgeComboBox1.TabIndex = 20;
            // 
            // DrugAgeLabel
            // 
            this.DrugAgeLabel.AutoSize = true;
            this.DrugAgeLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugAgeLabel.Location = new System.Drawing.Point(13, 305);
            this.DrugAgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugAgeLabel.Name = "DrugAgeLabel";
            this.DrugAgeLabel.Size = new System.Drawing.Size(119, 19);
            this.DrugAgeLabel.TabIndex = 19;
            this.DrugAgeLabel.Text = "Age Category";
            // 
            // DrugScopeComboBox1
            // 
            this.DrugScopeComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugScopeComboBox1.FormattingEnabled = true;
            this.DrugScopeComboBox1.Location = new System.Drawing.Point(181, 334);
            this.DrugScopeComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugScopeComboBox1.Name = "DrugScopeComboBox1";
            this.DrugScopeComboBox1.Size = new System.Drawing.Size(423, 27);
            this.DrugScopeComboBox1.TabIndex = 22;
            // 
            // DrugScopeLabel
            // 
            this.DrugScopeLabel.AutoSize = true;
            this.DrugScopeLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugScopeLabel.Location = new System.Drawing.Point(13, 343);
            this.DrugScopeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugScopeLabel.Name = "DrugScopeLabel";
            this.DrugScopeLabel.Size = new System.Drawing.Size(141, 19);
            this.DrugScopeLabel.TabIndex = 21;
            this.DrugScopeLabel.Text = "Medicine Scope";
            // 
            // DrugTakingComboBox1
            // 
            this.DrugTakingComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugTakingComboBox1.FormattingEnabled = true;
            this.DrugTakingComboBox1.Location = new System.Drawing.Point(181, 377);
            this.DrugTakingComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugTakingComboBox1.Name = "DrugTakingComboBox1";
            this.DrugTakingComboBox1.Size = new System.Drawing.Size(423, 27);
            this.DrugTakingComboBox1.TabIndex = 24;
            // 
            // DrugTakingLabel
            // 
            this.DrugTakingLabel.AutoSize = true;
            this.DrugTakingLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugTakingLabel.Location = new System.Drawing.Point(13, 386);
            this.DrugTakingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugTakingLabel.Name = "DrugTakingLabel";
            this.DrugTakingLabel.Size = new System.Drawing.Size(134, 19);
            this.DrugTakingLabel.TabIndex = 23;
            this.DrugTakingLabel.Text = "How to take it?";
            // 
            // DrugFormatComboBox1
            // 
            this.DrugFormatComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrugFormatComboBox1.FormattingEnabled = true;
            this.DrugFormatComboBox1.Location = new System.Drawing.Point(181, 421);
            this.DrugFormatComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugFormatComboBox1.Name = "DrugFormatComboBox1";
            this.DrugFormatComboBox1.Size = new System.Drawing.Size(423, 27);
            this.DrugFormatComboBox1.TabIndex = 26;
            // 
            // DrugFormatLabel
            // 
            this.DrugFormatLabel.AutoSize = true;
            this.DrugFormatLabel.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugFormatLabel.Location = new System.Drawing.Point(13, 428);
            this.DrugFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DrugFormatLabel.Name = "DrugFormatLabel";
            this.DrugFormatLabel.Size = new System.Drawing.Size(161, 19);
            this.DrugFormatLabel.TabIndex = 25;
            this.DrugFormatLabel.Text = "Presentation Form";
            // 
            // ErrorValidateLabel
            // 
            this.ErrorValidateLabel.AutoSize = true;
            this.ErrorValidateLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ErrorValidateLabel.Location = new System.Drawing.Point(17, 26);
            this.ErrorValidateLabel.Name = "ErrorValidateLabel";
            this.ErrorValidateLabel.Size = new System.Drawing.Size(139, 19);
            this.ErrorValidateLabel.TabIndex = 30;
            this.ErrorValidateLabel.Text = "Error Message: ";
            this.ErrorValidateLabel.Visible = false;
            // 
            // ResetButton1
            // 
            this.ResetButton1.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton1.BackgroundImage = global::MiryPharma.Properties.Resources.red_pill;
            this.ResetButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ResetButton1.FlatAppearance.BorderSize = 2;
            this.ResetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton1.Font = new System.Drawing.Font("Lucida Handwriting", 11.9F, System.Drawing.FontStyle.Bold);
            this.ResetButton1.ForeColor = System.Drawing.Color.Snow;
            this.ResetButton1.Location = new System.Drawing.Point(9, 612);
            this.ResetButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ResetButton1.Name = "ResetButton1";
            this.ResetButton1.Size = new System.Drawing.Size(160, 105);
            this.ResetButton1.TabIndex = 31;
            this.ResetButton1.Text = "RESET";
            this.ResetButton1.UseVisualStyleBackColor = false;
            this.ResetButton1.Click += new System.EventHandler(this.ResetButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MiryPharma.Properties.Resources._7d9e710c39ca635b1981cf88c8de7886;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(823, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 95);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // AddDrugButton
            // 
            this.AddDrugButton.BackColor = System.Drawing.Color.Transparent;
            this.AddDrugButton.BackgroundImage = global::MiryPharma.Properties.Resources.Pill;
            this.AddDrugButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDrugButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.AddDrugButton.FlatAppearance.BorderSize = 2;
            this.AddDrugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDrugButton.Font = new System.Drawing.Font("Lucida Handwriting", 11.9F, System.Drawing.FontStyle.Bold);
            this.AddDrugButton.ForeColor = System.Drawing.Color.Green;
            this.AddDrugButton.Location = new System.Drawing.Point(9, 467);
            this.AddDrugButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddDrugButton.Name = "AddDrugButton";
            this.AddDrugButton.Size = new System.Drawing.Size(160, 105);
            this.AddDrugButton.TabIndex = 28;
            this.AddDrugButton.Text = " ADD";
            this.AddDrugButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDrugButton.UseVisualStyleBackColor = false;
            this.AddDrugButton.Click += new System.EventHandler(this.AddDrugButton_Click);
            // 
            // MiscellanousGroupBox1
            // 
            this.MiscellanousGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.MiscellanousGroupBox1.BackgroundImage = global::MiryPharma.Properties.Resources.green_wallpapers_14__1_;
            this.MiscellanousGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiscellanousGroupBox1.Controls.Add(this.DrugPrescriptionAvailableCheckBox4);
            this.MiscellanousGroupBox1.Controls.Add(this.DrugRequiresPrescriptionCheckBox3);
            this.MiscellanousGroupBox1.Controls.Add(this.DrugAllergicCheckBox2);
            this.MiscellanousGroupBox1.Controls.Add(this.DrugAntibioticCheckBox1);
            this.MiscellanousGroupBox1.Controls.Add(this.DrugFirstTimeUseCheckBox1);
            this.MiscellanousGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscellanousGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.MiscellanousGroupBox1.ForeColor = System.Drawing.Color.White;
            this.MiscellanousGroupBox1.Location = new System.Drawing.Point(181, 467);
            this.MiscellanousGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.MiscellanousGroupBox1.Name = "MiscellanousGroupBox1";
            this.MiscellanousGroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.MiscellanousGroupBox1.Size = new System.Drawing.Size(423, 250);
            this.MiscellanousGroupBox1.TabIndex = 27;
            this.MiscellanousGroupBox1.TabStop = false;
            this.MiscellanousGroupBox1.Text = "MISCELLANOUS";
            // 
            // DrugPrescriptionAvailableCheckBox4
            // 
            this.DrugPrescriptionAvailableCheckBox4.AutoSize = true;
            this.DrugPrescriptionAvailableCheckBox4.Location = new System.Drawing.Point(20, 185);
            this.DrugPrescriptionAvailableCheckBox4.Margin = new System.Windows.Forms.Padding(4);
            this.DrugPrescriptionAvailableCheckBox4.Name = "DrugPrescriptionAvailableCheckBox4";
            this.DrugPrescriptionAvailableCheckBox4.Size = new System.Drawing.Size(315, 28);
            this.DrugPrescriptionAvailableCheckBox4.TabIndex = 21;
            this.DrugPrescriptionAvailableCheckBox4.Text = "Based on prescription from doctor";
            this.DrugPrescriptionAvailableCheckBox4.UseVisualStyleBackColor = true;
            // 
            // DrugRequiresPrescriptionCheckBox3
            // 
            this.DrugRequiresPrescriptionCheckBox3.AutoSize = true;
            this.DrugRequiresPrescriptionCheckBox3.Location = new System.Drawing.Point(20, 149);
            this.DrugRequiresPrescriptionCheckBox3.Margin = new System.Windows.Forms.Padding(4);
            this.DrugRequiresPrescriptionCheckBox3.Name = "DrugRequiresPrescriptionCheckBox3";
            this.DrugRequiresPrescriptionCheckBox3.Size = new System.Drawing.Size(211, 28);
            this.DrugRequiresPrescriptionCheckBox3.TabIndex = 20;
            this.DrugRequiresPrescriptionCheckBox3.Text = "Requires prescription";
            this.DrugRequiresPrescriptionCheckBox3.UseVisualStyleBackColor = true;
            // 
            // DrugAllergicCheckBox2
            // 
            this.DrugAllergicCheckBox2.AutoSize = true;
            this.DrugAllergicCheckBox2.Location = new System.Drawing.Point(20, 113);
            this.DrugAllergicCheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DrugAllergicCheckBox2.Name = "DrugAllergicCheckBox2";
            this.DrugAllergicCheckBox2.Size = new System.Drawing.Size(124, 28);
            this.DrugAllergicCheckBox2.TabIndex = 19;
            this.DrugAllergicCheckBox2.Text = "I\'m Allergic";
            this.DrugAllergicCheckBox2.UseVisualStyleBackColor = true;
            // 
            // DrugAntibioticCheckBox1
            // 
            this.DrugAntibioticCheckBox1.AutoSize = true;
            this.DrugAntibioticCheckBox1.Location = new System.Drawing.Point(20, 77);
            this.DrugAntibioticCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugAntibioticCheckBox1.Name = "DrugAntibioticCheckBox1";
            this.DrugAntibioticCheckBox1.Size = new System.Drawing.Size(126, 28);
            this.DrugAntibioticCheckBox1.TabIndex = 18;
            this.DrugAntibioticCheckBox1.Text = "Is Antibiotic";
            this.DrugAntibioticCheckBox1.UseVisualStyleBackColor = true;
            // 
            // DrugFirstTimeUseCheckBox1
            // 
            this.DrugFirstTimeUseCheckBox1.AutoSize = true;
            this.DrugFirstTimeUseCheckBox1.Location = new System.Drawing.Point(20, 41);
            this.DrugFirstTimeUseCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DrugFirstTimeUseCheckBox1.Name = "DrugFirstTimeUseCheckBox1";
            this.DrugFirstTimeUseCheckBox1.Size = new System.Drawing.Size(171, 28);
            this.DrugFirstTimeUseCheckBox1.TabIndex = 17;
            this.DrugFirstTimeUseCheckBox1.Text = "First time using it";
            this.DrugFirstTimeUseCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AddDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(966, 759);
            this.Controls.Add(this.ResetButton1);
            this.Controls.Add(this.ErrorValidateLabel);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.DrugMedTypeComboBox1);
            this.Controls.Add(this.SymptomsLabel);
            this.Controls.Add(this.SymptomsCheckedListBox);
            this.Controls.Add(this.DrugActiveIngredientTextBox1);
            this.Controls.Add(this.DrugActiveIngredientLabel);
            this.Controls.Add(this.DrugMedType);
            this.Controls.Add(this.ExpirationDateTimePicker1);
            this.Controls.Add(this.DrugExpiryLabel);
            this.Controls.Add(this.DrugQtyUnitsComboBox1);
            this.Controls.Add(this.DrugQuantityTextBox);
            this.Controls.Add(this.DrugQuantityLabel);
            this.Controls.Add(this.DrugNameTextBox);
            this.Controls.Add(this.DrugNameLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add your medicine";
            this.Load += new System.EventHandler(this.AddDrugForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox DrugQtyUnitsComboBox1;
        private System.Windows.Forms.Label DrugExpiryLabel;
        private System.Windows.Forms.DateTimePicker ExpirationDateTimePicker1;
        private System.Windows.Forms.Label DrugActiveIngredientLabel;
        private System.Windows.Forms.TextBox DrugActiveIngredientTextBox1;
        private System.Windows.Forms.CheckedListBox SymptomsCheckedListBox;
        private System.Windows.Forms.Label SymptomsLabel;
        private System.Windows.Forms.CheckBox DrugFirstTimeUseCheckBox1;
        private System.Windows.Forms.Label DrugMedType;
        private System.Windows.Forms.ComboBox DrugMedTypeComboBox1;
        private System.Windows.Forms.ComboBox DrugAgeComboBox1;
        private System.Windows.Forms.Label DrugAgeLabel;
        private System.Windows.Forms.ComboBox DrugScopeComboBox1;
        private System.Windows.Forms.Label DrugScopeLabel;
        private System.Windows.Forms.ComboBox DrugTakingComboBox1;
        private System.Windows.Forms.Label DrugTakingLabel;
        private System.Windows.Forms.ComboBox DrugFormatComboBox1;
        private System.Windows.Forms.Label DrugFormatLabel;
        private System.Windows.Forms.GroupBox MiscellanousGroupBox1;
        private System.Windows.Forms.CheckBox DrugPrescriptionAvailableCheckBox4;
        private System.Windows.Forms.CheckBox DrugRequiresPrescriptionCheckBox3;
        private System.Windows.Forms.CheckBox DrugAllergicCheckBox2;
        private System.Windows.Forms.CheckBox DrugAntibioticCheckBox1;
        private System.Windows.Forms.Button AddDrugButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorValidateLabel;
        private System.Windows.Forms.Button ResetButton1;
    }
}