namespace TrackerUI
{
    partial class CreateTeamForm
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
            TeamNameText = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropdown = new ComboBox();
            selectTeamMemberLabel = new Label();
            groupBox1 = new GroupBox();
            firstNameText = new TextBox();
            firstNameLabel = new Label();
            lastNameText = new TextBox();
            lastNameLabel = new Label();
            emailAddressText = new TextBox();
            emailAddressLabel = new Label();
            createTeamMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedTeamMemberButton = new Button();
            CreateTeamButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TeamNameText
            // 
            TeamNameText.Location = new Point(91, 174);
            TeamNameText.Name = "TeamNameText";
            TeamNameText.Size = new Size(534, 43);
            TeamNameText.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(91, 130);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(182, 41);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 22.2F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(91, 34);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(223, 50);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.BackColor = Color.PowderBlue;
            addTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            addTeamMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            addTeamMemberButton.FlatStyle = FlatStyle.Flat;
            addTeamMemberButton.Location = new Point(217, 350);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(282, 50);
            addTeamMemberButton.TabIndex = 19;
            addTeamMemberButton.Text = "Add Team Member";
            addTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // selectTeamMemberDropdown
            // 
            selectTeamMemberDropdown.FormattingEnabled = true;
            selectTeamMemberDropdown.Location = new Point(91, 283);
            selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            selectTeamMemberDropdown.Size = new Size(534, 45);
            selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemberLabel.Location = new Point(91, 239);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(303, 41);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createTeamMemberButton);
            groupBox1.Controls.Add(emailAddressText);
            groupBox1.Controls.Add(emailAddressLabel);
            groupBox1.Controls.Add(lastNameText);
            groupBox1.Controls.Add(lastNameLabel);
            groupBox1.Controls.Add(firstNameText);
            groupBox1.Controls.Add(firstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 18F);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(91, 427);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 269);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create New Member";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(172, 39);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(345, 47);
            firstNameText.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(6, 42);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(167, 41);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(172, 90);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(345, 47);
            lastNameText.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(6, 93);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(164, 41);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailAddressText
            // 
            emailAddressText.Location = new Point(172, 141);
            emailAddressText.Name = "emailAddressText";
            emailAddressText.Size = new Size(345, 47);
            emailAddressText.TabIndex = 14;
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailAddressLabel.ForeColor = SystemColors.MenuHighlight;
            emailAddressLabel.Location = new Point(6, 144);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new Size(95, 41);
            emailAddressLabel.TabIndex = 13;
            emailAddressLabel.Text = "Email:";
            // 
            // createTeamMemberButton
            // 
            createTeamMemberButton.BackColor = Color.PowderBlue;
            createTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            createTeamMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            createTeamMemberButton.FlatStyle = FlatStyle.Flat;
            createTeamMemberButton.ForeColor = SystemColors.ControlText;
            createTeamMemberButton.Location = new Point(82, 202);
            createTeamMemberButton.Name = "createTeamMemberButton";
            createTeamMemberButton.Size = new Size(355, 50);
            createTeamMemberButton.TabIndex = 21;
            createTeamMemberButton.Text = "Create Team Member";
            createTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 37;
            teamMembersListBox.Location = new Point(682, 174);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(329, 522);
            teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedTeamMemberButton
            // 
            deleteSelectedTeamMemberButton.BackColor = Color.PowderBlue;
            deleteSelectedTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            deleteSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            deleteSelectedTeamMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamMemberButton.Location = new Point(1027, 174);
            deleteSelectedTeamMemberButton.Name = "deleteSelectedTeamMemberButton";
            deleteSelectedTeamMemberButton.Size = new Size(171, 115);
            deleteSelectedTeamMemberButton.TabIndex = 22;
            deleteSelectedTeamMemberButton.Text = "Delete Selected";
            deleteSelectedTeamMemberButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.BackColor = Color.PowderBlue;
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            CreateTeamButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Location = new Point(1027, 581);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(171, 115);
            CreateTeamButton.TabIndex = 23;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 745);
            Controls.Add(CreateTeamButton);
            Controls.Add(deleteSelectedTeamMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropdown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(TeamNameText);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16.2F);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNameText;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropdown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private TextBox emailAddressText;
        private Label emailAddressLabel;
        private TextBox lastNameText;
        private Label lastNameLabel;
        private TextBox firstNameText;
        private Label firstNameLabel;
        private Button createTeamMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedTeamMemberButton;
        private Button CreateTeamButton;
    }
}