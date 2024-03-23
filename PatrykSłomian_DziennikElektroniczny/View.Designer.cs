namespace PatrykSłomian_DziennikElektroniczny
{
    partial class View
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
            listBox1 = new ListBox();
            buttonPrevious = new Button();
            buttonNext = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Beige;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(31, 125);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(625, 444);
            listBox1.TabIndex = 0;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = Color.PaleGoldenrod;
            buttonPrevious.ForeColor = SystemColors.ActiveCaptionText;
            buttonPrevious.Location = new Point(31, 614);
            buttonPrevious.Margin = new Padding(3, 4, 3, 4);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(138, 31);
            buttonPrevious.TabIndex = 1;
            buttonPrevious.Text = "Poprzedni";
            buttonPrevious.UseVisualStyleBackColor = false;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.PaleGoldenrod;
            buttonNext.ForeColor = SystemColors.ActiveCaptionText;
            buttonNext.Location = new Point(518, 614);
            buttonNext.Margin = new Padding(3, 4, 3, 4);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(138, 31);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Następny";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(693, 125);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 211);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(53, 29);
            label1.Name = "label1";
            label1.Size = new Size(587, 46);
            label1.TabIndex = 4;
            label1.Text = "Przegladanie listy osób";
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonNext);
            Controls.Add(buttonPrevious);
            Controls.Add(listBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "View";
            Size = new Size(938, 809);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button buttonPrevious;
        private Button buttonNext;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
