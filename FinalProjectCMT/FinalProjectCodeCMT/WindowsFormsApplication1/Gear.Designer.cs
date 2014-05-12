namespace WindowsFormsApplication1
{
    partial class Gear
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
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDCharDataSet = new CharacterCreator.DDCharDataSet();
            this.gearTableAdapter = new CharacterCreator.DDCharDataSetTableAdapters.GearTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToSelctionMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.gearBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn5.HeaderText = "Item";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CharID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CharID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn7.HeaderText = "Location";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn8.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // gearBindingSource
            // 
            this.gearBindingSource.DataMember = "Gear";
            this.gearBindingSource.DataSource = this.dDCharDataSet;
            // 
            // dDCharDataSet
            // 
            this.dDCharDataSet.DataSetName = "DDCharDataSet";
            this.dDCharDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gearTableAdapter
            // 
            this.gearTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.backToMenuToolStripMenuItem.Text = "Back to Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Gear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gear";
            this.Text = "Gear";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gear_FormClosing);
            this.Load += new System.EventHandler(this.Gear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;


        private CharacterCreator.DDCharDataSet dDCharDataSet;
        private System.Windows.Forms.BindingSource gearBindingSource;
        private CharacterCreator.DDCharDataSetTableAdapters.GearTableAdapter gearTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToSelctionMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewCharacterToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}