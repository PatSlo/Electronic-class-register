using System;
using System.Windows.Forms;

namespace PatrykSłomian_DziennikElektroniczny
{
    public partial class Form1 : Form
    {
        public static List<Person> listP = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            userControl11.Visible = false;
            userControl21.Visible = false;
            view1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 1000;
            userControl11.Visible = true;
            userControl21.Visible = false;
            view1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 1000;
            userControl21.Visible = true;
            userControl11.Visible = false;
            view1.Visible = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 1000;
            userControl21.Visible = false;
            userControl11.Visible = false;
            view1.Visible = true;
        }
    }
}