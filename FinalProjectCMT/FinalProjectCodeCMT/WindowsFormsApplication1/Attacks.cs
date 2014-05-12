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
    public partial class Attacks : Form
    {
        public Attacks()
        {
            InitializeComponent();
            label1.Text = "Your character number is:  " + Charactervars.characterID;

        }

        private void Attacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dDCharDataSet.Combat' table. You can move, or remove it, as needed.
            this.combatTableAdapter.Fill(this.dDCharDataSet.Combat);
            this.combatTableAdapter.FillBy(this.dDCharDataSet.Combat, Charactervars.characterID);


        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form mainmnu = new SelectionMenu();
            mainmnu.Show();


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
            Form Create= new CreateForm();
            Create.Show();
        }

        private void Attacks_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.combatBindingSource.EndEdit();
                this.combatTableAdapter.Update(this.dDCharDataSet.Combat);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Update failed");
            }
        }

   


    }
}
