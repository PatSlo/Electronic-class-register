using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrykSłomian_DziennikElektroniczny
{
    public partial class UserControl2 : UserControl
    {
        private Teacher _teacher1;
        public UserControl2()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _teacher1 = new Teacher(textBoxFirstName.Text, textBoxName.Text, Convert.ToDateTime(dateTimePicker3.Value),
                textBoxPESEL.Text, textBoxCity.Text, textBoxPostcard.Text, textBoxStreet.Text, textBoxSex.Text,
                textBoxEmail.Text, textBoxDegree.Text, textBoxSubject.Text, Convert.ToDouble(textBoxSalary.Text),
                Convert.ToDateTime(dateTimePicker4.Value), (Bitmap)pictureBox2.Image);
            WriteInfo(_teacher1);
            pictureBox1.Image = _teacher1.Photo;

            string compare1 = "";
            string compare2 = "";
            if (Form1.listP.Count() == 0)
                compare1 = "Utworzono nowego nauczyciela";
            foreach (var item in Form1.listP)
            {
                compare1 = _teacher1 != item;
                compare2 = _teacher1 == item;

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
                Form1.listP.Add(_teacher1);
            }

            
        }


        private void WriteInfo(Teacher t)
        {
            List<string> info2 = t.GetInfo();
            foreach (var teacher in info2)
            {
                listBox1.Items.Add(teacher);
            }
            listBox1.Items.Add("");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap f = new Bitmap(openFileDialog1.OpenFile());
                pictureBox2.Image = f;
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "Jadwiga";
            textBoxName.Text = "Einstein";
            textBoxPESEL.Text = "93125694091";
            textBoxCity.Text = "Opole";
            textBoxPostcard.Text = "52-500";
            textBoxStreet.Text = "Solidarnośći";
            textBoxSex.Text = "Kobieta";
            textBoxEmail.Text = "einstein@gmail.com";
            textBoxDegree.Text = "dr hab.";
            textBoxSubject.Text = "Matematyka";
            textBoxSalary.Text = "1950";
            dateTimePicker3.Value = new DateTime(1989, 12, 25);
            dateTimePicker4.Value = new DateTime(2010, 6, 6);
            pictureBox2.ImageLocation = @".\teacher1.jpeg";
        }
    }
}
