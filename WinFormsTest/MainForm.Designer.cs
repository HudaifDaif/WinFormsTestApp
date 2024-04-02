namespace WinFormsTest
{
    partial class MainForm
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
            FirstNameText = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            LastNameText = new TextBox();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(506, 498);
            SubmitButton.Margin = new Padding(5);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(153, 45);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Say Hi!";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(523, 57);
            FirstNameText.Margin = new Padding(5);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(201, 38);
            FirstNameText.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(361, 62);
            FirstNameLabel.Margin = new Padding(5, 0, 5, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(124, 31);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(361, 163);
            LastNameLabel.Margin = new Padding(5, 0, 5, 0);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(122, 31);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(523, 158);
            LastNameText.Margin = new Padding(5);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(201, 38);
            LastNameText.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 666);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameLabel);
            Controls.Add(FirstNameText);
            Controls.Add(SubmitButton);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Hello User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private TextBox FirstNameText;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private TextBox LastNameText;
    }
}
