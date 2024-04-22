namespace HCC_Proba
{
    partial class Finished
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
            pictureBox1 = new PictureBox();
            button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo1simple_l;
            pictureBox1.Location = new Point(87, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_woc1
            // 
            button_woc1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_woc1.BackColor = Color.Transparent;
            button_woc1.BackgroundImageLayout = ImageLayout.None;
            button_woc1.BorderColor = Color.Transparent;
            button_woc1.ButtonColor = Color.DarkRed;
            button_woc1.FlatStyle = FlatStyle.Flat;
            button_woc1.Location = new Point(87, 359);
            button_woc1.Name = "button_woc1";
            button_woc1.OnHoverBorderColor = Color.Firebrick;
            button_woc1.OnHoverButtonColor = Color.Firebrick;
            button_woc1.OnHoverTextColor = Color.White;
            button_woc1.Size = new Size(392, 79);
            button_woc1.TabIndex = 1;
            button_woc1.Text = "Befejezés";
            button_woc1.TextColor = Color.White;
            button_woc1.UseVisualStyleBackColor = false;
            button_woc1.Click += button_woc1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 288);
            label1.Name = "label1";
            label1.Size = new Size(287, 45);
            label1.TabIndex = 2;
            label1.Text = "A kártya elkészült!";
            // 
            // Finished
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 450);
            Controls.Add(label1);
            Controls.Add(button_woc1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finished";
            Text = "Finished";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private Label label1;
    }
}