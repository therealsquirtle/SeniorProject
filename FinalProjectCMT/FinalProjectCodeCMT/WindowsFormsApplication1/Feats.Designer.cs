namespace WindowsFormsApplication1
{
    partial class Feats
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bonusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSMaxRanksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMaxRanksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abiltiyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreIncreaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDCharDataSet1 = new CharacterCreator.DDCharDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToSelctionMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonusesTableAdapter = new CharacterCreator.DDCharDataSet1TableAdapters.BonusesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bonusIDDataGridViewTextBoxColumn,
            this.lvlDataGridViewTextBoxColumn,
            this.xDDataGridViewTextBoxColumn,
            this.cSMaxRanksDataGridViewTextBoxColumn,
            this.cCMaxRanksDataGridViewTextBoxColumn,
            this.featDataGridViewTextBoxColumn,
            this.abiltiyDataGridViewTextBoxColumn,
            this.scoreIncreaseDataGridViewTextBoxColumn,
            this.charIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bonusesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // bonusIDDataGridViewTextBoxColumn
            // 
            this.bonusIDDataGridViewTextBoxColumn.DataPropertyName = "BonusID";
            this.bonusIDDataGridViewTextBoxColumn.HeaderText = "BonusID";
            this.bonusIDDataGridViewTextBoxColumn.Name = "bonusIDDataGridViewTextBoxColumn";
            this.bonusIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lvlDataGridViewTextBoxColumn
            // 
            this.lvlDataGridViewTextBoxColumn.DataPropertyName = "lvl";
            this.lvlDataGridViewTextBoxColumn.HeaderText = "lvl";
            this.lvlDataGridViewTextBoxColumn.Name = "lvlDataGridViewTextBoxColumn";
            // 
            // xDDataGridViewTextBoxColumn
            // 
            this.xDDataGridViewTextBoxColumn.DataPropertyName = "XD";
            this.xDDataGridViewTextBoxColumn.HeaderText = "XD";
            this.xDDataGridViewTextBoxColumn.Name = "xDDataGridViewTextBoxColumn";
            // 
            // cSMaxRanksDataGridViewTextBoxColumn
            // 
            this.cSMaxRanksDataGridViewTextBoxColumn.DataPropertyName = "CSMaxRanks";
            this.cSMaxRanksDataGridViewTextBoxColumn.HeaderText = "CSMaxRanks";
            this.cSMaxRanksDataGridViewTextBoxColumn.Name = "cSMaxRanksDataGridViewTextBoxColumn";
            // 
            // cCMaxRanksDataGridViewTextBoxColumn
            // 
            this.cCMaxRanksDataGridViewTextBoxColumn.DataPropertyName = "CCMaxRanks";
            this.cCMaxRanksDataGridViewTextBoxColumn.HeaderText = "CCMaxRanks";
            this.cCMaxRanksDataGridViewTextBoxColumn.Name = "cCMaxRanksDataGridViewTextBoxColumn";
            // 
            // featDataGridViewTextBoxColumn
            // 
            this.featDataGridViewTextBoxColumn.DataPropertyName = "Feat";
            this.featDataGridViewTextBoxColumn.HeaderText = "Feat";
            this.featDataGridViewTextBoxColumn.Name = "featDataGridViewTextBoxColumn";
            // 
            // abiltiyDataGridViewTextBoxColumn
            // 
            this.abiltiyDataGridViewTextBoxColumn.DataPropertyName = "Abiltiy";
            this.abiltiyDataGridViewTextBoxColumn.HeaderText = "Abiltiy";
            this.abiltiyDataGridViewTextBoxColumn.Name = "abiltiyDataGridViewTextBoxColumn";
            // 
            // scoreIncreaseDataGridViewTextBoxColumn
            // 
            this.scoreIncreaseDataGridViewTextBoxColumn.DataPropertyName = "ScoreIncrease";
            this.scoreIncreaseDataGridViewTextBoxColumn.HeaderText = "ScoreIncrease";
            this.scoreIncreaseDataGridViewTextBoxColumn.Name = "scoreIncreaseDataGridViewTextBoxColumn";
            // 
            // charIDDataGridViewTextBoxColumn
            // 
            this.charIDDataGridViewTextBoxColumn.DataPropertyName = "CharID";
            this.charIDDataGridViewTextBoxColumn.HeaderText = "CharID";
            this.charIDDataGridViewTextBoxColumn.Name = "charIDDataGridViewTextBoxColumn";
            // 
            // bonusesBindingSource
            // 
            this.bonusesBindingSource.DataMember = "Bonuses";
            this.bonusesBindingSource.DataSource = this.dDCharDataSet1;
            // 
            // dDCharDataSet1
            // 
            this.dDCharDataSet1.DataSetName = "DDCharDataSet1";
            this.dDCharDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem,
            this.backToSelctionMenuToolStripMenuItem,
            this.backToCharacterToolStripMenuItem,
            this.createANewCharacterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.backToMenuToolStripMenuItem.Text = "Back to Menu";
            // 
            // backToSelctionMenuToolStripMenuItem
            // 
            this.backToSelctionMenuToolStripMenuItem.Name = "backToSelctionMenuToolStripMenuItem";
            this.backToSelctionMenuToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.backToSelctionMenuToolStripMenuItem.Text = "Back to Selction Menu";
            this.backToSelctionMenuToolStripMenuItem.Click += new System.EventHandler(this.backToSelctionMenuToolStripMenuItem_Click);
            // 
            // backToCharacterToolStripMenuItem
            // 
            this.backToCharacterToolStripMenuItem.Name = "backToCharacterToolStripMenuItem";
            this.backToCharacterToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.backToCharacterToolStripMenuItem.Text = "Back to Character";
            this.backToCharacterToolStripMenuItem.Click += new System.EventHandler(this.backToCharacterToolStripMenuItem_Click);
            // 
            // createANewCharacterToolStripMenuItem
            // 
            this.createANewCharacterToolStripMenuItem.Name = "createANewCharacterToolStripMenuItem";
            this.createANewCharacterToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.createANewCharacterToolStripMenuItem.Text = "Create a new Character";
            this.createANewCharacterToolStripMenuItem.Click += new System.EventHandler(this.createANewCharacterToolStripMenuItem_Click);
            // 
            // bonusesTableAdapter
            // 
            this.bonusesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Feats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Feats";
            this.Text = "FeatsSkillsSpecialsLanguages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Feats_FormClosing);
            this.Load += new System.EventHandler(this.Feats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CharacterCreator.DDCharDataSet1 dDCharDataSet1;
        private System.Windows.Forms.BindingSource bonusesBindingSource;
        private CharacterCreator.DDCharDataSet1TableAdapters.BonusesTableAdapter bonusesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lvlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSMaxRanksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMaxRanksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abiltiyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreIncreaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToSelctionMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewCharacterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
      
    }
}