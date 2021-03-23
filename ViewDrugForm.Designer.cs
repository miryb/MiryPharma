
namespace MiryPharma
{
    partial class ViewDrugForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDrugForm));
            this.DrugViewDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DrugViewDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrugViewDataGridView1
            // 
            this.DrugViewDataGridView1.AllowUserToAddRows = false;
            this.DrugViewDataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DrugViewDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DrugViewDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DrugViewDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DrugViewDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DrugViewDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrugViewDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrugViewDataGridView1.EnableHeadersVisualStyles = false;
            this.DrugViewDataGridView1.Location = new System.Drawing.Point(50, 33);
            this.DrugViewDataGridView1.Name = "DrugViewDataGridView1";
            this.DrugViewDataGridView1.ReadOnly = true;
            this.DrugViewDataGridView1.RowHeadersWidth = 51;
            this.DrugViewDataGridView1.RowTemplate.Height = 24;
            this.DrugViewDataGridView1.Size = new System.Drawing.Size(1022, 611);
            this.DrugViewDataGridView1.TabIndex = 0;
            this.DrugViewDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrugViewDataGridView1_CellContentClick);
            // 
            // ViewDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 674);
            this.Controls.Add(this.DrugViewDataGridView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View your medicine";
            this.Load += new System.EventHandler(this.ViewDrugForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrugViewDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DrugViewDataGridView1;
    }
}