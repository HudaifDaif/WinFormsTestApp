namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            loadExistingTournamentDropdown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22.2F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(283, 34);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(343, 50);
            headerLabel.TabIndex = 13;
            headerLabel.Text = "Tournament Tracker";
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(187, 197);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(534, 28);
            loadExistingTournamentDropdown.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadExistingTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingTournamentLabel.Location = new Point(271, 153);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(366, 41);
            loadExistingTournamentLabel.TabIndex = 19;
            loadExistingTournamentLabel.Text = "Load Existing Tournament:";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.BackColor = Color.PowderBlue;
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Location = new Point(313, 258);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(282, 50);
            loadTournamentButton.TabIndex = 21;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = Color.PowderBlue;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            createTournamentButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Location = new Point(369, 417);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(171, 115);
            createTournamentButton.TabIndex = 22;
            createTournamentButton.Text = "Create Tournament:";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(908, 583);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(headerLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropdown;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}