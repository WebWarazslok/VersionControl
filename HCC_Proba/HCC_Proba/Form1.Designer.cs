namespace HCC_Proba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_cardName = new Label();
            pictureBox1 = new PictureBox();
            lbl_web = new Label();
            lbl_amount = new Label();
            roundedPanel1 = new myPanel.pnlRounded.RoundedPanel();
            lbl_NevName = new Label();
            roundedPanel4 = new myPanel.pnlRounded.RoundedPanel();
            lbl_nev = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lbl_kod = new Label();
            lbl_erv = new Label();
            lbl_kodName = new Label();
            lbl_ervName = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            roundedPanel3 = new myPanel.pnlRounded.RoundedPanel();
            roundedPanel6 = new myPanel.pnlRounded.RoundedPanel();
            roundedPanel2 = new myPanel.pnlRounded.RoundedPanel();
            roundedPanel5 = new myPanel.pnlRounded.RoundedPanel();
            pictureBox2 = new PictureBox();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            button1 = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(763, 299);
            textBox1.Margin = new Padding(5, 3, 5, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 28);
            textBox1.TabIndex = 2;
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DimGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(763, 345);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 28);
            textBox2.TabIndex = 3;
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(763, 389);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 28);
            textBox3.TabIndex = 4;
            textBox3.UseWaitCursor = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(688, 299);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 7;
            label1.Text = "Név:";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(628, 345);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 8;
            label2.Text = "E-mail cím:";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(658, 386);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 9;
            label3.Text = "Összeg:";
            label3.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lbl_cardName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_web);
            panel1.Controls.Add(lbl_amount);
            panel1.Controls.Add(roundedPanel1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 363);
            panel1.TabIndex = 10;
            panel1.UseWaitCursor = true;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.logo1simple_l;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(477, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 80);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // lbl_cardName
            // 
            lbl_cardName.Font = new Font("Britannic Bold", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cardName.ForeColor = Color.DarkRed;
            lbl_cardName.Location = new Point(103, 92);
            lbl_cardName.Name = "lbl_cardName";
            lbl_cardName.Size = new Size(432, 71);
            lbl_cardName.TabIndex = 3;
            lbl_cardName.Text = "Ajándékkártya";
            lbl_cardName.TextAlign = ContentAlignment.MiddleRight;
            lbl_cardName.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.előlap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 357);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // lbl_web
            // 
            lbl_web.AutoSize = true;
            lbl_web.Location = new Point(420, 334);
            lbl_web.Name = "lbl_web";
            lbl_web.Size = new Size(115, 15);
            lbl_web.TabIndex = 2;
            lbl_web.Text = "www.zamatzug.com";
            lbl_web.UseWaitCursor = true;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Font = new Font("Britannic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_amount.Location = new Point(241, 171);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.RightToLeft = RightToLeft.No;
            lbl_amount.Size = new Size(132, 41);
            lbl_amount.TabIndex = 1;
            lbl_amount.Text = "Összeg";
            lbl_amount.TextAlign = ContentAlignment.MiddleRight;
            lbl_amount.UseWaitCursor = true;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Silver;
            roundedPanel1.Controls.Add(lbl_NevName);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.Location = new Point(238, 243);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(297, 45);
            roundedPanel1.TabIndex = 6;
            roundedPanel1.UseWaitCursor = true;
            // 
            // lbl_NevName
            // 
            lbl_NevName.BackColor = Color.Silver;
            lbl_NevName.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NevName.ForeColor = Color.Black;
            lbl_NevName.Location = new Point(3, 10);
            lbl_NevName.Name = "lbl_NevName";
            lbl_NevName.Size = new Size(66, 25);
            lbl_NevName.TabIndex = 4;
            lbl_NevName.Text = "Név:";
            lbl_NevName.UseWaitCursor = true;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(lbl_nev);
            roundedPanel4.CornerRadius = 20;
            roundedPanel4.Location = new Point(75, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(219, 39);
            roundedPanel4.TabIndex = 8;
            roundedPanel4.UseWaitCursor = true;
            // 
            // lbl_nev
            // 
            lbl_nev.AutoSize = true;
            lbl_nev.BackColor = Color.White;
            lbl_nev.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nev.ForeColor = Color.DarkRed;
            lbl_nev.Location = new Point(12, 8);
            lbl_nev.Name = "lbl_nev";
            lbl_nev.Size = new Size(48, 25);
            lbl_nev.TabIndex = 0;
            lbl_nev.Text = "Név";
            lbl_nev.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DimGray;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(763, 434);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 28);
            textBox4.TabIndex = 13;
            textBox4.UseWaitCursor = true;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Black;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(763, 480);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(294, 35);
            textBox5.TabIndex = 14;
            textBox5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(690, 432);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 5;
            label4.Text = "Kód:";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(644, 480);
            label5.Name = "label5";
            label5.Size = new Size(99, 30);
            label5.TabIndex = 5;
            label5.Text = "Érvényes:";
            label5.UseWaitCursor = true;
            // 
            // lbl_kod
            // 
            lbl_kod.AutoSize = true;
            lbl_kod.BackColor = Color.White;
            lbl_kod.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kod.ForeColor = Color.Black;
            lbl_kod.Location = new Point(91, 7);
            lbl_kod.Name = "lbl_kod";
            lbl_kod.RightToLeft = RightToLeft.No;
            lbl_kod.Size = new Size(48, 30);
            lbl_kod.TabIndex = 1;
            lbl_kod.Text = "Kód";
            lbl_kod.UseWaitCursor = true;
            // 
            // lbl_erv
            // 
            lbl_erv.AutoSize = true;
            lbl_erv.BackColor = Color.White;
            lbl_erv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_erv.ForeColor = Color.Black;
            lbl_erv.Location = new Point(176, 8);
            lbl_erv.Name = "lbl_erv";
            lbl_erv.RightToLeft = RightToLeft.Yes;
            lbl_erv.Size = new Size(94, 30);
            lbl_erv.TabIndex = 2;
            lbl_erv.Text = "Érvényes";
            lbl_erv.UseWaitCursor = true;
            // 
            // lbl_kodName
            // 
            lbl_kodName.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_kodName.ForeColor = Color.Black;
            lbl_kodName.Location = new Point(3, 10);
            lbl_kodName.Name = "lbl_kodName";
            lbl_kodName.Size = new Size(65, 25);
            lbl_kodName.TabIndex = 3;
            lbl_kodName.Text = "Kód:";
            lbl_kodName.UseWaitCursor = true;
            // 
            // lbl_ervName
            // 
            lbl_ervName.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ervName.ForeColor = Color.Black;
            lbl_ervName.Location = new Point(3, 11);
            lbl_ervName.Name = "lbl_ervName";
            lbl_ervName.Size = new Size(127, 25);
            lbl_ervName.TabIndex = 4;
            lbl_ervName.Text = "Érvényes:";
            lbl_ervName.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(roundedPanel3);
            panel2.Controls.Add(roundedPanel2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(10, 386);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(568, 363);
            panel2.TabIndex = 11;
            panel2.UseWaitCursor = true;
            panel2.Paint += panel2_Paint;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(18, 241);
            label9.Name = "label9";
            label9.Size = new Size(264, 21);
            label9.TabIndex = 12;
            label9.Text = "◦ A kód csak egyszer használható fel!\r\n";
            label9.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 199);
            label8.Name = "label8";
            label8.Size = new Size(333, 42);
            label8.TabIndex = 11;
            label8.Text = "◦ A vezetőség fenntartja a jogot a kedvezmény \r\n  módosítására vagy visszavonására";
            label8.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 178);
            label7.Name = "label7";
            label7.Size = new Size(339, 21);
            label7.TabIndex = 10;
            label7.Text = "◦ Meghatározott időpontra és boxokra érvényes\r\n";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 157);
            label6.Name = "label6";
            label6.Size = new Size(333, 21);
            label6.TabIndex = 9;
            label6.Text = "◦ Nem használható felkedvezményekkel együtt";
            label6.UseWaitCursor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.logo1simple_l;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(12, 273);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.UseWaitCursor = true;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Silver;
            roundedPanel3.Controls.Add(lbl_erv);
            roundedPanel3.Controls.Add(lbl_ervName);
            roundedPanel3.Controls.Add(roundedPanel6);
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.Location = new Point(37, 80);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(297, 45);
            roundedPanel3.TabIndex = 8;
            roundedPanel3.UseWaitCursor = true;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.White;
            roundedPanel6.CornerRadius = 20;
            roundedPanel6.Location = new Point(136, 3);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(157, 39);
            roundedPanel6.TabIndex = 10;
            roundedPanel6.UseWaitCursor = true;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Silver;
            roundedPanel2.Controls.Add(lbl_kod);
            roundedPanel2.Controls.Add(lbl_kodName);
            roundedPanel2.Controls.Add(roundedPanel5);
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.Location = new Point(37, 29);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(297, 45);
            roundedPanel2.TabIndex = 7;
            roundedPanel2.UseWaitCursor = true;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.CornerRadius = 20;
            roundedPanel5.Location = new Point(74, 3);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(219, 39);
            roundedPanel5.TabIndex = 9;
            roundedPanel5.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.hatulja;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(370, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 357);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // button_woc1
            // 
            button_woc1.BackColor = Color.Black;
            button_woc1.BorderColor = Color.Transparent;
            button_woc1.ButtonColor = Color.DarkRed;
            button_woc1.FlatAppearance.BorderSize = 0;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_woc1.ForeColor = Color.Transparent;
            button_woc1.Location = new Point(818, 533);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.Transparent;
            button_woc1.OnHoverButtonColor = Color.Firebrick;
            button_woc1.OnHoverTextColor = Color.White;
            button_woc1.Size = new Size(239, 52);
            button_woc1.TabIndex = 15;
            button_woc1.Text = "Nyomtatás";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = false;
            button_woc1.UseWaitCursor = true;
            button_woc1.Click += button_woc1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1106, 0);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(45, 45);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(628, 204);
            label10.Name = "label10";
            label10.Size = new Size(429, 83);
            label10.TabIndex = 17;
            label10.Text = "Beviteli mezők:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1147, 760);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(button_woc1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Ajándékkártya vásárlás";
            UseWaitCursor = true;
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lbl_nev;
        private Label lbl_NevName;
        private Label lbl_cardName;
        private Label lbl_web;
        private Label lbl_amount;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label lbl_ervName;
        private Label lbl_kodName;
        private Label lbl_erv;
        private Label lbl_kod;
        private Panel panel2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private myPanel.pnlRounded.RoundedPanel roundedPanel1;
        private myPanel.pnlRounded.RoundedPanel roundedPanel2;
        private myPanel.pnlRounded.RoundedPanel roundedPanel3;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox4;
        private myPanel.pnlRounded.RoundedPanel roundedPanel4;
        private Label label9;
        private myPanel.pnlRounded.RoundedPanel roundedPanel5;
        private myPanel.pnlRounded.RoundedPanel roundedPanel6;
        private Label label10;
    }
}