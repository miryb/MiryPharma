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
            

            // Style for Column Headers
            DrugViewDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);

            //FromArgb(112, 173, 71);
            DrugViewDataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DrugViewDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida sans", 9.7F, FontStyle.Bold);

            // Style for Selected Row
            DrugViewDataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 173, 71);
            DrugViewDataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

           DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "DrugName";
            column1.HeaderText = "Name";
            column1.DataPropertyName = "Name";
            column1.ReadOnly = true;
            DrugViewDataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "DrugQuantity";
            column2.HeaderText = "Qty";
            column2.DataPropertyName = "Quantity";
            DrugViewDataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "QuantityUnits";
            column3.HeaderText = "Units";
            column3.DataPropertyName = "QuantityUnits";
            DrugViewDataGridView1.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "DrugExpiryDate";
            column4.HeaderText = "Expiry Date";
            column4.DataPropertyName = "ExpiryDate";
            DrugViewDataGridView1.Columns.Add(column4);

            DataGridViewButtonColumn column5 = new DataGridViewButtonColumn();
            column5.Name = "DrugDelete";
            column5.HeaderText = "Delete";
            column5.UseColumnTextForButtonValue = true;
            column5.Text = "Delete";
            //column7.FlatStyle = FlatStyle.Standard;
            //column7.CellTemplate.Style.BackColor = Color.LightCoral;
            //column7.CellTemplate.Style.ForeColor = Color.White;
            DrugViewDataGridView1.Columns.Add(column5);

            
        }


    }
}
