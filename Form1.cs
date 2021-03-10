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
    public partial class HomePharmaForm : Form
    {
        List<Image> BannerImages;

        Timer myTimer;
        public HomePharmaForm()
        {
            InitializeComponent();
        }

        private void HomePharmaForm_Load(object sender, EventArgs e)
        {
            PopulateBannerImages();
            SetTimer();
        }

        void PopulateBannerImages() 
        {
            BannerImages = new List<Image>();
            System.Resources.ResourceManager rm = global::MiryPharma.Properties.Resources.ResourceManager;

            for (int i = 1; i <= 5; i++) 
            {
               BannerImages.Add((Image)rm.GetObject($"{i}"));
            }
        }

        void SetTimer() 
        {
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(RollImagesBanner);
            myTimer.Interval = 3000;
            myTimer.Start();
        }

        void StopTimer() 
        {
            myTimer.Stop();
            BannerPicturBox.BackgroundImage = global::MiryPharma.Properties.Resources.Welcome_FeelingSick;
        }
        void RollImagesBanner(Object myObject, EventArgs myEventArgs) 
        {
            if (BannerImages.Count > 0)
            {
                BannerPicturBox.BackgroundImage = BannerImages[0];
                BannerImages.RemoveAt(0);
            }
            else 
            {
                StopTimer();
            }
        }

        private void AddDrugsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress.");
        }

        private void ViewDrugsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no medicine on stock.");
        }

        private void BannerPicturBox_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
}
