using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MiryPharma
{
    public partial class HomePharmaForm : Form
    {
        Queue<Image> BannerImages;
        private List <Drug> drugs = new List<Drug>();

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
            BannerImages = new Queue<Image>();

            // Resources
            System.Resources.ResourceManager rm = global::MiryPharma.Properties.Resources.ResourceManager;

            for (int i = 1; i <= 5; i++) 
            {
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
            AddDrugForm addDrug = new AddDrugForm(drugs);
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



        private void ReadJson()
        {
            try
            {
                //// deserialize JSON directly from a file (path of the file in project?)
                //using (StreamReader file = new StreamReader(@"c:\Drugs.json"))
                //{
                //    JsonSerializer serializer = new JsonSerializer();
                //    List<Drug> drugs = (List<Drug>)serializer.Deserialize(file, typeof(List<Drug>));
                //}

                // read file into a string and deserialize JSON to a type
                List<Drug> drugs = JsonConvert.DeserializeObject<List<Drug>>(File.ReadAllText(@"C:\Users\mireb\source\repos\MiryPharma\DrugsFiles\drugs.json"));
            }

            catch (Exception ex)
            {
                // expected to fail if there is no file but no point in doing smth
            }
        }
    }
}
