using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;


namespace GoogleToWhatsApp
{
    public partial class Form1 : Form
    {
        private const string GoogleApiKey = "API_KEY";
        private const string GooglePlacesUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json";
        //private List<string> phoneNumbers = new List<string>();
        //private List<string> emails = new List<string>();
        //private List<string> adress = new List<string>();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "#";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Phone";
            dataGridView1.Columns[3].Name = "Email";
            dataGridView1.Columns[4].Name = "Adres";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private async void btnFetchData_Click(object sender, EventArgs e)
        {

            string location = txtLocation.Text; // Ýstanbul koordinatlarý
            string radius = "500000"; // 5 km çapýnda ara
            string type = txtCategory.Text; // Kategori

            string url = $"{GooglePlacesUrl}?location={location}&radius={radius}&type={type}&key={GoogleApiKey}";
            using (HttpClient client = new HttpClient())
            {
               string response = await client.GetStringAsync(url);
                if (response.Contains("REQUEST_DENIED"))
                {
                    MessageBox.Show("Google API anahtarýnýz geçersiz veya yetkiniz yok.", "API Hatasý 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ParseGoogleResponse(response);
            }
        }
        private void ParseGoogleResponse(string response)
        {
            JObject json = JObject.Parse(response);
            JArray results = (JArray)json["results"];

            dataGridView1.Rows.Clear();
            //phoneNumbers.Clear();
            //emails.Clear();
            //adress.Clear();
            int count = 1;
            foreach (var place in results)
            {
                string name = place["name"]?.ToString();
                string phoneNumber = place["formatted_phone_number"]?.ToString() ?? "Bilinmiyor";
                string email = place["email"]?.ToString() ?? "Bilinmiyor";
                string adres = place["vicinity"]?.ToString() ?? "bilinmiyor";

                //phoneNumbers.Add(phoneNumber);
                //emails.Add(email);
                //adress.Add(adres);
                dataGridView1.Rows.Add(count, name, phoneNumber, email,adres);
                count++;
            }
        }
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("contacts.csv"))
            {
                writer.WriteLine("Ýsim,Telefon,Email");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        writer.WriteLine($"{row.Cells[0].Value},{row.Cells[1].Value},{row.Cells[2].Value}");
                    }
                }
            }
            MessageBox.Show("Veriler baþarýyla Excel'e aktarýldý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSendWhatsApp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() != "Bilinmiyor")
                {
                    string phone = row.Cells[1].Value.ToString();
                    string message = "Merhaba, iþletmeniz hakkýnda bilgi almak istiyorum.";
                    string url = $"https://api.whatsapp.com/send?phone={phone}&text={Uri.EscapeDataString(message)}";
                    System.Diagnostics.Process.Start(url);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
