using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrykSłomian_DziennikElektroniczny
{
    public partial class UserControl1 : UserControl
    {
        private Student _student1;
        private List<double> _grades = new List<double>();

        public UserControl1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _student1 = new Student(textBoxFirstName.Text, textBoxName.Text, Convert.ToDateTime(dateTimePicker1.Value),
                         textBoxPESEL.Text, textBoxCity.Text, textBoxPostcard.Text, textBoxStreet.Text, textBoxSex.Text,
                         textBoxEmail.Text, textBoxStCLass.Text, comboBox3.Text, comboBox4.Text, comboBox1.Text,
                         (Bitmap)pictureBox2.Image, _grades);
            WriteInfo(_student1);
            pictureBox1.Image = _student1.Photo;
            _grades = new List<double>();

            string compare1 = "";
            string compare2 = "";
            foreach (var item in Form1.listP)
            {
                compare1 = _student1 != item;
                compare2 = _student1 == item;

                if (compare2 != "")
                {
                    listBox1.Items.Add(compare2);
                    listBox1.Items.Add("");
                    break;
                }
            }

            if (compare2 == "")
            {
                listBox1.Items.Add(compare1);
                listBox1.Items.Add("");
                Form1.listP.Add(_student1);
            }

        }

        private void WriteInfo(Student s)
        {
            List<string> info2 = s.GetInfo();
            foreach (var student in info2)
            {
                listBox1.Items.Add(student);
            }
            listBox1.Items.Add("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(openFileDialog1.OpenFile());
                pictureBox2.Image = f;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _grades.Add(Convert.ToDouble(maskedTextGrades1.Text));
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "Jan";
            textBoxName.Text = "Kowalski";
            textBoxPESEL.Text = "03125694091";
            textBoxCity.Text = "Opole";
            textBoxPostcard.Text = "52-400";
            textBoxStreet.Text = "Pużaka";
            textBoxSex.Text = "Mężczyzna";
            textBoxEmail.Text = "einstein@gmail.com";
            textBoxStCLass.Text = "4a";
            comboBox1.Text = "Bardzo dobre";
            comboBox3.Text = "Tak";
            comboBox4.Text = "Nie";
            maskedTextGrades1.Text = "5,0";
            dateTimePicker1.Value = new DateTime(2010, 12, 25);
            pictureBox2.ImageLocation = @".\student1.jpg";
        }
    }
}
