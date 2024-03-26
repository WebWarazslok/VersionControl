using System.ComponentModel;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.FullName; // label1
            button1.Text = Resource1.Add; // button1
            button2.Text = Resource1.CopyToFile; // button2

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = Resource1.CopyToFile;
            // Megnyitjuk a kiválasztott fájlt a StreamWriter segítségével
            using (StreamWriter sw = new StreamWriter("Nevek.txt"))
            {
                // Az összes elemen végigmegyünk a ListBox-ban és minden sort kiírunk a fájlba
                int i = 1;
                foreach (var item in users)
                {
                    sw.WriteLine($"{i}. {item.FullName.ToString()}");
                    i++;                
                }
            }
            MessageBox.Show("A ListBox tartalma sikeresen el lett mentve a fájlba.");
        }

    }
}