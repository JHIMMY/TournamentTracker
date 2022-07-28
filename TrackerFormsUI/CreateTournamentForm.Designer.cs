namespace TrackerFormsUI;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.teamPlayersLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.deletePlayersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentLabel.Location = new System.Drawing.Point(22, 44);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(257, 41);
            this.createTournamentLabel.TabIndex = 2;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(22, 144);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(312, 34);
            this.tournamentNameValue.TabIndex = 8;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(22, 100);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(203, 31);
            this.tournamentNameLabel.TabIndex = 7;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(153, 205);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(125, 34);
            this.entryFeeValue.TabIndex = 10;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(22, 208);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(107, 31);
            this.entryFeeLabel.TabIndex = 9;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(22, 309);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(312, 36);
            this.selectTeamComboBox.TabIndex = 12;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(22, 266);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(135, 31);
            this.selectTeamLabel.TabIndex = 11;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(234, 269);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(105, 28);
            this.createNewTeamLink.TabIndex = 13;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.SystemColors.Control;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.Location = new System.Drawing.Point(52, 363);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(239, 40);
            this.addTeamButton.TabIndex = 14;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.SystemColors.Control;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.Location = new System.Drawing.Point(255, 489);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(344, 55);
            this.createTournamentButton.TabIndex = 14;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 28;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(473, 90);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(286, 142);
            this.tournamentPlayersListBox.TabIndex = 15;
            // 
            // teamPlayersLabel
            // 
            this.teamPlayersLabel.AutoSize = true;
            this.teamPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamPlayersLabel.Location = new System.Drawing.Point(473, 52);
            this.teamPlayersLabel.Name = "teamPlayersLabel";
            this.teamPlayersLabel.Size = new System.Drawing.Size(171, 31);
            this.teamPlayersLabel.TabIndex = 7;
            this.teamPlayersLabel.Text = "Teams / Players";
            this.teamPlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.Location = new System.Drawing.Point(473, 282);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(171, 31);
            this.prizesLabel.TabIndex = 7;
            this.prizesLabel.Text = "Teams / Players";
            this.prizesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 28;
            this.prizesListBox.Location = new System.Drawing.Point(473, 322);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(286, 142);
            this.prizesListBox.TabIndex = 15;
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.BackColor = System.Drawing.SystemColors.Control;
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletePrizeButton.Location = new System.Drawing.Point(774, 354);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(107, 79);
            this.deletePrizeButton.TabIndex = 16;
            this.deletePrizeButton.Text = "Delete Selected";
            this.deletePrizeButton.UseVisualStyleBackColor = false;
            // 
            // deletePlayersButton
            // 
            this.deletePlayersButton.BackColor = System.Drawing.SystemColors.Control;
            this.deletePlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletePlayersButton.Location = new System.Drawing.Point(777, 122);
            this.deletePlayersButton.Name = "deletePlayersButton";
            this.deletePlayersButton.Size = new System.Drawing.Size(107, 79);
            this.deletePlayersButton.TabIndex = 16;
            this.deletePlayersButton.Text = "Delete Selected";
            this.deletePlayersButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 570);
            this.Controls.Add(this.deletePlayersButton);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamPlayersLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label createTournamentLabel;
    private TextBox tournamentNameValue;
    private Label tournamentNameLabel;
    private TextBox entryFeeValue;
    private Label entryFeeLabel;
    private ComboBox selectTeamComboBox;
    private Label selectTeamLabel;
    private LinkLabel createNewTeamLink;
    private Button addTeamButton;
    private Button createTournamentButton;
    private ListBox tournamentPlayersListBox;
    private Label teamPlayersLabel;
    private Label prizesLabel;
    private ListBox prizesListBox;
    private Button deletePrizeButton;
    private Button deletePlayersButton;
}