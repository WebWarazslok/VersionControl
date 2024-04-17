using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace HCC_Proba
{
    public partial class Form1 : Form
    {
        private const string xd = "xd";
        private static readonly HttpClient client = new HttpClient();
        private const string ApiKey = "1-2d78ad9c-d5ca-46e7-8cbc-066d8e72b40c";
        private const string apiUrl = "http://20.234.113.211:8106";
        private const string apiPath = "/DesktopModules/Hotcakes/API/rest/v1/";
        private const string endPoint = "giftcards";
        public int GiftCNum = 1;
        public List<int> giftNumsList = new List<int>();
        public Random r = new Random();
        public string giftCardNum = "";
        // specify the gift card expiration date
        public DateTime expirationDate = DateTime.Now.Date.AddYears(1);

        public Form1()
        {
            InitializeComponent();
        }




        private async void Form1_Load(object sender, EventArgs e)
        {

            //Regions

            #region Payment status values
            /*
             * PaymentStatus == 0 --> Order has not been completed.
             * PaymentStatus == 1 --> Unpaid.
             * PaymentStatus == 2 --> Partially paid.
             * PaymentStatus == 3 --> Paid.
             * PaymentStatus == 4 --> Overpaid.
             * */
            #endregion

            // GET kérés az API-hoz
            string response = await GetInfoEndPoint(apiUrl, ApiKey, apiPath, endPoint);

            // JSON válasz feldolgozása és az eredmény kinyerése
            JObject jsonResponse = JObject.Parse(response);
            string result = jsonResponse["Content"].ToString();
            int giftR = r.Next() * 1000;

            // specify the gift card Number
            if (!giftNumsList.Contains(GiftCNum))
            {
                giftCardNum = $"BOLT-{giftR}-{GiftCNum}";
                giftNumsList.Add(GiftCNum);
                GiftCNum++;
            }
            else
            {
                GiftCNum++;
                giftCardNum = $"BOLT-{giftR}-{GiftCNum}";
                giftNumsList.Add(GiftCNum);
            }

            //Label changes
            if (expirationDate.Month<10)
            {
                if (expirationDate.Day<10)
                {
                    lbl_erv.Text = $"{expirationDate.Year.ToString()}.0{expirationDate.Month.ToString()}.0{expirationDate.Day.ToString()}";
                }
                else lbl_erv.Text = $"{expirationDate.Year.ToString()}.0{expirationDate.Month.ToString()}.{expirationDate.Day.ToString()}";
            }
            else lbl_erv.Text = $"{expirationDate.Year.ToString()}.{expirationDate.Month.ToString()}.{expirationDate.Day.ToString()}";
            lbl_kod.Text = giftCardNum.ToString();

            //TextBox changes
            textBox5.Text = lbl_erv.Text;
        }

        //GET REQUEST
        static async Task<string> GetInfoEndPoint(string apiUrl, string apiKey, string apiPath, string endPoint)
        {
            string Endpoint = $"{apiUrl}{apiPath}{endPoint}?key={apiKey}";
            //string catsEndpoint = $"{apiUrl}{apiPath}{endPoint}/{transID}?key={apiKey}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Api-Key", apiKey);

            var response = await client.GetAsync(Endpoint);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Hiba a termékek lekérdezésekor: {response.StatusCode}";
            }
        }

        //POST REQUEST
        private async void Button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim();

            if (IsValidEmail(email))
            {
                string input = textBox3.Text;

                if (IsValidNumericInput(input))
                {
                    // create a new gift card object with minimal information
                    var giftCard = new
                    {
                        CardNumber = giftCardNum,
                        Amount = Convert.ToInt32(textBox3.Text),
                        ExpirationDateUtc = expirationDate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                        RecipientName = textBox1.Text,
                        RecipientEmail = textBox2.Text,
                        Enabled = true
                    };

                    // serialize the gift card object to JSON
                    var json = JsonConvert.SerializeObject(giftCard);

                    // create a StringContent object with the JSON data
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // build the request URL
                    var requestUrl = $"{apiUrl}{apiPath}{endPoint}?key={ApiKey}";

                    try
                    {
                        // send the POST request
                        var response = await client.PostAsync(requestUrl, content);

                        // check if the request was successful
                        if (response.IsSuccessStatusCode)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("POST request successful!");
                        }
                        else
                        {
                            MessageBox.Show("POST request failed. Status code: " + response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending POST request: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Helytelen összeg. A helyes formátum: 5000", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Helytelen email cím. A helyes formátum: Pelda@pelda.com.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private bool IsValidNumericInput(string input)
        {
            // Regular expression pattern for numeric input validation
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_nev.Text = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lbl_amount.Text = textBox3.Text + " Ft";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lbl_kod.Text = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += (sender, e) =>
                {
                    Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                    panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
                    e.Graphics.DrawImage(bmp, 0, 0);
                };

                printDocument.Print();
            }
        }
    }
}