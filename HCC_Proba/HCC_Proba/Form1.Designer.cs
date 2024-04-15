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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(728, 411);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(771, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(771, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(771, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 27);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(839, 262);
            button1.Name = "button1";
            button1.Size = new Size(127, 61);
            button1.TabIndex = 6;
            button1.Text = "Kártya hozzáadása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(825, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 7;
            label1.Text = "Kártyatulajdonos neve:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(839, 91);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 8;
            label2.Text = "Vevő e-mail címe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(825, 188);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 9;
            label3.Text = "Felhasználható összeg:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 447);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Ajándékkártya vásárlás";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}