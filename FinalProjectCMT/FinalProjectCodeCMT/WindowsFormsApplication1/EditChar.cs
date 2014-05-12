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
    public partial class EditChar : Form
    {
        public EditChar()
        {
            InitializeComponent();
        }

        private void EditChar_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'dDCharDataSet.Character' table. You can move, or remove it, as needed.
            this.characterTableAdapter.Fill(this.dDCharDataSet.Character);
            // TODO: This line of code loads data into the 'dDcharDataSet.Charactervars' table. You can move, or remove it, as needed.
            this.characterTableAdapter.FillBy(this.dDCharDataSet.Character, Charactervars.characterID);

        }

     

        private void btn_Attacks_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Attacks = new Attacks();
            Attacks.Show();
        }

        private void btn_Skills_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Skills = new Skills();
            Skills.Show();
        }

        private void btn_Gear_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Gear = new Gear();
            Gear.Show();
        }

        private void btn_Feats_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Feats = new Feats();
            Feats.Show();
        }

        private void createANewCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form CreateForm = new CreateForm();
            CreateForm.Show();
        }

        private void returnToMainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form mainmnu = new SelectionMenu();
            mainmnu.Show();
        }

        private void selectAnotherCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form selMenu = new SelectMenu();
            selMenu.Show();
        }

        private void createANewCharacterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form Create = new CreateForm();
            Create.Show();
        }


           private void EditChar_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.characterBindingSource.EndEdit();
                this.characterTableAdapter.Update(this.dDCharDataSet.Character);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Update failed");
            }
        }

  
      
    }
}
