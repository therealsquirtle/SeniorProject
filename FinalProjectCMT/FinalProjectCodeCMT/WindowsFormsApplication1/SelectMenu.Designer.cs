namespace WindowsFormsApplication1
{
    partial class SelectMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_charChoose = new System.Windows.Forms.ComboBox();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDCharDataSet = new CharacterCreator.DDCharDataSet();
            this.characterTableAdapter = new CharacterCreator.DDCharDataSetTableAdapters.CharacterTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_charChoose
            // 
            this.cbx_charChoose.DataSource = this.characterBindingSource;
            this.cbx_charChoose.DisplayMember = "name";
            this.cbx_charChoose.FormattingEnabled = true;
            this.cbx_charChoose.Location = new System.Drawing.Point(75, 92);
            this.cbx_charChoose.Name = "cbx_charChoose";
            this.cbx_charChoose.Size = new System.Drawing.Size(121, 21);
            this.cbx_charChoose.TabIndex = 2;
            this.cbx_charChoose.ValueMember = "CharID";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainToolStripMenuItem,
            this.createANewCharacterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainToolStripMenuItem
            // 
            this.backToMainToolStripMenuItem.Name = "backToMainToolStripMenuItem";
            this.backToMainToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.backToMainToolStripMenuItem.Text = "Back to Main";
            this.backToMainToolStripMenuItem.Click += new System.EventHandler(this.backToMainToolStripMenuItem_Click);
            // 
            // createANewCharacterToolStripMenuItem
            // 
            this.createANewCharacterToolStripMenuItem.Name = "createANewCharacterToolStripMenuItem";
            this.createANewCharacterToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.createANewCharacterToolStripMenuItem.Text = "Create a New Character";
            this.createANewCharacterToolStripMenuItem.Click += new System.EventHandler(this.createANewCharacterToolStripMenuItem_Click);
            // 
            // SelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cbx_charChoose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectMenu";
            this.Text = "SelectMenu";
            this.Load += new System.EventHandler(this.SelectMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDCharDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_charChoose;
        private CharacterCreator.DDCharDataSet dDCharDataSet;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private CharacterCreator.DDCharDataSetTableAdapters.CharacterTableAdapter characterTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewCharacterToolStripMenuItem;
    }
}