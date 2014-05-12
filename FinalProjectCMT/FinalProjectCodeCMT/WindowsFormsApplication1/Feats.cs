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
    public partial class Feats : Form
    {
        public Feats()
        {
            InitializeComponent();
            label1.Text = "Your character number is:  " + Charactervars.characterID;

        }

        private void Feats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dDCharDataSet1.Bonuses' table. You can move, or remove it, as needed.
            this.bonusesTableAdapter.Fill(this.dDCharDataSet1.Bonuses);
            this.bonusesTableAdapter.FillBy1(this.dDCharDataSet1.Bonuses, Charactervars.characterID);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
            Form Create = new CreateForm();
            Create.Show();
        }

        private void Feats_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.bonusesBindingSource.EndEdit();
                this.bonusesTableAdapter.Update(this.dDCharDataSet1.Bonuses);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Update failed");
            }
        }

       
            }

        }

