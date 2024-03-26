namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.LastName; // label1
            label2.Text = Resource1.FirstName; // label2
            button1.Text = Resource1.Add; // button1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}