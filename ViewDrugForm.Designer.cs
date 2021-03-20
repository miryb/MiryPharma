
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDrugForm));
            this.DrugViewDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DrugViewDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrugViewDataGridView1
            // 
            this.DrugViewDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrugViewDataGridView1.Location = new System.Drawing.Point(50, 33);
            this.DrugViewDataGridView1.Name = "DrugViewDataGridView1";
            this.DrugViewDataGridView1.RowHeadersWidth = 51;
            this.DrugViewDataGridView1.RowTemplate.Height = 24;
            this.DrugViewDataGridView1.Size = new System.Drawing.Size(1062, 618);
            this.DrugViewDataGridView1.TabIndex = 0;
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
            this.Text = "View your medicine";
            ((System.ComponentModel.ISupportInitialize)(this.DrugViewDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DrugViewDataGridView1;
    }
}