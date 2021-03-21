using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiryPharma
{
    public partial class AddDrugForm : Form
    {
        private List<Drug> drugs;
        public AddDrugForm(List<Drug> drugs)
        {
            this.drugs = drugs;
            InitializeComponent();
        }

        private void AddDrugForm_Load(object sender, EventArgs e)
        {
            DrugQtyUnitsComboBox1.DataSource = Enum.GetValues(typeof(QuantityUnitsEnum));
            ExpirationDateTimePicker1.Value = DateTime.Today.AddMonths(6);
            SymptomsCheckedListBox.DataSource = Enum.GetValues(typeof(SymptomsEnum));
            SymptomsCheckedListBox.SelectedIndex = (int)SymptomsEnum.Other;
            DrugMedTypeComboBox1.DataSource = Enum.GetValues(typeof(DrugMedTypeEnum));
            DrugScopeComboBox1.DataSource = Enum.GetValues(typeof(DrugScopeEnum));
            DrugTakingComboBox1.DataSource = Enum.GetValues(typeof(DrugHowToTakeEnum));
            DrugAgeComboBox1.DataSource = Enum.GetValues(typeof(DrugAgeCategoryEnum));
            DrugFormatComboBox1.DataSource = Enum.GetValues(typeof(DrugFormatEnum));

        }

        private bool ValidateForm()
        {
            if (this.DrugNameTextBox.Text == "")
            {
                this.ErrorValidateLabel.Visible = true;
                this.ErrorValidateLabel.Text = "Name of the medicine cannot be empty \r\n";
                return false;
            }

            if (int.TryParse(this.DrugQuantityTextBox.Text, out int qty) == false || int.Parse(this.DrugQuantityTextBox.Text) <= 0)
            {
                this.ErrorValidateLabel.Visible = true;
                this.ErrorValidateLabel.Text = "Quantity is not in the correct format \r\n";
                return false;
            }

            this.ErrorValidateLabel.Visible = false;
            return true;
        }


        private void AddDrug()
        {

            if (ValidateForm())
            {
                Drug drug1 = new Drug();
                drug1.Name = this.DrugNameTextBox.Text;
                drug1.ExpiryDate = this.ExpirationDateTimePicker1.Value;
                drug1.Quantity = int.Parse(this.DrugQuantityTextBox.Text);
                drug1.QuantityUnits = (QuantityUnitsEnum)this.DrugQtyUnitsComboBox1.SelectedItem;
                drug1.ActiveIngredient = this.DrugActiveIngredientTextBox1.Text;
                drug1.DrugMedType = (DrugMedTypeEnum)this.DrugMedTypeComboBox1.SelectedItem;
                drug1.DrugAgeCategory = (DrugAgeCategoryEnum)this.DrugAgeComboBox1.SelectedItem;
                drug1.DrugScope = (DrugScopeEnum)this.DrugScopeComboBox1.SelectedItem;
                drug1.DrugHowToTake = (DrugHowToTakeEnum)this.DrugTakingComboBox1.SelectedItem;
                drug1.DrugFormat = (DrugFormatEnum)this.DrugFormatComboBox1.SelectedItem;
                drug1.FirstTimeUse = this.DrugFirstTimeUseCheckBox1.Checked;
                drug1.Antibiotic = this.DrugAntibioticCheckBox1.Checked;
                drug1.Allergic = this.DrugAllergicCheckBox2.Checked;
                drug1.RequiresPrescription = this.DrugRequiresPrescriptionCheckBox3.Checked;
                drug1.PrescriptionAvailable = this.DrugPrescriptionAvailableCheckBox4.Checked;

                List<SymptomsEnum> selectedSymptoms = new List<SymptomsEnum>();
                foreach (SymptomsEnum symptom in SymptomsCheckedListBox.CheckedItems)
                {
                    selectedSymptoms.Add(symptom);
                }
                drug1.symptomsStr = string.Join(",", selectedSymptoms);

                this.drugs.Add(drug1);

                //message box with product added successfully

                MessageBox.Show($"Medicine \"{drug1.Name}\" added successfully");
            }

        }

        private void AddDrugButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddDrug();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, failure: {ex.GetType().FullName} \r\n {ex.Message} \r\n {ex.StackTrace} ");
            }
        }


        private void ResetForm()
        {
            this.DrugNameTextBox.Text = "";
            this.DrugQuantityTextBox.Text = "1";
            this.DrugActiveIngredientTextBox1.Text = "-";
            this.ExpirationDateTimePicker1.Value = DateTime.Today.AddMonths(6);
            this.DrugQtyUnitsComboBox1.SelectedIndex = (int)QuantityUnitsEnum.Pieces;
            this.SymptomsCheckedListBox.SelectedIndex = (int)SymptomsEnum.Other;
            this.DrugMedTypeComboBox1.SelectedIndex= (int)DrugMedTypeEnum.Allopathic;
            this.DrugAgeComboBox1.SelectedIndex = (int)DrugAgeCategoryEnum.Adults;
            this.DrugScopeComboBox1.SelectedIndex = (int)DrugScopeEnum.Treatment;
            this.DrugTakingComboBox1.SelectedIndex = (int)DrugHowToTakeEnum.Oral;
            this.DrugFormatComboBox1.SelectedIndex = (int)DrugFormatEnum.Pills;
            this.DrugFirstTimeUseCheckBox1.Checked = false;
            this.DrugPrescriptionAvailableCheckBox4.Checked = false;
            this.DrugAllergicCheckBox2.Checked = false;
            this.DrugAntibioticCheckBox1.Checked = false;
        }

        private void ResetButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oops, something went wrong \n{ex.Message}");
            }

        }
    }
}
