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

namespace HCC_Proba
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient();
        private const string ApiKey = "1-2d78ad9c-d5ca-46e7-8cbc-066d8e72b40c";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            string apiUrl = "http://20.234.113.211:8106";
            string apiPath = "/DesktopModules/Hotcakes/API/rest/v1/";
            string endPoint = "orders";
            string transactionId = "B12F0CAC-F60A-44F1-BA45-6240201180BC";
            // Példa GET kérés az API-hoz
            string response = await GetInfoEndPoint(apiUrl, ApiKey, apiPath,endPoint, transactionId);

           
            
            // JSON válasz feldolgozása és az eredmény kinyerése
            JObject jsonResponse = JObject.Parse(response);

            // A Content tömb lekérdezése
            JArray contentArray = (JArray)jsonResponse["Content"];
            int i = 0;
            // Az egyes elemek lekérdezése a tömbből
            foreach (JObject item in contentArray)
            {
                
                if (i< 10&& item["UserEmail"].ToString()!= "info@hotcakescommerce.com")
                {
                    string orderbvin = item["bvin"].ToString();
                    string orderEmail = item["UserEmail"].ToString();
                    richTextBox1.AppendText($"Order bvin: {orderbvin}; Order Email: {orderEmail}\n");
                    i++;
                }
                
            }

            //JSON respone feldolgozása tömbbe
            //string[] result = jsonResponse["Content"].ToString().Split(',');

            // if (jsonResponse["Content"]["bvin"]!=null)
            //{
            //string[] result = jsonResponse["Content"]["bvin"].ToString().Split(',');
              //  richTextBox1.Text += result;
            //}
            
            
            // Az eredmény megjelenítése a RichTextBox-ban

            /*for (int i = 0; i < result.Length; i++)
            {
                richTextBox1.Text += result[i];
            }*/

        }

        static async Task<string> GetInfoEndPoint(string apiUrl, string apiKey, string apiPath, string endPoint, string transID)
        {
             string catsEndpoint = $"{apiUrl}{apiPath}{endPoint}?key={apiKey}";
            //string catsEndpoint = $"{apiUrl}{apiPath}{endPoint}/{transID}?key={apiKey}";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Api-Key", apiKey);

            var response = await client.GetAsync(catsEndpoint);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Hiba a termékek lekérdezésekor: {response.StatusCode}";
            }
        }

    }
}