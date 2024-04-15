using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace HCC_Proba
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient();
        private const string ApiKey = "1-2d78ad9c-d5ca-46e7-8cbc-066d8e72b40c";
        private const string apiUrl = "http://20.234.113.211:8106";
        private const string apiPath = "/DesktopModules/Hotcakes/API/rest/v1/";
        private const string endPoint = "giftcards";
        public int GiftCNum = 1;
        public List<int> giftNumsList = new List<int>();
        public Random r = new Random();

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
            richTextBox1.Text = result;

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
            string giftCardNum="";
            int giftR = r.Next() * 1000;

            // specify the gift card expiration date
            var expirationDate = DateTime.Now.Date.AddYears(1);
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
            //Form1_Load(sender, e);
        }
    }
}