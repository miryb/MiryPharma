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
        // Banner image gallery
        Queue<Image> BannerImages;
        Timer myTimer;

        // List containing the meds
        private List<Drug> drugs = new List<Drug>();

        // JSON Files Paths
        private static string jsonFilePathDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MiryPharma");
        private static string jsonFilePath = Path.Combine(jsonFilePathDir, "drugs.json");
        private string jsonFileCopyPath = Path.Combine(jsonFilePathDir, "drugs-copy.json");
        private string jsonFileExpiredMed = Path.Combine(jsonFilePathDir, "drugs-expired.json");


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
            myTimer.Interval = 5000;
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
            AddDrugForm addDrug = new AddDrugForm(drugs);
            addDrug.ShowDialog();
        }

        private void ViewDrugsButton_Click(object sender, EventArgs e)
        {
            if (drugs.Count > 0)
            {
                ViewDrugForm viewDrug = new ViewDrugForm(drugs);
                viewDrug.ShowDialog(this);
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

                // for Directory not found exception
                if (!Directory.Exists(jsonFilePathDir))
                {
                    Directory.CreateDirectory(jsonFilePathDir);
                }


                drugs = JsonConvert.DeserializeObject<List<Drug>>(File.ReadAllText(jsonFilePath));

                MessageBox.Show($"{drugs.Count} meds loaded");
            }

            catch (FileNotFoundException)
            {
                // expected to fail but there is no point in doing something 
            }

            catch (Exception ex)
            {
                // catching the others
                MessageBox.Show($"{ex.Message} \n {ex.GetType().FullName}");
            }
        }

        private void WriteToJson()
        {
            try
            {
                if (drugs.Count > 0)
                {
                    if (!Directory.Exists(jsonFilePathDir)) 
                    {
                        Directory.CreateDirectory(jsonFilePathDir); 
                    }
                    // Serialization = writing an object to a string 

                    // Serialize JSON to a string and then write string to a file
                    File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(drugs));

                    // Make a copy
                    File.Copy(jsonFilePath, jsonFileCopyPath, true);

                    // Get expired meds and write to json file
                    WriteExpiredToJson();
                }
            }

            catch (Exception ex)
            {
                // System.Diagnostics.Trace 
                // a way to log all these exceptions in a file
                MessageBox.Show($"{ex.Message} \r\n {ex.StackTrace}");
            }
        }

        private void WriteExpiredToJson() 
        {
            List<Drug> expiredDrugs = new List<Drug>();
            foreach (Drug drug in drugs) 
            {
                if (drug.ExpiryDate < DateTime.Today) 
                {
                    expiredDrugs.Add(drug);
                }
            }
            // serialize JSON directly to a file
            
            using (StreamWriter file = File.CreateText(jsonFileExpiredMed))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, expiredDrugs);
            }

            // this calls Dispose() on the sw and it is closing the file
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
                mailto = Uri.EscapeUriString(mailto); // for new lines in body

                System.Diagnostics.Process.Start(mailto);
            }
            else 
            {
                MessageBox.Show($"You don't have any medicine on stock!");
            }
        }
    }
}
