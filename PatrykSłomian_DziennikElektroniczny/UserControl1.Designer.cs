namespace PatrykSłomian_DziennikElektroniczny
{
    partial class UserControl1
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
            panel3 = new Panel();
            comboBox4 = new ComboBox();
            button3 = new Button();
            label13 = new Label();
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            label12 = new Label();
            panel1 = new Panel();
            textBoxPostcard = new MaskedTextBox();
            textBoxPESEL = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
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
            textBoxStCLass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            label15 = new Label();
            maskedTextGrades1 = new MaskedTextBox();
            buttonFill = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGoldenrod;
            button1.Location = new Point(318, 515);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 31);
            button1.TabIndex = 36;
            button1.Text = "Utwórz i wyświetl obiekt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Beige;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(34, 564);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(664, 484);
            listBox1.TabIndex = 35;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Beige;
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(220, 361);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 125);
            panel3.TabIndex = 34;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Tak", "Nie" });
            comboBox4.Location = new Point(21, 64);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(138, 28);
            comboBox4.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(221, 94);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 41;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 24);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 0;
            label13.Text = "Autobus :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(15, 361);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 125);
            panel2.TabIndex = 33;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Tak", "Nie" });
            comboBox3.Location = new Point(19, 68);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(145, 28);
            comboBox3.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(49, 28);
            label12.Name = "label12";
            label12.Size = new Size(106, 20);
            label12.TabIndex = 0;
            label12.Text = "Opinia ucznia :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(textBoxPostcard);
            panel1.Controls.Add(textBoxPESEL);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
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
            panel1.Controls.Add(textBoxStCLass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 56);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 307);
            panel1.TabIndex = 32;
            // 
            // textBoxPostcard
            // 
            textBoxPostcard.Location = new Point(759, 88);
            textBoxPostcard.Margin = new Padding(3, 4, 3, 4);
            textBoxPostcard.Mask = "00-000";
            textBoxPostcard.Name = "textBoxPostcard";
            textBoxPostcard.Size = new Size(114, 27);
            textBoxPostcard.TabIndex = 32;
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(64, 43);
            textBoxPESEL.Margin = new Padding(3, 4, 3, 4);
            textBoxPESEL.Mask = "00000000000";
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(183, 27);
            textBoxPESEL.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(410, 166);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 127);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(291, 175);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 29;
            button2.Text = "Wybierz zdjęcie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Wzorowe", "Bardzo dobre", "Dobre", "Poprawne", "Nieodpowiednie", "Naganne" });
            comboBox1.Location = new Point(108, 225);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 28);
            comboBox1.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(659, 8);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 14;
            label1.Text = "Imię :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(0, 228);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 26;
            label11.Text = "Zachowanie :";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(64, 8);
            textBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(179, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 175);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 25;
            label10.Text = "Klasa :";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(331, 10);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(179, 27);
            textBoxName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 139);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 24;
            label9.Text = "E-mail :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 95);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 23;
            label8.Text = "Ulica :";
            // 
            // textBoxSex
            // 
            textBoxSex.Location = new Point(331, 45);
            textBoxSex.Margin = new Padding(3, 4, 3, 4);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.Size = new Size(179, 27);
            textBoxSex.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 95);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 22;
            label7.Text = "Kod pocztowy :";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(170, 88);
            textBoxCity.Margin = new Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(179, 27);
            textBoxCity.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 95);
            label6.Name = "label6";
            label6.Size = new Size(158, 20);
            label6.TabIndex = 21;
            label6.Text = "Miejsce zamieszkania :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 52);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 20;
            label5.Text = "Płeć :";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(425, 88);
            textBoxStreet.Margin = new Padding(3, 4, 3, 4);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(179, 27);
            textBoxStreet.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 19;
            label4.Text = "PESEL :";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(71, 136);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(179, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxStCLass
            // 
            textBoxStCLass.Location = new Point(71, 175);
            textBoxStCLass.Margin = new Padding(3, 4, 3, 4);
            textBoxStCLass.Name = "textBoxStCLass";
            textBoxStCLass.Size = new Size(179, 27);
            textBoxStCLass.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 13);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 17;
            label3.Text = "Data urodzenia :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 13);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 15;
            label2.Text = "Nazwisko :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Algerian", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(15, 6);
            label14.Name = "label14";
            label14.Size = new Size(702, 46);
            label14.TabIndex = 37;
            label14.Text = "Wprowadzanie danych : uczen";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(704, 564);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 199);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(462, 377);
            label15.Name = "label15";
            label15.Size = new Size(50, 20);
            label15.TabIndex = 39;
            label15.Text = "Oceny";
            // 
            // maskedTextGrades1
            // 
            maskedTextGrades1.Location = new Point(421, 401);
            maskedTextGrades1.Margin = new Padding(3, 4, 3, 4);
            maskedTextGrades1.Mask = "0.9";
            maskedTextGrades1.Name = "maskedTextGrades1";
            maskedTextGrades1.Size = new Size(124, 27);
            maskedTextGrades1.TabIndex = 40;
            // 
            // buttonFill
            // 
            buttonFill.BackColor = Color.Honeydew;
            buttonFill.Location = new Point(15, 515);
            buttonFill.Margin = new Padding(3, 4, 3, 4);
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(119, 31);
            buttonFill.TabIndex = 42;
            buttonFill.Text = "Uzupełnij";
            buttonFill.UseVisualStyleBackColor = false;
            buttonFill.Click += buttonFill_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonFill);
            Controls.Add(maskedTextGrades1);
            Controls.Add(label15);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(917, 1145);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel3;
        private ComboBox comboBox4;
        private Label label13;
        private Panel panel2;
        private ComboBox comboBox3;
        private Label label12;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
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
        private TextBox textBoxStCLass;
        private Label label3;
        private Label label2;
        private Label label14;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label15;
        private MaskedTextBox textBoxPostcard;
        private MaskedTextBox textBoxPESEL;
        private MaskedTextBox maskedTextGrades1;
        private Button button3;
        private Button buttonFill;
    }
}
