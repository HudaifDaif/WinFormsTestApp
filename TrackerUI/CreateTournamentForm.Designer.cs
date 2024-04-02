namespace TrackerUI
{
    partial class CreateTournamentForm
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
            TournamentNameText = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeText = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropdown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedTeamButton = new Button();
            deleteSelectedPrizeButton = new Button();
            tournamentPrizesLabel = new Label();
            tournamentPrizesListBox = new ListBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22.2F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(91, 34);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(334, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // TournamentNameText
            // 
            TournamentNameText.Location = new Point(91, 174);
            TournamentNameText.Name = "TournamentNameText";
            TournamentNameText.Size = new Size(464, 43);
            TournamentNameText.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(91, 130);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(271, 41);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name:";
            // 
            // entryFeeText
            // 
            entryFeeText.Location = new Point(244, 265);
            entryFeeText.Name = "entryFeeText";
            entryFeeText.Size = new Size(125, 43);
            entryFeeText.TabIndex = 12;
            entryFeeText.Text = "0.00";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(91, 267);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(147, 41);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(91, 398);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(464, 45);
            selectTeamDropdown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(91, 354);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(182, 41);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team:";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(403, 357);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(152, 38);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = Color.PowderBlue;
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            addTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Location = new Point(182, 465);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(282, 68);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = Color.PowderBlue;
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            createPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Location = new Point(182, 553);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(282, 68);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 37;
            tournamentPlayersListBox.Location = new Point(680, 174);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(392, 187);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentPlayersLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersLabel.Location = new Point(680, 130);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(301, 41);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Competitors:";
            // 
            // deleteSelectedTeamButton
            // 
            deleteSelectedTeamButton.BackColor = Color.PowderBlue;
            deleteSelectedTeamButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            deleteSelectedTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            deleteSelectedTeamButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamButton.Location = new Point(1097, 210);
            deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            deleteSelectedTeamButton.Size = new Size(171, 115);
            deleteSelectedTeamButton.TabIndex = 20;
            deleteSelectedTeamButton.Text = "Delete Selected";
            deleteSelectedTeamButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.BackColor = Color.PowderBlue;
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Location = new Point(1097, 470);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(171, 115);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // tournamentPrizesLabel
            // 
            tournamentPrizesLabel.AutoSize = true;
            tournamentPrizesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentPrizesLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPrizesLabel.Location = new Point(680, 390);
            tournamentPrizesLabel.Name = "tournamentPrizesLabel";
            tournamentPrizesLabel.Size = new Size(102, 41);
            tournamentPrizesLabel.TabIndex = 22;
            tournamentPrizesLabel.Text = "Prizes:";
            // 
            // tournamentPrizesListBox
            // 
            tournamentPrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPrizesListBox.FormattingEnabled = true;
            tournamentPrizesListBox.ItemHeight = 37;
            tournamentPrizesListBox.Location = new Point(680, 434);
            tournamentPrizesListBox.Name = "tournamentPrizesListBox";
            tournamentPrizesListBox.Size = new Size(392, 187);
            tournamentPrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 745);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(tournamentPrizesLabel);
            Controls.Add(tournamentPrizesListBox);
            Controls.Add(deleteSelectedTeamButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeText);
            Controls.Add(entryFeeLabel);
            Controls.Add(TournamentNameText);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox TournamentNameText;
        private Label tournamentNameLabel;
        private TextBox entryFeeText;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedTeamButton;
        private Button deleteSelectedPrizeButton;
        private Label tournamentPrizesLabel;
        private ListBox tournamentPrizesListBox;
    }
}