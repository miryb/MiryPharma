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
        public AddDrugForm()
        {
            InitializeComponent();
        }

        private void DrugQuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDrugForm_Load(object sender, EventArgs e)
        {
            QtyUnitsComboBox1.DataSource = Enum.GetValues(typeof(QuantityUnitsEnum));
            ExpirationDateTimePicker1.Value = DateTime.Today.AddMonths(6);
            SymptomsCheckedListBox.DataSource = Enum.GetValues(typeof(SymptomsEnum));
            MedTypeComboBox1.DataSource = Enum.GetValues(typeof(DrugMedTypeEnum));
            DrugScopeComboBox1.DataSource = Enum.GetValues(typeof(DrugScopeEnum));
            DrugTakingComboBox1.DataSource = Enum.GetValues(typeof(DrugHowToTakeEnum));
            DrugAgeComboBox1.DataSource = Enum.GetValues(typeof(DrugAgeCategoryEnum));
            DrugFormatComboBox1.DataSource = Enum.GetValues(typeof(DrugFormatEnum));

        }

        private void FirstTimeUseCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
