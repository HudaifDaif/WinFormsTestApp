namespace TrackerUI
{
    partial class CreatePrizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            PlaceNumberText = new TextBox();
            placeNumberLabel = new Label();
            prizePercentageText = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountText = new TextBox();
            prizeAmountLabel = new Label();
            placeNameText = new TextBox();
            placeNameLabel = new Label();
            orLabel = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22.2F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(91, 34);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(217, 50);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Create Prize";
            // 
            // PlaceNumberText
            // 
            PlaceNumberText.Location = new Point(440, 114);
            PlaceNumberText.Name = "PlaceNumberText";
            PlaceNumberText.Size = new Size(345, 43);
            PlaceNumberText.TabIndex = 14;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(91, 116);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(211, 41);
            placeNumberLabel.TabIndex = 13;
            placeNumberLabel.Text = "Place Number:";
            // 
            // prizePercentageText
            // 
            prizePercentageText.Location = new Point(440, 394);
            prizePercentageText.Name = "prizePercentageText";
            prizePercentageText.Size = new Size(345, 43);
            prizePercentageText.TabIndex = 16;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(91, 396);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(245, 41);
            prizePercentageLabel.TabIndex = 15;
            prizePercentageLabel.Text = "Prize Percentage:";
            // 
            // prizeAmountText
            // 
            prizeAmountText.Location = new Point(440, 248);
            prizeAmountText.Name = "prizeAmountText";
            prizeAmountText.Size = new Size(345, 43);
            prizeAmountText.TabIndex = 18;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(91, 250);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(204, 41);
            prizeAmountLabel.TabIndex = 17;
            prizeAmountLabel.Text = "Prize Amount:";
            // 
            // placeNameText
            // 
            placeNameText.Location = new Point(440, 181);
            placeNameText.Name = "placeNameText";
            placeNameText.Size = new Size(345, 43);
            placeNameText.TabIndex = 20;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(91, 183);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(181, 41);
            placeNameLabel.TabIndex = 19;
            placeNameLabel.Text = "Place Name:";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(348, 315);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(86, 41);
            orLabel.TabIndex = 21;
            orLabel.Text = "- or -";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.BackColor = Color.PowderBlue;
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Location = new Point(355, 534);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(171, 115);
            CreatePrizeButton.TabIndex = 24;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(908, 745);
            Controls.Add(CreatePrizeButton);
            Controls.Add(orLabel);
            Controls.Add(placeNameText);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountText);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizePercentageText);
            Controls.Add(prizePercentageLabel);
            Controls.Add(PlaceNumberText);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreatePrizeForm";
            Text = "CreatePrize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox PlaceNumberText;
        private Label placeNumberLabel;
        private TextBox prizePercentageText;
        private Label prizePercentageLabel;
        private TextBox prizeAmountText;
        private Label prizeAmountLabel;
        private TextBox placeNameText;
        private Label placeNameLabel;
        private Label orLabel;
        private Button CreatePrizeButton;
    }
}