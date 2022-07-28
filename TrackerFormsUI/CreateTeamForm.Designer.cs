namespace TrackerFormsUI;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(50, 109);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(312, 34);
            this.teamNameValue.TabIndex = 11;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamNameLabel.Location = new System.Drawing.Point(50, 65);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(135, 31);
            this.teamNameLabel.TabIndex = 10;
            this.teamNameLabel.Text = "Team Name";
            this.teamNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTeamLabel.Location = new System.Drawing.Point(50, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(173, 41);
            this.createTeamLabel.TabIndex = 9;
            this.createTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.SystemColors.Control;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMemberButton.Location = new System.Drawing.Point(78, 265);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(239, 40);
            this.addMemberButton.TabIndex = 17;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            // 
            // selectTeamMemberComboBox
            // 
            this.selectTeamMemberComboBox.FormattingEnabled = true;
            this.selectTeamMemberComboBox.Location = new System.Drawing.Point(50, 208);
            this.selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            this.selectTeamMemberComboBox.Size = new System.Drawing.Size(312, 36);
            this.selectTeamMemberComboBox.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(50, 165);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(228, 31);
            this.selectTeamMemberLabel.TabIndex = 15;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            this.selectTeamMemberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cellphoneValue);
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.firstNameValue);
            this.groupBox1.Controls.Add(this.cellphoneLabel);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.lastNameValue);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(50, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 324);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(144, 201);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(184, 34);
            this.cellphoneValue.TabIndex = 8;
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.SystemColors.Control;
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.Location = new System.Drawing.Point(50, 252);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(239, 40);
            this.createMemberButton.TabIndex = 17;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(144, 143);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(184, 34);
            this.emailValue.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 34);
            this.textBox1.TabIndex = 8;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(144, 42);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(184, 34);
            this.firstNameValue.TabIndex = 8;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cellphoneLabel.Location = new System.Drawing.Point(11, 202);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(117, 31);
            this.cellphoneLabel.TabIndex = 7;
            this.cellphoneLabel.Text = "Cellphone";
            this.cellphoneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emailLabel.Location = new System.Drawing.Point(11, 144);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 31);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastNameValue
            // 
            this.lastNameValue.AutoSize = true;
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameValue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lastNameValue.Location = new System.Drawing.Point(11, 94);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(122, 31);
            this.lastNameValue.TabIndex = 7;
            this.lastNameValue.Text = "Last Name";
            this.lastNameValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.firstNameLabel.Location = new System.Drawing.Point(11, 43);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(124, 31);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 28;
            this.teamMembersListBox.Location = new System.Drawing.Point(436, 65);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(344, 590);
            this.teamMembersListBox.TabIndex = 19;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteMemberButton.Location = new System.Drawing.Point(814, 326);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(107, 79);
            this.deleteMemberButton.TabIndex = 20;
            this.deleteMemberButton.Text = "Delete Selected";
            this.deleteMemberButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.SystemColors.Control;
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.Location = new System.Drawing.Point(284, 677);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(344, 55);
            this.createTeamButton.TabIndex = 21;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 744);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberComboBox);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox teamNameValue;
    private Label teamNameLabel;
    private Label createTeamLabel;
    private Button addMemberButton;
    private ComboBox selectTeamMemberComboBox;
    private Label selectTeamMemberLabel;
    private GroupBox groupBox1;
    private TextBox cellphoneValue;
    private Button createMemberButton;
    private TextBox emailValue;
    private TextBox textBox1;
    private TextBox firstNameValue;
    private Label cellphoneLabel;
    private Label emailLabel;
    private Label lastNameValue;
    private Label firstNameLabel;
    private ListBox teamMembersListBox;
    private Button deleteMemberButton;
    private Button createTeamButton;
}