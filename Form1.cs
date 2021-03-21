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
        private List<Drug> drugs = new List<Drug>();

        Timer myTimer;
        public HomePharmaForm()
        {
            InitializeComponent();
            ReadFromJson();
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

            if (drugs.Count > 0)
            {
                ViewDrugForm viewDrug = new ViewDrugForm(drugs);
                viewDrug.ShowDialog();
            }
            else 
            {
                MessageBox.Show("There is no medicine on stock.");
            }

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



        private void ReadFromJson()
        {
            try
            {
                // Deserialization = making a string into an object   
                // Read file into a string and deserialize JSON to a type
                // ReadAllText closes the file automatically
                drugs = JsonConvert.DeserializeObject<List<Drug>>(File.ReadAllText(@"C:\Users\mireb\source\repos\MiryPharma\DrugsFiles\drugs.json"));
                
                MessageBox.Show($"{drugs.Count} meds loaded");
            }

            catch (Exception ex)
            {
                // expected to fail if there is no file but no point in doing smth
                // MessageBox.Show($"{ex.Message} \r\n {ex.StackTrace}");
            }
        }

        private void WriteToJson()
        {
            try
            {
                // Serialization = writing an object to a string 
                // serialize JSON to a string and then write string to a file
                File.WriteAllText(@"C:\Users\mireb\source\repos\MiryPharma\DrugsFiles\drugs.json", JsonConvert.SerializeObject(drugs));

                // serialize JSON directly to a file
                using (StreamWriter file = File.CreateText(@"C:\Users\mireb\source\repos\MiryPharma\DrugsFiles\drugs-copy.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, drugs);
                }

                // this calls Dispose() on the sw and it is closing the file
            }

            catch (Exception ex)
            {
                // System.Diagnostics.Trace 
                // a way to log all these exceptions in a file
            }
        }

        private void HomePharmaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteToJson();
        }

        private void MailLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailMe();
        }

        private void MailMe() 
        {
            if (drugs.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                 
                foreach (Drug d in this.drugs)
                {
                   stringBuilder.AppendLine
                        (
                        $"- Medicine: {d.Name}, " +
                        $"Quantity: {d.Quantity} { d.QuantityUnits}, " +
                        $"Expires: {d.ExpiryDate.ToShortDateString()} ;" +
                        $"\n"
                        );
                }
                string emailAddress = "miry@contoso.com";
                string subject = $"My home pharmacy has {drugs.Count} medicines on stock.";
                string body = stringBuilder.ToString();
                string mailto = string.Format($"mailto:{emailAddress}?subject={subject}&body={body}");
                mailto = Uri.EscapeUriString(mailto);


                System.Diagnostics.Process.Start(mailto);
            }

            else 
            {
                MessageBox.Show($"You don't have any medicine on stock!");
            }


        }
    }
}
