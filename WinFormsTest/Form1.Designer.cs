namespace WinFormsTest
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
            SubmitButton = new Button();
            textBox1 = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(322, 324);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Say Hi!";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(222, 40);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(222, 105);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LastNameLabel);
            Controls.Add(textBox2);
            Controls.Add(FirstNameLabel);
            Controls.Add(textBox1);
            Controls.Add(SubmitButton);
            Name = "Form1";
            Text = "Hello User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private TextBox textBox1;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private TextBox textBox2;
    }
}
