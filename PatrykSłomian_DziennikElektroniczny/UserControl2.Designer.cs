namespace PatrykSłomian_DziennikElektroniczny
{
    partial class UserControl2
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            textBoxPostcard = new MaskedTextBox();
            textBoxPESEL = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label13 = new Label();
            textBoxSalary = new TextBox();
            label12 = new Label();
            label1 = new Label();
            label11 = new Label();
            textBoxFirstName = new TextBox();
            label10 = new Label();
            textBoxName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBoxSex = new TextBox();
            label7 = new Label();
            textBoxCity = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBoxStreet = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            textBoxDegree = new TextBox();
            label3 = new Label();
            textBoxSubject = new TextBox();
            label2 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            buttonFill = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGoldenrod;
            button1.Location = new Point(279, 470);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 39);
            button1.TabIndex = 39;
            button1.Text = "Utwórz i wyświetl obiekt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Beige;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(121, 532);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(551, 484);
            listBox1.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(textBoxPostcard);
            panel1.Controls.Add(textBoxPESEL);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker4);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBoxSalary);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBoxFirstName);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxSex);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxCity);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxStreet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxDegree);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxSubject);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 359);
            panel1.TabIndex = 37;
            // 
            // textBoxPostcard
            // 
            textBoxPostcard.Location = new Point(457, 108);
            textBoxPostcard.Margin = new Padding(3, 4, 3, 4);
            textBoxPostcard.Mask = "00-000";
            textBoxPostcard.Name = "textBoxPostcard";
            textBoxPostcard.Size = new Size(125, 27);
            textBoxPostcard.TabIndex = 35;
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(51, 54);
            textBoxPESEL.Margin = new Padding(3, 4, 3, 4);
            textBoxPESEL.Mask = "00000000000";
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(179, 27);
            textBoxPESEL.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(535, 219);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 126);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(388, 219);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(141, 40);
            button2.TabIndex = 32;
            button2.Text = "Wybierz zdjęcie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(144, 309);
            dateTimePicker4.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(228, 27);
            dateTimePicker4.TabIndex = 31;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(629, 9);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(244, 27);
            dateTimePicker3.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 309);
            label13.Name = "label13";
            label13.Size = new Size(134, 20);
            label13.TabIndex = 29;
            label13.Text = "Data zatrudnienia :";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(70, 257);
            textBoxSalary.Margin = new Padding(3, 4, 3, 4);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(114, 27);
            textBoxSalary.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 257);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 27;
            label12.Text = "Zarobki";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 14;
            label1.Text = "Imię :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 210);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 26;
            label11.Text = "Przedmiot  :";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(51, 9);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(179, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(276, 164);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 25;
            label10.Text = "Stopień naukowy :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(317, 9);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(179, 27);
            textBoxName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 160);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 24;
            label9.Text = "E-mail :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(590, 115);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 23;
            label8.Text = "Ulica :";
            // 
            // textBoxSex
            // 
            textBoxSex.Location = new Point(317, 61);
            textBoxSex.Margin = new Padding(3, 4, 3, 4);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.Size = new Size(179, 27);
            textBoxSex.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(340, 115);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 22;
            label7.Text = "Kod pocztowy :";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(164, 108);
            textBoxCity.Margin = new Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(179, 27);
            textBoxCity.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 111);
            label6.Name = "label6";
            label6.Size = new Size(158, 20);
            label6.TabIndex = 21;
            label6.Text = "Miejsce zamieszkania :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 64);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 20;
            label5.Text = "Płeć :";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(645, 108);
            textBoxStreet.Margin = new Padding(3, 4, 3, 4);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(179, 27);
            textBoxStreet.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 61);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 19;
            label4.Text = "PESEL :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(69, 157);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(179, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxDegree
            // 
            textBoxDegree.Location = new Point(411, 161);
            textBoxDegree.Margin = new Padding(3, 4, 3, 4);
            textBoxDegree.Name = "textBoxDegree";
            textBoxDegree.Size = new Size(179, 27);
            textBoxDegree.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 13);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 17;
            label3.Text = "Data urodzenia :";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(97, 207);
            textBoxSubject.Margin = new Padding(3, 4, 3, 4);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(179, 27);
            textBoxSubject.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 17);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 15;
            label2.Text = "Nazwisko :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Algerian", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(7, 11);
            label14.Name = "label14";
            label14.Size = new Size(826, 46);
            label14.TabIndex = 40;
            label14.Text = "Wprowadzanie danych : nauczyciel";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(705, 532);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 176);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonFill
            // 
            buttonFill.BackColor = Color.Honeydew;
            buttonFill.ForeColor = Color.Black;
            buttonFill.Location = new Point(0, 446);
            buttonFill.Margin = new Padding(3, 4, 3, 4);
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(122, 31);
            buttonFill.TabIndex = 42;
            buttonFill.Text = "Uzupełnij";
            buttonFill.UseVisualStyleBackColor = false;
            buttonFill.Click += buttonFill_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(buttonFill);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl2";
            Size = new Size(927, 1052);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Panel panel1;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Label label13;
        private TextBox textBoxSalary;
        private Label label12;
        private Label label1;
        private Label label11;
        private TextBox textBoxFirstName;
        private Label label10;
        private TextBox textBoxName;
        private Label label9;
        private Label label8;
        private TextBox textBoxSex;
        private Label label7;
        private TextBox textBoxCity;
        private Label label6;
        private Label label5;
        private TextBox textBoxStreet;
        private Label label4;
        private TextBox textBoxEmail;
        private TextBox textBoxDegree;
        private Label label3;
        private TextBox textBoxSubject;
        private Label label2;
        private Label label14;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private MaskedTextBox textBoxPostcard;
        private MaskedTextBox textBoxPESEL;
        private Button buttonFill;
    }
}
