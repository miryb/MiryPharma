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
        private IEnumerable<Drug> drugs;
        public ViewDrugForm(IEnumerable<Drug> drugs)
        {
            InitializeComponent();
            this.drugs = drugs;
        }
    }
}
