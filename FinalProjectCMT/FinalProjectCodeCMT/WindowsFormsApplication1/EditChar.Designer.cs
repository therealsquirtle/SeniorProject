namespace WindowsFormsApplication1
{
    partial class EditChar
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseDexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseConDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseIntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseWisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDCharDataSet = new CharacterCreator.DDCharDataSet();
            this.characterTableAdapter = new CharacterCreator.DDCharDataSetTableAdapters.CharacterTableAdapter();
            this.btn_Gear = new System.Windows.Forms.Button();
            this.btn_Feats = new System.Windows.Forms.Button();
            this.btn_Attacks = new System.Windows.Forms.Button();
            this.btn_Skills = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.baseStrDataGridViewTextBoxColumn,
            this.baseDexDataGridViewTextBoxColumn,
            this.baseConDataGridViewTextBoxColumn,
            this.baseIntDataGridViewTextBoxColumn,
            this.baseWisDataGridViewTextBoxColumn,
            this.baseCharDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.characterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CharID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CharID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "class";
            this.dataGridViewTextBoxColumn4.HeaderText = "class";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "raceID";
            this.dataGridViewTextBoxColumn5.HeaderText = "raceID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "clevel";
            this.dataGridViewTextBoxColumn6.HeaderText = "clevel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ECL";
            this.dataGridViewTextBoxColumn7.HeaderText = "ECL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn8.HeaderText = "Size";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn9.HeaderText = "gender";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "alignment";
            this.dataGridViewTextBoxColumn10.HeaderText = "alignment";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "religon";
            this.dataGridViewTextBoxColumn11.HeaderText = "religon";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "height";
            this.dataGridViewTextBoxColumn12.HeaderText = "height";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "cweight";
            this.dataGridViewTextBoxColumn13.HeaderText = "cweight";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "cdescription";
            this.dataGridViewTextBoxColumn14.HeaderText = "cdescription";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "photo";
            this.dataGridViewImageColumn1.HeaderText = "photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "touchAc";
            this.dataGridViewTextBoxColumn15.HeaderText = "touchAc";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "flatAC";
            this.dataGridViewTextBoxColumn16.HeaderText = "flatAC";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "hitPoints";
            this.dataGridViewTextBoxColumn17.HeaderText = "hitPoints";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "experiencePoints";
            this.dataGridViewTextBoxColumn18.HeaderText = "experiencePoints";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "lightCarry";
            this.dataGridViewTextBoxColumn19.HeaderText = "lightCarry";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "medCarry";
            this.dataGridViewTextBoxColumn20.HeaderText = "medCarry";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "heavyCarry";
            this.dataGridViewTextBoxColumn21.HeaderText = "heavyCarry";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // baseStrDataGridViewTextBoxColumn
            // 
            this.baseStrDataGridViewTextBoxColumn.DataPropertyName = "baseStr";
            this.baseStrDataGridViewTextBoxColumn.HeaderText = "baseStr";
            this.baseStrDataGridViewTextBoxColumn.Name = "baseStrDataGridViewTextBoxColumn";
            // 
            // baseDexDataGridViewTextBoxColumn
            // 
            this.baseDexDataGridViewTextBoxColumn.DataPropertyName = "baseDex";
            this.baseDexDataGridViewTextBoxColumn.HeaderText = "baseDex";
            this.baseDexDataGridViewTextBoxColumn.Name = "baseDexDataGridViewTextBoxColumn";
            // 
            // baseConDataGridViewTextBoxColumn
            // 
            this.baseConDataGridViewTextBoxColumn.DataPropertyName = "baseCon";
            this.baseConDataGridViewTextBoxColumn.HeaderText = "baseCon";
            this.baseConDataGridViewTextBoxColumn.Name = "baseConDataGridViewTextBoxColumn";
            // 
            // baseIntDataGridViewTextBoxColumn
            // 
            this.baseIntDataGridViewTextBoxColumn.DataPropertyName = "baseInt";
            this.baseIntDataGridViewTextBoxColumn.HeaderText = "baseInt";
            this.baseIntDataGridViewTextBoxColumn.Name = "baseIntDataGridViewTextBoxColumn";
            // 
            // baseWisDataGridViewTextBoxColumn
            // 
            this.baseWisDataGridViewTextBoxColumn.DataPropertyName = "baseWis";
            this.baseWisDataGridViewTextBoxColumn.HeaderText = "baseWis";
            this.baseWisDataGridViewTextBoxColumn.Name = "baseWisDataGridViewTextBoxColumn";
            // 
            // baseCharDataGridViewTextBoxColumn
            // 
            this.baseCharDataGridViewTextBoxColumn.DataPropertyName = "baseChar";
            this.baseCharDataGridViewTextBoxColumn.HeaderText = "baseChar";
            this.baseCharDataGridViewTextBoxColumn.Name = "baseCharDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "Character";
            this.characterBindingSource.DataSource = this.dDCharDataSet;
            // 
            // dDCharDataSet
            // 
            this.dDCharDataSet.DataSetName = "DDCharDataSet";
            this.dDCharDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // characterTableAdapter
            // 
            this.characterTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Gear
            // 
            this.btn_Gear.Location = new System.Drawing.Point(202, 325);
            this.btn_Gear.Name = "btn_Gear";
            this.btn_Gear.Size = new System.Drawing.Size(75, 23);
            this.btn_Gear.TabIndex = 1;
            this.btn_Gear.Text = "Gear";
            this.btn_Gear.UseVisualStyleBackColor = true;
            this.btn_Gear.Click += new System.EventHandler(this.btn_Gear_Click);
            // 
            // btn_Feats
            // 
            this.btn_Feats.Location = new System.Drawing.Point(301, 325);
            this.btn_Feats.Name = "btn_Feats";
            this.btn_Feats.Size = new System.Drawing.Size(75, 23);
            this.btn_Feats.TabIndex = 2;
            this.btn_Feats.Text = "Feats";
            this.btn_Feats.UseVisualStyleBackColor = true;
            this.btn_Feats.Click += new System.EventHandler(this.btn_Feats_Click);
            // 
            // btn_Attacks
            // 
            this.btn_Attacks.Location = new System.Drawing.Point(395, 325);
            this.btn_Attacks.Name = "btn_Attacks";
            this.btn_Attacks.Size = new System.Drawing.Size(75, 23);
            this.btn_Attacks.TabIndex = 3;
            this.btn_Attacks.Text = "Attacks";
            this.btn_Attacks.UseVisualStyleBackColor = true;
            this.btn_Attacks.Click += new System.EventHandler(this.btn_Attacks_Click);
            // 
            // btn_Skills
            // 
            this.btn_Skills.Location = new System.Drawing.Point(487, 325);
            this.btn_Skills.Name = "btn_Skills";
            this.btn_Skills.Size = new System.Drawing.Size(75, 23);
            this.btn_Skills.TabIndex = 4;
            this.btn_Skills.Text = "Skills";
            this.btn_Skills.UseVisualStyleBackColor = true;
            this.btn_Skills.Click += new System.EventHandler(this.btn_Skills_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainToolStripMenuItem,
            this.createANewCharacterToolStripMenuItem,
            this.selectAnotherCharacterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToMainToolStripMenuItem
            // 
            this.returnToMainToolStripMenuItem.Name = "returnToMainToolStripMenuItem";
            this.returnToMainToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.returnToMainToolStripMenuItem.Text = "Return to Main";
            this.returnToMainToolStripMenuItem.Click += new System.EventHandler(this.returnToMainToolStripMenuItem_Click_1);
            // 
            // createANewCharacterToolStripMenuItem
            // 
            this.createANewCharacterToolStripMenuItem.Name = "createANewCharacterToolStripMenuItem";
            this.createANewCharacterToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.createANewCharacterToolStripMenuItem.Text = "Create a New Character";
            this.createANewCharacterToolStripMenuItem.Click += new System.EventHandler(this.createANewCharacterToolStripMenuItem_Click_1);
            // 
            // selectAnotherCharacterToolStripMenuItem
            // 
            this.selectAnotherCharacterToolStripMenuItem.Name = "selectAnotherCharacterToolStripMenuItem";
            this.selectAnotherCharacterToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.selectAnotherCharacterToolStripMenuItem.Text = "Select Another Character";
            this.selectAnotherCharacterToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherCharacterToolStripMenuItem_Click);
            // 
            // EditChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.btn_Skills);
            this.Controls.Add(this.btn_Attacks);
            this.Controls.Add(this.btn_Feats);
            this.Controls.Add(this.btn_Gear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditChar";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditChar_FormClosing);
            this.Load += new System.EventHandler(this.EditChar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CharacterCreator.DDCharDataSet dDCharDataSet;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private CharacterCreator.DDCharDataSetTableAdapters.CharacterTableAdapter characterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseDexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseConDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseIntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseWisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Gear;
        private System.Windows.Forms.Button btn_Feats;
        private System.Windows.Forms.Button btn_Attacks;
        private System.Windows.Forms.Button btn_Skills;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherCharacterToolStripMenuItem;
    }
}