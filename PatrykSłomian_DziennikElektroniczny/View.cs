using System;
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
    public partial class View : UserControl
    {
        int _index = -1;

        public View()
        {
            InitializeComponent();
            buttonPrevious.Visible = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UpdateButtons()
        {
            if (_index == 0)
                buttonPrevious.Enabled = false;
            else
                buttonPrevious.Enabled = true;
            if (_index >= Form1.listP.Count - 1)
                buttonNext.Enabled = false;
            else
                buttonNext.Enabled = true;
            if (_index < 0)
            {
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = false;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            buttonNext.Visible = true;
            listBox1.Items.Clear();
            _index--;
            WriteInfo(Form1.listP[_index]);
            UpdateButtons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonPrevious.Visible = true;
            listBox1.Items.Clear();
            _index++;
            WriteInfo(Form1.listP[_index]);
            UpdateButtons();
        }

        private void WriteInfo(Person p)
        {
            List<string> info2 = p.GetInfo();
            foreach (var person in info2)
            {
                listBox1.Items.Add(person);
            }
            pictureBox1.Image = p.Photo;

        }
    }
}
