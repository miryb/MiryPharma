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
        private bool editMode;
        private List<Drug> drugs;
        private Drug drug;

        public AddDrugForm(List<Drug> drugs)
        {
            this.drugs = drugs;
            InitializeComponent();
            defaultsAddDrug();
        }

        public AddDrugForm(Drug drg)
        {
            editMode = true;
            this.drug = drg;
            InitializeComponent();
            defaultsAddDrug();

            // set the fields with the values of the current Drug
            this.DrugNameTextBox.Text = drg.Name;
            this.ExpirationDateTimePicker1.Value = drg.ExpiryDate;
            this.DrugQuantityTextBox.Text = drg.Quantity.ToString();
            this.DrugActiveIngredientTextBox1.Text = drg.ActiveIngredient;
            this.DrugFirstTimeUseCheckBox1.Checked = drg.FirstTimeUse;
            this.DrugAntibioticCheckBox1.Checked = drg.Antibiotic;
            this.DrugAllergicCheckBox2.Checked = drg.Allergic;
            this.DrugRequiresPrescriptionCheckBox3.Checked = drg.RequiresPrescription;
            this.DrugPrescriptionAvailableCheckBox4.Checked = drg.PrescriptionAvailable;
            this.DrugQtyUnitsComboBox1.SelectedItem = drg.QuantityUnits;
            this.DrugMedTypeComboBox1.SelectedItem = drg.DrugMedType;
            this.DrugAgeComboBox1.SelectedItem = drg.DrugAgeCategory;
            this.DrugScopeComboBox1.SelectedItem = drg.DrugScope;
            this.DrugTakingComboBox1.SelectedItem = drg.DrugHowToTake;
            this.DrugFormatComboBox1.SelectedItem = drg.DrugFormat;

            // Set Selected Items on DrugSymptomsListBox1.Se
            var selectedItems = drg.symptomsEnumList;
            selectedItems.Select(sd => DrugSymptomsListBox1.Items.IndexOf(sd)).Where(i => i >= 0).ToList().ForEach(i => this.DrugSymptomsListBox1.SetSelected(i, true));
        }

        private void AddDrugForm_Load(object sender, EventArgs e)
        {

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
                drug1.symptomsEnumList = (this.DrugSymptomsListBox1.SelectedItems).Cast<SymptomsEnum>().ToList();

                // current logic for ListBox and CheckedListBox - "gross"
                
                List<SymptomsEnum> selectedSymptoms = new List<SymptomsEnum>();

                /*
                foreach (SymptomsEnum symptom in SymptomsCheckedListBox.CheckedItems)
                {
                    selectedSymptoms.Add(symptom);
                }
                drug1.symptomsStr = string.Join(",", selectedSymptoms);
                */

                foreach (SymptomsEnum symptom in DrugSymptomsListBox1.SelectedItems) 
                {
                    selectedSymptoms.Add(symptom);
                }
                drug1.symptomsStr = string.Join(",", selectedSymptoms);


                // add new item to the list
                this.drugs.Add(drug1);

                 // Message box with product added successfully
                 MessageBox.Show($"Medicine \"{drug1.Name}\" added successfully");

            }
        }

        private void AddDrugButton_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                try
                {
                    AddDrug();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Oops, failure in adding product: {ex.GetType().FullName} \r\n {ex.Message} \r\n {ex.StackTrace} ");
                }
            }

            else 
            {
                try
                {
                   EditDrug();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Oops, failure in editing product: {ex.GetType().FullName} \r\n {ex.Message} \r\n {ex.StackTrace} ");
                }

            }

        }

        private void EditDrug()
        {
            if (ValidateForm())
            {
                
                this.drug.Name = this.DrugNameTextBox.Text;
                this.drug.ExpiryDate = this.ExpirationDateTimePicker1.Value;
                this.drug.Quantity = int.Parse(this.DrugQuantityTextBox.Text);
                this.drug.QuantityUnits = (QuantityUnitsEnum)this.DrugQtyUnitsComboBox1.SelectedItem;
                this.drug.ActiveIngredient = this.DrugActiveIngredientTextBox1.Text;
                this.drug.DrugMedType = (DrugMedTypeEnum)this.DrugMedTypeComboBox1.SelectedItem;
                this.drug.DrugAgeCategory = (DrugAgeCategoryEnum)this.DrugAgeComboBox1.SelectedItem;
                this.drug.DrugScope = (DrugScopeEnum)this.DrugScopeComboBox1.SelectedItem;
                this.drug.DrugHowToTake = (DrugHowToTakeEnum)this.DrugTakingComboBox1.SelectedItem;
                this.drug.DrugFormat = (DrugFormatEnum)this.DrugFormatComboBox1.SelectedItem;
                this.drug.FirstTimeUse = this.DrugFirstTimeUseCheckBox1.Checked;
                this.drug.Antibiotic = this.DrugAntibioticCheckBox1.Checked;
                this.drug.Allergic = this.DrugAllergicCheckBox2.Checked;
                this.drug.RequiresPrescription = this.DrugRequiresPrescriptionCheckBox3.Checked;
                this.drug.PrescriptionAvailable = this.DrugPrescriptionAvailableCheckBox4.Checked;
                this.drug.symptomsEnumList = (this.DrugSymptomsListBox1.SelectedItems).Cast<SymptomsEnum>().ToList();


                // current logic with ListBox CheckedListBox
                
                List<SymptomsEnum> selectedSymptoms = new List<SymptomsEnum>();
                foreach (SymptomsEnum symptom in DrugSymptomsListBox1.SelectedItems)
                {
                    selectedSymptoms.Add(symptom);
                }
                drug.symptomsStr = string.Join(",", selectedSymptoms);
                

                // Message box with product added successfully
                MessageBox.Show($"Medicine \"{drug.Name}\" edited successfully");

                this.Close();

            }
        }


        private void ResetForm()
        {
            // Reset Text Boxes
            this.DrugNameTextBox.Text = "";
            this.DrugQuantityTextBox.Text = "1";
            this.DrugActiveIngredientTextBox1.Text = "-";

            // Reset Calendar's expiry date to 6M
            this.ExpirationDateTimePicker1.Value = DateTime.Today.AddMonths(6);
            
            // Reset selected option in dropdown lists
            this.DrugQtyUnitsComboBox1.SelectedIndex = (int)QuantityUnitsEnum.Pieces;
            this.DrugMedTypeComboBox1.SelectedIndex= (int)DrugMedTypeEnum.Allopathic;
            this.DrugAgeComboBox1.SelectedIndex = (int)DrugAgeCategoryEnum.Adults;
            this.DrugScopeComboBox1.SelectedIndex = (int)DrugScopeEnum.Treatment;
            this.DrugTakingComboBox1.SelectedIndex = (int)DrugHowToTakeEnum.Oral;
            this.DrugFormatComboBox1.SelectedIndex = (int)DrugFormatEnum.Pills;

            // Reset Checkboxes 
            this.DrugFirstTimeUseCheckBox1.Checked = false;
            this.DrugPrescriptionAvailableCheckBox4.Checked = false;
            this.DrugAllergicCheckBox2.Checked = false;
            this.DrugAntibioticCheckBox1.Checked = false;

            // Reset CheckedItems in CheckedListBox
            /*
            this.SymptomsCheckedListBox.DataSource = null;
            this.SymptomsCheckedListBox.DataSource = Enum.GetValues(typeof(SymptomsEnum));
            this.SymptomsCheckedListBox.SelectedIndex = (int)SymptomsEnum.Other;
            */

            // Reset selected Items in ListBox
            this.DrugSymptomsListBox1.ClearSelected(); 
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

        private void defaultsAddDrug() 
        {
            // Binding components or setting defaults 
            DrugQtyUnitsComboBox1.DataSource = Enum.GetValues(typeof(QuantityUnitsEnum));
            ExpirationDateTimePicker1.Value = DateTime.Today.AddMonths(6);
          //  SymptomsCheckedListBox.DataSource = Enum.GetValues(typeof(SymptomsEnum));
          //  SymptomsCheckedListBox.SelectedIndex = (int)SymptomsEnum.Other;
            DrugMedTypeComboBox1.DataSource = Enum.GetValues(typeof(DrugMedTypeEnum));
            DrugScopeComboBox1.DataSource = Enum.GetValues(typeof(DrugScopeEnum));
            DrugTakingComboBox1.DataSource = Enum.GetValues(typeof(DrugHowToTakeEnum));
            DrugAgeComboBox1.DataSource = Enum.GetValues(typeof(DrugAgeCategoryEnum));
            DrugFormatComboBox1.DataSource = Enum.GetValues(typeof(DrugFormatEnum));

            List<SymptomsEnum> symptoms = Enum.GetValues(typeof(SymptomsEnum)).Cast<SymptomsEnum>().ToList();
            DrugSymptomsListBox1.DataSource = symptoms;
            DrugSymptomsListBox1.SelectionMode = SelectionMode.MultiExtended;
            DrugSymptomsListBox1.ClearSelected();


        }
    }
}
