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
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public string giftCardNum = "";
        // specify the gift card expiration date
        public DateTime expirationDate = DateTime.Now.Date.AddYears(1);
        private Point windowLocation;

        public Form1()
        {
            InitializeComponent();
            MakePanelRounded(panel1, 70);
            MakePanelRounded(panel2, 70);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += Textbox1_GotFocus;
            textBox2.GotFocus += Textbox2_GotFocus;
            textBox3.GotFocus += Textbox3_GotFocus;
            textBox4.GotFocus += Textbox4_GotFocus;
            textBox1.LostFocus += Textbox1_LostFocus;
            textBox2.LostFocus += Textbox2_LostFocus;
            textBox3.LostFocus += Textbox3_LostFocus;
            textBox4.LostFocus += Textbox4_LostFocus;

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
            if (expirationDate.Month < 10)
            {
                if (expirationDate.Day < 10)
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
        private async void button_woc1_Click(object sender, EventArgs e)
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
                            MessageBox.Show("Sikeres kártyagenerálás!");
                            PrintDialog printDialog = new PrintDialog();
                            PrintDocument printDocument = new PrintDocument();

                            printDialog.Document = printDocument;

                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                printDocument.PrintPage += (sender, e) =>
                                {
                                    int dpi = 300; // Set desired DPI
                                    int margin = 10;
                                    int panel1PrintedHeight = (int)(panel1.Height * dpi / 96.0); // Calculate printed height of panel1
                                    int panel2PrintedHeight = (int)(panel2.Height * dpi / 96.0); // Calculate printed height of panel2

                                    using (Bitmap bmp = new Bitmap((int)(panel1.Width * dpi / 96.0), panel1PrintedHeight))
                                    using (Graphics g = Graphics.FromImage(bmp))
                                    {
                                        g.PageUnit = GraphicsUnit.Pixel;
                                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                                        g.CompositingQuality = CompositingQuality.HighQuality;
                                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                        g.SmoothingMode = SmoothingMode.AntiAlias;
                                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                                        // Draw panel1 content onto bmp
                                        panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                                        // Draw bmp onto the print page
                                        e.Graphics.DrawImage(bmp, 0, 0);

                                        // Calculate the position for panel2 below panel1
                                        int panel2PrintedTop = panel1.Height+margin;

                                        // Create a new bitmap and graphics object for panel2
                                        using (Bitmap bmp2 = new Bitmap((int)(panel2.Width * dpi / 96.0), panel2PrintedHeight))
                                        using (Graphics g2 = Graphics.FromImage(bmp2))
                                        {
                                            g.PageUnit = GraphicsUnit.Pixel;
                                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                                            g.CompositingQuality = CompositingQuality.HighQuality;
                                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                            g.SmoothingMode = SmoothingMode.AntiAlias;
                                            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                                            // Draw panel2 content onto bmp2
                                            panel2.DrawToBitmap(bmp2, new Rectangle(0, 0, bmp2.Width, bmp2.Height));

                                            // Draw bmp2 onto the print page below panel1
                                            e.Graphics.DrawImage(bmp2, 0, panel2PrintedTop);
                                        }

                                    }
                                };
                                printDocument.Print();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sikertelen kártyagenerálás! Status code: " + response.StatusCode);
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - windowLocation.X) + e.X,
                    (this.Location.Y - windowLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Design
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkRed, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.DarkRed, ButtonBorderStyle.Solid);
        }

        private void MakePanelRounded(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(panel.ClientRectangle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.ClientRectangle.Width - radius, panel.ClientRectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.ClientRectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void Textbox1_GotFocus(object sender, EventArgs e)
        {
            // Change the background color of textbox1 when it gets focus
            textBox1.BackColor = Color.Gainsboro; // You can change the color to any desired color
        }
        private void Textbox2_GotFocus(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Gainsboro;
        }
        private void Textbox3_GotFocus(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Gainsboro;
        }
        private void Textbox4_GotFocus(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Gainsboro; 
        }
        private void Textbox1_LostFocus(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DimGray;
        }
        private void Textbox2_LostFocus(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.DimGray;
        }
        private void Textbox3_LostFocus(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.DimGray;
        }
        private void Textbox4_LostFocus(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.DimGray;
        }
        #endregion
    }
}