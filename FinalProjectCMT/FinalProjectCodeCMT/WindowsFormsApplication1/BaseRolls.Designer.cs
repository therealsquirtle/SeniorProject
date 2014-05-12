namespace WindowsFormsApplication1
{
    partial class BaseRolls
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
            this.tbx_Str = new System.Windows.Forms.TextBox();
            this.tbx_Dex = new System.Windows.Forms.TextBox();
            this.tbx_Con = new System.Windows.Forms.TextBox();
            this.tbx_Int = new System.Windows.Forms.TextBox();
            this.tbx_Wis = new System.Windows.Forms.TextBox();
            this.tbx_Char = new System.Windows.Forms.TextBox();
            this.lbl_base1 = new System.Windows.Forms.Label();
            this.lbl_base2 = new System.Windows.Forms.Label();
            this.lbl_base3 = new System.Windows.Forms.Label();
            this.lbl_base4 = new System.Windows.Forms.Label();
            this.lbl_base5 = new System.Windows.Forms.Label();
            this.lbl_base6 = new System.Windows.Forms.Label();
            this.btn_roll = new System.Windows.Forms.Button();
            this.btn_saveBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Str
            // 
            this.tbx_Str.Location = new System.Drawing.Point(320, 93);
            this.tbx_Str.Name = "tbx_Str";
            this.tbx_Str.Size = new System.Drawing.Size(100, 20);
            this.tbx_Str.TabIndex = 0;
            this.tbx_Str.Text = "Strength";
            this.tbx_Str.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbx_Str_DragDrop);
            this.tbx_Str.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbx_Str_DragEnter);
            // 
            // tbx_Dex
            // 
            this.tbx_Dex.Location = new System.Drawing.Point(320, 119);
            this.tbx_Dex.Name = "tbx_Dex";
            this.tbx_Dex.Size = new System.Drawing.Size(100, 20);
            this.tbx_Dex.TabIndex = 1;
            this.tbx_Dex.Text = "Dexterity";
            this.tbx_Dex.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbx_Dex_DragDrop);
            this.tbx_Dex.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbx_Dex_DragEnter);
            // 
            // tbx_Con
            // 
            this.tbx_Con.Location = new System.Drawing.Point(320, 145);
            this.tbx_Con.Name = "tbx_Con";
            this.tbx_Con.Size = new System.Drawing.Size(100, 20);
            this.tbx_Con.TabIndex = 2;
            this.tbx_Con.Text = "Constitution";
            this.tbx_Con.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbx_Con_DragDrop);
            this.tbx_Con.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbx_Con_DragEnter);
            // 
            // tbx_Int
            // 
            this.tbx_Int.Location = new System.Drawing.Point(320, 171);
            this.tbx_Int.Name = "tbx_Int";
            this.tbx_Int.Size = new System.Drawing.Size(100, 20);
            this.tbx_Int.TabIndex = 3;
            this.tbx_Int.Text = "Intelligence";
            this.tbx_Int.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbx_Int_DragDrop);
            this.tbx_Int.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbx_Int_DragEnter);
            // 
            // tbx_Wis
            // 
            this.tbx_Wis.Location = new System.Drawing.Point(320, 197);
            this.tbx_Wis.Name = "tbx_Wis";
            this.tbx_Wis.Size = new System.Drawing.Size(100, 20);
            this.tbx_Wis.TabIndex = 4;
            this.tbx_Wis.Text = "Wisdom";
            this.tbx_Wis.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbx_Wis_DragDrop);
            this.tbx_Wis.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbx_Wis_DragEnter);
            // 
            // tbx_Char
            // 
            this.tbx_Char.Location = new System.Drawing.Point(320, 223);
            this.tbx_Char.Name = "tbx_Char";
            this.tbx_Char.Size = new System.Drawing.Size(100, 20);
            this.tbx_Char.TabIndex = 5;
            this.tbx_Char.Text = "Charisma";
            this.tbx_Char.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbx_Char_DragDrop);
            this.tbx_Char.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbx_Char_DragEnter);
            // 
            // lbl_base1
            // 
            this.lbl_base1.AutoSize = true;
            this.lbl_base1.Location = new System.Drawing.Point(45, 100);
            this.lbl_base1.Name = "lbl_base1";
            this.lbl_base1.Size = new System.Drawing.Size(0, 13);
            this.lbl_base1.TabIndex = 6;
            this.lbl_base1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_base1_MouseDown);
            // 
            // lbl_base2
            // 
            this.lbl_base2.AutoSize = true;
            this.lbl_base2.Location = new System.Drawing.Point(45, 126);
            this.lbl_base2.Name = "lbl_base2";
            this.lbl_base2.Size = new System.Drawing.Size(0, 13);
            this.lbl_base2.TabIndex = 7;
            this.lbl_base2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_base2_MouseDown);
            // 
            // lbl_base3
            // 
            this.lbl_base3.AutoSize = true;
            this.lbl_base3.Location = new System.Drawing.Point(45, 152);
            this.lbl_base3.Name = "lbl_base3";
            this.lbl_base3.Size = new System.Drawing.Size(0, 13);
            this.lbl_base3.TabIndex = 8;
            this.lbl_base3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_base3_MouseDown);
            // 
            // lbl_base4
            // 
            this.lbl_base4.AutoSize = true;
            this.lbl_base4.Location = new System.Drawing.Point(45, 178);
            this.lbl_base4.Name = "lbl_base4";
            this.lbl_base4.Size = new System.Drawing.Size(0, 13);
            this.lbl_base4.TabIndex = 9;
            this.lbl_base4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_base4_MouseDown);
            // 
            // lbl_base5
            // 
            this.lbl_base5.AutoSize = true;
            this.lbl_base5.Location = new System.Drawing.Point(45, 204);
            this.lbl_base5.Name = "lbl_base5";
            this.lbl_base5.Size = new System.Drawing.Size(0, 13);
            this.lbl_base5.TabIndex = 10;
            this.lbl_base5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_base5_MouseDown);
            // 
            // lbl_base6
            // 
            this.lbl_base6.AutoSize = true;
            this.lbl_base6.Location = new System.Drawing.Point(45, 230);
            this.lbl_base6.Name = "lbl_base6";
            this.lbl_base6.Size = new System.Drawing.Size(0, 13);
            this.lbl_base6.TabIndex = 11;
            this.lbl_base6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_base6_MouseDown);
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(161, 12);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(135, 59);
            this.btn_roll.TabIndex = 12;
            this.btn_roll.Text = "Roll";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // btn_saveBase
            // 
            this.btn_saveBase.Location = new System.Drawing.Point(184, 261);
            this.btn_saveBase.Name = "btn_saveBase";
            this.btn_saveBase.Size = new System.Drawing.Size(75, 23);
            this.btn_saveBase.TabIndex = 13;
            this.btn_saveBase.Text = "Save Base Stats";
            this.btn_saveBase.UseVisualStyleBackColor = true;
            this.btn_saveBase.Click += new System.EventHandler(this.btn_saveBase_Click);
            // 
            // BaseRolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 307);
            this.Controls.Add(this.btn_saveBase);
            this.Controls.Add(this.btn_roll);
            this.Controls.Add(this.lbl_base6);
            this.Controls.Add(this.lbl_base5);
            this.Controls.Add(this.lbl_base4);
            this.Controls.Add(this.lbl_base3);
            this.Controls.Add(this.lbl_base2);
            this.Controls.Add(this.lbl_base1);
            this.Controls.Add(this.tbx_Char);
            this.Controls.Add(this.tbx_Wis);
            this.Controls.Add(this.tbx_Int);
            this.Controls.Add(this.tbx_Con);
            this.Controls.Add(this.tbx_Dex);
            this.Controls.Add(this.tbx_Str);
            this.Name = "BaseRolls";
            this.Text = "BaseRolls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseRolls_FormClosing);
            this.Load += new System.EventHandler(this.BaseRolls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Str;
        private System.Windows.Forms.TextBox tbx_Dex;
        private System.Windows.Forms.TextBox tbx_Con;
        private System.Windows.Forms.TextBox tbx_Int;
        private System.Windows.Forms.TextBox tbx_Wis;
        private System.Windows.Forms.TextBox tbx_Char;
        private System.Windows.Forms.Label lbl_base1;
        private System.Windows.Forms.Label lbl_base2;
        private System.Windows.Forms.Label lbl_base3;
        private System.Windows.Forms.Label lbl_base4;
        private System.Windows.Forms.Label lbl_base5;
        private System.Windows.Forms.Label lbl_base6;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Button btn_saveBase;
    }
}