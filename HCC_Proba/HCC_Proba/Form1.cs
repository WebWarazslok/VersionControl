using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Membership;

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
            string endPoint = "products";
            // Példa GET kérés az API-hoz
            string response = await GetInfoEndPoint(apiUrl, ApiKey, apiPath,endPoint);

           /* string url = "http://20.234.113.211:8106";
            string key = "1-2d78ad9c-d5ca-46e7-8cbc-066d8e72b40c";

            Api proxy = new Api(url, key);

            // call the API to find total number of customer accounts in the store
            ApiResponse<long> response = proxy.ProductsCountOfAll();*/
            
            // JSON válasz feldolgozása és az eredmény kinyerése
            JObject jsonResponse = JObject.Parse(response);
            string result = jsonResponse["Content"].ToString();

            // Az eredmény megjelenítése a RichTextBox-ban
            
            richTextBox1.Text = result;

        }

        static async Task<string> GetInfoEndPoint(string apiUrl, string apiKey, string apiPath, string endPoint)
        {
            string catsEndpoint = $"{apiUrl}{apiPath}{endPoint}?key={apiKey}&countonly=1";

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