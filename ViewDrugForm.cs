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
    public partial class ViewDrugForm : Form
    {
        private List<Drug> drugs;
        public ViewDrugForm(List<Drug> drugs)
        {
            InitializeComponent();
            this.drugs = drugs;
        }

        private void ViewDrugForm_Load(object sender, EventArgs e)
        {
            CreateDGV();
        }

        private void DrugViewDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DrugViewDataGridView1.Columns[e.ColumnIndex].Name == "DrugDelete")
            {
                Drug drg = (Drug)this.DrugViewDataGridView1.CurrentCell.OwningRow.DataBoundItem;

                var confirmResult = MessageBox.Show($"Are you sure you want to delete {drg.Name}?",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        this.drugs.Remove(drg);
                        DrugViewDataGridView1.DataSource = null;
                        DrugViewDataGridView1.DataSource = drugs;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Oops, unable to delete Drug.\n{ex.Message}");
                    }
                }

            }
        }

        private void CreateDGV()
        {
            DrugViewDataGridView1.AutoGenerateColumns = false;
            DrugViewDataGridView1.DataSource = drugs;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "DrugName";
            column1.HeaderText = "Name";
            column1.DataPropertyName = "Name";
            DrugViewDataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "ActiveIngredient";
            column2.HeaderText = "Ingredient";
            column2.DataPropertyName = "ActiveIngredient";
            DrugViewDataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "DrugQuantity";
            column3.HeaderText = "Qty";
            column3.DataPropertyName = "Quantity";
            DrugViewDataGridView1.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "QuantityUnits";
            column4.HeaderText = "Units";
            column4.DataPropertyName = "QuantityUnits";
            DrugViewDataGridView1.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "DrugExpiryDate";
            column5.HeaderText = "Expiry Date";
            column5.DataPropertyName = "ExpiryDate";
            DrugViewDataGridView1.Columns.Add(column5);

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "Antibiotic";
            column6.HeaderText = "Antibiotic";
            column6.DataPropertyName = "Antibiotic";
            DrugViewDataGridView1.Columns.Add(column6);

            DataGridViewButtonColumn column7 = new DataGridViewButtonColumn();
            column7.Name = "DrugDelete";
            column7.HeaderText = "Delete";
            column7.UseColumnTextForButtonValue = true;
            column7.Text = "Delete";
            DrugViewDataGridView1.Columns.Add(column7);

        }


    }
}
