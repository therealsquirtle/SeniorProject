namespace WindowsFormsApplication1
{
    partial class SelectionMenu
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
            this.btn_createNew = new System.Windows.Forms.Button();
            this.btn_loadExist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createNew
            // 
            this.btn_createNew.Location = new System.Drawing.Point(41, 100);
            this.btn_createNew.Name = "btn_createNew";
            this.btn_createNew.Size = new System.Drawing.Size(77, 60);
            this.btn_createNew.TabIndex = 0;
            this.btn_createNew.Text = "Create A New Character";
            this.btn_createNew.UseVisualStyleBackColor = true;
            this.btn_createNew.Click += new System.EventHandler(this.btn_createNew_Click);
            // 
            // btn_loadExist
            // 
            this.btn_loadExist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_loadExist.Location = new System.Drawing.Point(161, 100);
            this.btn_loadExist.Name = "btn_loadExist";
            this.btn_loadExist.Size = new System.Drawing.Size(75, 60);
            this.btn_loadExist.TabIndex = 1;
            this.btn_loadExist.Text = "Load an Existing Character";
            this.btn_loadExist.UseVisualStyleBackColor = true;
            this.btn_loadExist.Click += new System.EventHandler(this.btn_loadExist_Click);
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_loadExist);
            this.Controls.Add(this.btn_createNew);
            this.Name = "SelectionMenu";
            this.Text = "SelectionMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createNew;
        private System.Windows.Forms.Button btn_loadExist;
    }
}