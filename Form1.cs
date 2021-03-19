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
        // Create a list for images
        // List<Image> BannerImages;

        // Create a queue for images
        Queue<Image> BannerImages;

        Timer myTimer;
        public HomePharmaForm()
        {
            InitializeComponent();
        }

        private void HomePharmaForm_Load(object sender, EventArgs e)
        {

        }

        void PopulateBannerImages() 
        {
            // Initialize the list
            // BannerImages = new List<Image>();

            // Initialize the queue
            BannerImages = new Queue<Image>();

            // Resources
            System.Resources.ResourceManager rm = global::MiryPharma.Properties.Resources.ResourceManager;

            for (int i = 1; i <= 5; i++) 
            {
                // Add to List
                // BannerImages.Add((Image)rm.GetObject($"{i}"));

                BannerImages.Enqueue((Image)rm.GetObject($"{i}"));
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
                // Select first from List and remove
                // BannerPicturBox.BackgroundImage = BannerImages[0];
                // BannerImages.RemoveAt(0);

                // assign and dequeue current
                BannerPicturBox.BackgroundImage = BannerImages.Dequeue();
            }
            else 
            {
                StopTimer();
            }
        }

        private void AddDrugsButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Work in progress.");
            AddDrugForm addDrug = new AddDrugForm();
            addDrug.ShowDialog();
        }

        private void ViewDrugsButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("There is no medicine on stock.");
            ViewDrugForm viewDrug = new ViewDrugForm();
            viewDrug.ShowDialog();
        }

        private void BannerPicturBox_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void HomePharmaForm_Shown_1(object sender, EventArgs e)
        {
            PopulateBannerImages();
            SetTimer();
        }
    }
}
