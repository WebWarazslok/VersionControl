namespace HCC_Proba
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            myProgressBar1 = new myProgressBar();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.logo1simple_l;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 408);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 445);
            label1.Name = "label1";
            label1.Size = new Size(323, 48);
            label1.TabIndex = 2;
            label1.Text = "Kártya generálása...";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // myProgressBar1
            // 
            myProgressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myProgressBar1.BackColor = Color.DimGray;
            myProgressBar1.ForeColor = Color.Red;
            myProgressBar1.Location = new Point(17, 513);
            myProgressBar1.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            myProgressBar1.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            myProgressBar1.Name = "myProgressBar1";
            myProgressBar1.Size = new Size(514, 34);
            myProgressBar1.TabIndex = 3;
            myProgressBar1.Text = "myProgressBar1";
            myProgressBar1.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(454, 445);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(68, 48);
            label2.TabIndex = 4;
            label2.Text = "0%";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(549, 559);
            Controls.Add(label2);
            Controls.Add(myProgressBar1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private myProgressBar myProgressBar1;
        private Label label2;
    }
}