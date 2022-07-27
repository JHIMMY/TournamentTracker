namespace TrackerFormsUI;

partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(25, 34);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(174, 41);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentName.Location = new System.Drawing.Point(205, 34);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(120, 41);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundLabel.Location = new System.Drawing.Point(25, 97);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(80, 31);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Location = new System.Drawing.Point(121, 92);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(190, 36);
            this.roundComboBox.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(121, 148);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(177, 35);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayer Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 28;
            this.matchupListBox.Location = new System.Drawing.Point(25, 216);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(286, 310);
            this.matchupListBox.TabIndex = 5;
            // 
            // TeamOneNameLabel
            // 
            this.TeamOneNameLabel.AutoSize = true;
            this.TeamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneNameLabel.Location = new System.Drawing.Point(371, 238);
            this.TeamOneNameLabel.Name = "TeamOneNameLabel";
            this.TeamOneNameLabel.Size = new System.Drawing.Size(142, 31);
            this.TeamOneNameLabel.TabIndex = 2;
            this.TeamOneNameLabel.Text = "<team one>";
            this.TeamOneNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(371, 284);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(70, 31);
            this.teamOneScoreLabel.TabIndex = 2;
            this.teamOneScoreLabel.Text = "Score";
            this.teamOneScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(447, 281);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(125, 34);
            this.teamOneScoreValue.TabIndex = 6;
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoNameLabel.Location = new System.Drawing.Point(371, 393);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(142, 31);
            this.teamTwoNameLabel.TabIndex = 2;
            this.teamTwoNameLabel.Text = "<team two>";
            this.teamTwoNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(371, 439);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(70, 31);
            this.teamTwoScoreLabel.TabIndex = 2;
            this.teamTwoScoreLabel.Text = "Score";
            this.teamTwoScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(447, 436);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(125, 34);
            this.teamTwoScoreValue.TabIndex = 6;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.vsLabel.Location = new System.Drawing.Point(447, 341);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(70, 31);
            this.vsLabel.TabIndex = 2;
            this.vsLabel.Text = "- VS -";
            this.vsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.SystemColors.Control;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(580, 341);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(107, 54);
            this.scoreButton.TabIndex = 7;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 577);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundComboBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.TeamOneNameLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label headerLabel;
    private Label tournamentName;
    private Label roundLabel;
    private ComboBox roundComboBox;
    private CheckBox unplayedOnlyCheckBox;
    private ListBox matchupListBox;
    private Label TeamOneNameLabel;
    private Label teamOneScoreLabel;
    private TextBox teamOneScoreValue;
    private Label teamTwoNameLabel;
    private Label teamTwoScoreLabel;
    private TextBox teamTwoScoreValue;
    private Label vsLabel;
    private Button scoreButton;
}
