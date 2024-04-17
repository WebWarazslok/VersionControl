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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lbl_NevName = new Label();
            lbl_cardName = new Label();
            lbl_web = new Label();
            lbl_amount = new Label();
            lbl_nev = new Label();
            panel2 = new Panel();
            lbl_ervName = new Label();
            lbl_kodName = new Label();
            lbl_erv = new Label();
            lbl_kod = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(673, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 2;
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(673, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 27);
            textBox2.TabIndex = 3;
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(673, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 27);
            textBox3.TabIndex = 4;
            textBox3.UseWaitCursor = true;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(682, 376);
            button1.Name = "button1";
            button1.Size = new Size(127, 61);
            button1.TabIndex = 6;
            button1.Text = "Nyomtatás";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(584, 137);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 7;
            label1.Text = "Név:";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(584, 187);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "E-mail cím:";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(584, 230);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "Összeg";
            label3.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_NevName);
            panel1.Controls.Add(lbl_cardName);
            panel1.Controls.Add(lbl_web);
            panel1.Controls.Add(lbl_amount);
            panel1.Controls.Add(lbl_nev);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 250);
            panel1.TabIndex = 10;
            panel1.UseWaitCursor = true;
            // 
            // lbl_NevName
            // 
            lbl_NevName.AutoSize = true;
            lbl_NevName.Location = new Point(127, 180);
            lbl_NevName.Name = "lbl_NevName";
            lbl_NevName.Size = new Size(38, 20);
            lbl_NevName.TabIndex = 4;
            lbl_NevName.Text = "Név:";
            lbl_NevName.UseWaitCursor = true;
            // 
            // lbl_cardName
            // 
            lbl_cardName.AutoSize = true;
            lbl_cardName.Location = new Point(214, 74);
            lbl_cardName.Name = "lbl_cardName";
            lbl_cardName.Size = new Size(103, 20);
            lbl_cardName.TabIndex = 3;
            lbl_cardName.Text = "Ajándékkártya";
            lbl_cardName.UseWaitCursor = true;
            // 
            // lbl_web
            // 
            lbl_web.AutoSize = true;
            lbl_web.Location = new Point(395, 220);
            lbl_web.Name = "lbl_web";
            lbl_web.Size = new Size(142, 20);
            lbl_web.TabIndex = 2;
            lbl_web.Text = "www.zamatzug.com";
            lbl_web.UseWaitCursor = true;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new Point(234, 133);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(56, 20);
            lbl_amount.TabIndex = 1;
            lbl_amount.Text = "Összeg";
            lbl_amount.UseWaitCursor = true;
            // 
            // lbl_nev
            // 
            lbl_nev.AutoSize = true;
            lbl_nev.Location = new Point(244, 180);
            lbl_nev.Name = "lbl_nev";
            lbl_nev.Size = new Size(35, 20);
            lbl_nev.TabIndex = 0;
            lbl_nev.Text = "Név";
            lbl_nev.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_ervName);
            panel2.Controls.Add(lbl_kodName);
            panel2.Controls.Add(lbl_erv);
            panel2.Controls.Add(lbl_kod);
            panel2.Location = new Point(12, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 250);
            panel2.TabIndex = 11;
            panel2.UseWaitCursor = true;
            // 
            // lbl_ervName
            // 
            lbl_ervName.AutoSize = true;
            lbl_ervName.Location = new Point(43, 88);
            lbl_ervName.Name = "lbl_ervName";
            lbl_ervName.Size = new Size(69, 20);
            lbl_ervName.TabIndex = 4;
            lbl_ervName.Text = "Érvényes:";
            lbl_ervName.UseWaitCursor = true;
            // 
            // lbl_kodName
            // 
            lbl_kodName.AutoSize = true;
            lbl_kodName.Location = new Point(43, 68);
            lbl_kodName.Name = "lbl_kodName";
            lbl_kodName.Size = new Size(39, 20);
            lbl_kodName.TabIndex = 3;
            lbl_kodName.Text = "Kód:";
            lbl_kodName.UseWaitCursor = true;
            // 
            // lbl_erv
            // 
            lbl_erv.AutoSize = true;
            lbl_erv.Location = new Point(115, 88);
            lbl_erv.Name = "lbl_erv";
            lbl_erv.Size = new Size(66, 20);
            lbl_erv.TabIndex = 2;
            lbl_erv.Text = "Érvényes";
            lbl_erv.UseWaitCursor = true;
            // 
            // lbl_kod
            // 
            lbl_kod.AutoSize = true;
            lbl_kod.Location = new Point(115, 68);
            lbl_kod.Name = "lbl_kod";
            lbl_kod.Size = new Size(36, 20);
            lbl_kod.TabIndex = 1;
            lbl_kod.Text = "Kód";
            lbl_kod.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(673, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 27);
            textBox4.TabIndex = 13;
            textBox4.UseWaitCursor = true;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(673, 313);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 27);
            textBox5.TabIndex = 14;
            textBox5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 277);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "Kód:";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(584, 320);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 5;
            label5.Text = "Érvényes:";
            label5.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(934, 555);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Ajándékkártya vásárlás";
            UseWaitCursor = true;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_nev;
        private Label lbl_kod;
        private Label lbl_erv;
        private Label lbl_NevName;
        private Label lbl_cardName;
        private Label lbl_web;
        private Label lbl_amount;
        private Label lbl_ervName;
        private Label lbl_kodName;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
    }
}