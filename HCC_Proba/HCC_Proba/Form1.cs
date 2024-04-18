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
using System.Runtime.InteropServices;

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
            MakePanelRounded(panel1, 50);
            MakePanelRounded(panel2, 50);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            textBox1.GotFocus += Textbox1_GotFocus;
            textBox2.GotFocus += Textbox2_GotFocus;
            textBox3.GotFocus += Textbox3_GotFocus;
            textBox4.GotFocus += Textbox4_GotFocus;
            textBox1.LostFocus += Textbox1_LostFocus;
            textBox2.LostFocus += Textbox2_LostFocus;
            textBox3.LostFocus += Textbox3_LostFocus;
            textBox4.LostFocus += Textbox4_LostFocus;

            float cornerRadius = 50; // Adjust the radius value as needed

            // Get the region for the rounded rectangle
            ApplyRoundedCorners(pictureBox1, cornerRadius, true);
            ApplyRoundedCorners(pictureBox2, cornerRadius, false);

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
                                        int panel2PrintedTop = panel1.Height + margin;

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
            base.OnPaint(e);

            Panel panel = sender as Panel;
            if (panel != null)
            {
                int borderRadius = 50; // Adjust the radius value as needed

                using (GraphicsPath path = RoundedRectangle(panel.ClientRectangle, borderRadius))
                using (Pen pen = new Pen(Color.DarkRed, 2)) // Adjust the width as needed
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                int borderRadius = 50; // Adjust the radius value as needed

                // Define the rectangle for the border
                RectangleF borderRectangle = new RectangleF(panel.ClientRectangle.Location, new SizeF(panel.ClientRectangle.Width - 1, panel.ClientRectangle.Height - 1));

                using (GraphicsPath path = RoundedRectangle(borderRectangle, borderRadius))
                using (Pen pen = new Pen(Color.DarkRed, 2)) // Adjust the width as needed
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
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
            textBox1.ForeColor = Color.DarkRed;
        }
        private void Textbox2_GotFocus(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Gainsboro;
            textBox2.ForeColor = Color.DarkRed;
        }
        private void Textbox3_GotFocus(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Gainsboro;
            textBox3.ForeColor = Color.DarkRed;
        }
        private void Textbox4_GotFocus(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Gainsboro;
            textBox4.ForeColor = Color.DarkRed;
        }
        private void Textbox1_LostFocus(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DimGray;
            textBox1.ForeColor = Color.White;
        }
        private void Textbox2_LostFocus(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.DimGray;
            textBox2.ForeColor = Color.White;
        }
        private void Textbox3_LostFocus(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.DimGray;
            textBox3.ForeColor = Color.White;
        }
        private void Textbox4_LostFocus(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.DimGray;
            textBox4.ForeColor = Color.White;
        }



        private GraphicsPath RoundedRectangle(RectangleF rectangle, float cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            float radius = cornerRadius * 2;
            SizeF size = new SizeF(radius, radius);
            RectangleF arc = new RectangleF(rectangle.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - radius;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - radius;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }
        private void ApplyRoundedCorners(PictureBox pictureBox, float cornerRadius, bool left)
        {
            if (left)
            {
                // Get the region for the rounded rectangle based on pictureBox1 width
                GraphicsPath roundedPath = RoundedRectangleLeft(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, cornerRadius);
                Region roundedRegion = new Region(roundedPath);

                // Apply the rounded region to the PictureBox
                pictureBox.Region = roundedRegion;
            }
            else
            {
                // Get the region for the rounded rectangle based on pictureBox1 width
                GraphicsPath roundedPath = RoundedRectangleRight(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, cornerRadius);
                Region roundedRegion = new Region(roundedPath);

                // Apply the rounded region to the PictureBox
                pictureBox.Region = roundedRegion;
            }
        }

        private GraphicsPath RoundedRectangleLeft(float width, float height, float cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            float radius = cornerRadius * 2;
            SizeF size = new SizeF(radius, radius);
            RectangleF arc = new RectangleF(PointF.Empty, size);

            // Add left top arc
            path.AddArc(arc, 180, 90);

            // Calculate the location for the left bottom arc
            arc.Y = height - radius;
            path.AddLine(0, cornerRadius, 0, height - cornerRadius);

            // Add left bottom arc
            path.AddArc(arc, 90, 90);
            path.AddLine(cornerRadius, height, width, height);
            path.AddLine(width, height, width, 0);
            path.AddLine(width, 0, cornerRadius, 0);


            // Close the figure
            path.CloseFigure();

            return path;
        }
        private GraphicsPath RoundedRectangleRight(float width, float height, float cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            float radius = cornerRadius * 2;
            SizeF size = new SizeF(radius, radius);
            RectangleF arc = new RectangleF(PointF.Empty, size);

            path.AddLine(0, 0, 0, height);
            path.AddLine(0, height, width-cornerRadius, height);
            arc.Y = height - radius;
            arc.X = width-radius;
            path.AddArc(arc, 0, 90);
            path.AddLine(width, height-cornerRadius, width, cornerRadius);
            arc.X = width-radius;
            arc.Y = 0;
            path.AddArc(arc, 270, 90);
            path.AddLine(width-cornerRadius, 0, 0, 0);


            // Close the figure
            path.CloseFigure();

            return path;
        }

        #endregion
    }
}