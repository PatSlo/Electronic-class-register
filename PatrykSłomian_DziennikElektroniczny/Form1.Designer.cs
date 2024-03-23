namespace PatrykSłomian_DziennikElektroniczny
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            userControl11 = new UserControl1();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            userControl21 = new UserControl2();
            buttonView = new Button();
            view1 = new View();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(85, 48);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(139, 37);
            button2.TabIndex = 2;
            button2.Text = "Uczeń";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(85, 108);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(139, 37);
            button3.TabIndex = 3;
            button3.Text = "Nauczyciel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // userControl11
            // 
            userControl11.Location = new Point(14, 255);
            userControl11.Margin = new Padding(3, 5, 3, 5);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(917, 1089);
            userControl11.TabIndex = 4;
            // 
            // userControl21
            // 
            userControl21.AutoScroll = true;
            userControl21.Location = new Point(26, 229);
            userControl21.Margin = new Padding(3, 5, 3, 5);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(917, 1051);
            userControl21.TabIndex = 5;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(51, 189);
            buttonView.Margin = new Padding(3, 4, 3, 4);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(211, 31);
            buttonView.TabIndex = 6;
            buttonView.Text = "Przeglądaj osoby na liście";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // view1
            // 
            view1.Location = new Point(14, 255);
            view1.Margin = new Padding(3, 5, 3, 5);
            view1.Name = "view1";
            view1.Size = new Size(938, 809);
            view1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(317, 300);
            Controls.Add(view1);
            Controls.Add(buttonView);
            Controls.Add(userControl21);
            Controls.Add(userControl11);
            Controls.Add(button3);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private UserControl1 userControl11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControl2 userControl21;
        private Button buttonView;
        private View view1;
    }
}