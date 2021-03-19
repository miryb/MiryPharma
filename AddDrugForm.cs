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
            QtyUnitsComboBox1.SelectedValue = QuantityUnitsEnum.Pieces;
            ExpirationDateTimePicker1.Value = DateTime.Today.AddDays(31);
            //checkedListBox2.DataSource = Enum.GetValues(typeof(SymptomsEnum));
           // checkedListBox2.Items.AddRange(Enum.GetValues(typeof(SymptomsEnum));
        }
    }
}
