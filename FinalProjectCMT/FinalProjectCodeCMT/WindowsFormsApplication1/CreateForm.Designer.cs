namespace WindowsFormsApplication1
{
    partial class CreateForm
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
            this.tbxCharName = new System.Windows.Forms.TextBox();
            this.tbxPlayerName = new System.Windows.Forms.TextBox();
            this.tbxClass = new System.Windows.Forms.TextBox();
            this.tbxLevel = new System.Windows.Forms.TextBox();
            this.tbxRace = new System.Windows.Forms.TextBox();
            this.tbxDiety = new System.Windows.Forms.TextBox();
            this.tbxAlignment = new System.Windows.Forms.TextBox();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxGender = new System.Windows.Forms.TextBox();
            this.btnBaseRolls = new System.Windows.Forms.Button();
            this.btnFeats = new System.Windows.Forms.Button();
            this.btnGear = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnAttacks = new System.Windows.Forms.Button();
            this.Campaign = new System.Windows.Forms.TextBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbx_description = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadACharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxCharName
            // 
            this.tbxCharName.Location = new System.Drawing.Point(31, 112);
            this.tbxCharName.Name = "tbxCharName";
            this.tbxCharName.Size = new System.Drawing.Size(100, 20);
            this.tbxCharName.TabIndex = 0;
            this.tbxCharName.Tag = "Charactervars Name";
            this.tbxCharName.Text = "Charactervars Name";
            this.tbxCharName.TextChanged += new System.EventHandler(this.tbxCharName_TextChanged);
            // 
            // tbxPlayerName
            // 
            this.tbxPlayerName.Location = new System.Drawing.Point(162, 112);
            this.tbxPlayerName.Name = "tbxPlayerName";
            this.tbxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tbxPlayerName.TabIndex = 1;
            this.tbxPlayerName.Text = "Player Name";
            this.tbxPlayerName.TextChanged += new System.EventHandler(this.tbxPlayerName_TextChanged);
            // 
            // tbxClass
            // 
            this.tbxClass.Location = new System.Drawing.Point(280, 112);
            this.tbxClass.Name = "tbxClass";
            this.tbxClass.Size = new System.Drawing.Size(100, 20);
            this.tbxClass.TabIndex = 2;
            this.tbxClass.Text = "Class";
            this.tbxClass.TextChanged += new System.EventHandler(this.tbxClass_TextChanged);
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(386, 112);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.Size = new System.Drawing.Size(100, 20);
            this.tbxLevel.TabIndex = 3;
            this.tbxLevel.Text = "Level";
            this.tbxLevel.TextChanged += new System.EventHandler(this.tbxLevel_TextChanged);
            // 
            // tbxRace
            // 
            this.tbxRace.Location = new System.Drawing.Point(492, 112);
            this.tbxRace.Name = "tbxRace";
            this.tbxRace.Size = new System.Drawing.Size(100, 20);
            this.tbxRace.TabIndex = 4;
            this.tbxRace.Text = "Race";
            this.tbxRace.TextChanged += new System.EventHandler(this.tbxRace_TextChanged);
            // 
            // tbxDiety
            // 
            this.tbxDiety.Location = new System.Drawing.Point(31, 156);
            this.tbxDiety.Name = "tbxDiety";
            this.tbxDiety.Size = new System.Drawing.Size(100, 20);
            this.tbxDiety.TabIndex = 5;
            this.tbxDiety.Text = "Diety";
            this.tbxDiety.TextChanged += new System.EventHandler(this.tbxDiety_TextChanged);
            // 
            // tbxAlignment
            // 
            this.tbxAlignment.Location = new System.Drawing.Point(598, 112);
            this.tbxAlignment.Name = "tbxAlignment";
            this.tbxAlignment.Size = new System.Drawing.Size(100, 20);
            this.tbxAlignment.TabIndex = 6;
            this.tbxAlignment.Text = "Alignment";
            this.tbxAlignment.TextChanged += new System.EventHandler(this.tbxAlignment_TextChanged);
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(162, 156);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(100, 20);
            this.tbxSize.TabIndex = 7;
            this.tbxSize.Text = "Size";
            this.tbxSize.TextChanged += new System.EventHandler(this.tbxSize_TextChanged);
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(280, 156);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 8;
            this.tbxAge.Text = "Age";
            this.tbxAge.TextChanged += new System.EventHandler(this.tbxAge_TextChanged);
            // 
            // tbxGender
            // 
            this.tbxGender.Location = new System.Drawing.Point(386, 156);
            this.tbxGender.Name = "tbxGender";
            this.tbxGender.Size = new System.Drawing.Size(100, 20);
            this.tbxGender.TabIndex = 10;
            this.tbxGender.Text = "Gender";
            this.tbxGender.TextChanged += new System.EventHandler(this.tbxGender_TextChanged);
            // 
            // btnBaseRolls
            // 
            this.btnBaseRolls.Location = new System.Drawing.Point(96, 379);
            this.btnBaseRolls.Name = "btnBaseRolls";
            this.btnBaseRolls.Size = new System.Drawing.Size(96, 23);
            this.btnBaseRolls.TabIndex = 15;
            this.btnBaseRolls.Text = "Roll Base Stats  ";
            this.btnBaseRolls.UseVisualStyleBackColor = true;
            this.btnBaseRolls.Click += new System.EventHandler(this.btnBaseRolls_Click);
            // 
            // btnFeats
            // 
            this.btnFeats.Enabled = false;
            this.btnFeats.Location = new System.Drawing.Point(390, 417);
            this.btnFeats.Name = "btnFeats";
            this.btnFeats.Size = new System.Drawing.Size(92, 23);
            this.btnFeats.TabIndex = 17;
            this.btnFeats.Text = "Choose Feats";
            this.btnFeats.UseVisualStyleBackColor = true;
            this.btnFeats.Click += new System.EventHandler(this.btnFeats_Click);
            // 
            // btnGear
            // 
            this.btnGear.Enabled = false;
            this.btnGear.Location = new System.Drawing.Point(292, 417);
            this.btnGear.Name = "btnGear";
            this.btnGear.Size = new System.Drawing.Size(92, 23);
            this.btnGear.TabIndex = 18;
            this.btnGear.Text = "Choose Gear";
            this.btnGear.UseVisualStyleBackColor = true;
            this.btnGear.Click += new System.EventHandler(this.btnGear_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.Enabled = false;
            this.btnSkills.Location = new System.Drawing.Point(194, 417);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(92, 23);
            this.btnSkills.TabIndex = 19;
            this.btnSkills.Text = "Choose Skills";
            this.btnSkills.UseVisualStyleBackColor = true;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // btnAttacks
            // 
            this.btnAttacks.Enabled = false;
            this.btnAttacks.Location = new System.Drawing.Point(96, 417);
            this.btnAttacks.Name = "btnAttacks";
            this.btnAttacks.Size = new System.Drawing.Size(92, 23);
            this.btnAttacks.TabIndex = 20;
            this.btnAttacks.Text = "Choose Attacks";
            this.btnAttacks.UseVisualStyleBackColor = true;
            this.btnAttacks.Click += new System.EventHandler(this.btnAttacks_Click);
            // 
            // Campaign
            // 
            this.Campaign.Location = new System.Drawing.Point(31, 65);
            this.Campaign.Name = "Campaign";
            this.Campaign.Size = new System.Drawing.Size(100, 20);
            this.Campaign.TabIndex = 21;
            this.Campaign.Text = "Campaign Name";
            this.Campaign.TextChanged += new System.EventHandler(this.Campaign_TextChanged);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(31, 334);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(113, 23);
            this.btnPhoto.TabIndex = 22;
            this.btnPhoto.Text = "Import Photograph";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(198, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save Character Info";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbx_description
            // 
            this.tbx_description.Location = new System.Drawing.Point(31, 232);
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.Size = new System.Drawing.Size(667, 96);
            this.tbx_description.TabIndex = 28;
            this.tbx_description.Text = "Description";
            this.tbx_description.TextChanged += new System.EventHandler(this.tbx_description_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainFormToolStripMenuItem,
            this.loadACharacterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainFormToolStripMenuItem
            // 
            this.backToMainFormToolStripMenuItem.Name = "backToMainFormToolStripMenuItem";
            this.backToMainFormToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.backToMainFormToolStripMenuItem.Text = "Back to Main Form";
            this.backToMainFormToolStripMenuItem.Click += new System.EventHandler(this.backToMainFormToolStripMenuItem_Click);
            // 
            // loadACharacterToolStripMenuItem
            // 
            this.loadACharacterToolStripMenuItem.Name = "loadACharacterToolStripMenuItem";
            this.loadACharacterToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.loadACharacterToolStripMenuItem.Text = "Load a Character";
            this.loadACharacterToolStripMenuItem.Click += new System.EventHandler(this.loadACharacterToolStripMenuItem_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 461);
            this.Controls.Add(this.tbx_description);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.Campaign);
            this.Controls.Add(this.btnAttacks);
            this.Controls.Add(this.btnSkills);
            this.Controls.Add(this.btnGear);
            this.Controls.Add(this.btnFeats);
            this.Controls.Add(this.btnBaseRolls);
            this.Controls.Add(this.tbxGender);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.tbxAlignment);
            this.Controls.Add(this.tbxDiety);
            this.Controls.Add(this.tbxRace);
            this.Controls.Add(this.tbxLevel);
            this.Controls.Add(this.tbxClass);
            this.Controls.Add(this.tbxPlayerName);
            this.Controls.Add(this.tbxCharName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCharName;
        private System.Windows.Forms.TextBox tbxPlayerName;
        private System.Windows.Forms.TextBox tbxClass;
        private System.Windows.Forms.TextBox tbxLevel;
        private System.Windows.Forms.TextBox tbxRace;
        private System.Windows.Forms.TextBox tbxDiety;
        private System.Windows.Forms.TextBox tbxAlignment;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxGender;
        private System.Windows.Forms.Button btnBaseRolls;
        private System.Windows.Forms.Button btnFeats;
        private System.Windows.Forms.Button btnGear;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnAttacks;
        private System.Windows.Forms.TextBox Campaign;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox tbx_description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadACharacterToolStripMenuItem;
    }
}

