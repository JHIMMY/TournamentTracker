namespace TrackerFormsUI;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentComboBox = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(120, 25);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(313, 41);
            this.tournamentDashboardLabel.TabIndex = 11;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentComboBox
            // 
            this.loadExistingTournamentComboBox.FormattingEnabled = true;
            this.loadExistingTournamentComboBox.Location = new System.Drawing.Point(20, 140);
            this.loadExistingTournamentComboBox.Name = "loadExistingTournamentComboBox";
            this.loadExistingTournamentComboBox.Size = new System.Drawing.Size(497, 36);
            this.loadExistingTournamentComboBox.TabIndex = 18;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(155, 97);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(278, 31);
            this.loadExistingTournamentLabel.TabIndex = 17;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            this.loadExistingTournamentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.SystemColors.Control;
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.Location = new System.Drawing.Point(140, 196);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(239, 40);
            this.loadTournamentButton.TabIndex = 19;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.SystemColors.Control;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.Location = new System.Drawing.Point(120, 260);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(298, 95);
            this.createTournamentButton.TabIndex = 23;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(540, 385);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentComboBox);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label tournamentDashboardLabel;
    private ComboBox loadExistingTournamentComboBox;
    private Label loadExistingTournamentLabel;
    private Button loadTournamentButton;
    private Button createTournamentButton;
}