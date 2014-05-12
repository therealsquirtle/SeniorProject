using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Skills : Form
    {
        public Skills()
        {
            InitializeComponent();
            label1.Text = "Your character number is:  " + Charactervars.characterID;
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dDCharDataSet.Abilities' table. You can move, or remove it, as needed.
            this.abilitiesTableAdapter.Fill(this.dDCharDataSet.Abilities);

            this.abilitiesTableAdapter.FillBy1(this.dDCharDataSet.Abilities,Charactervars.characterID);
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form main = new SelectionMenu();
            main.Show();
        }

        private void backToSelctionMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form selMenu = new SelectMenu();
            selMenu.Show();
        }

        private void backToCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form editChar = new EditChar();
            editChar.Show();
        }

        private void createANewCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form crform = new CreateForm();
            crform.Show();
        }

        private void Skills_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.abilitiesBindingSource.EndEdit();
                this.abilitiesTableAdapter.Update(this.dDCharDataSet.Abilities);
              
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Update failed");
            }
        }

       
        }
    }

