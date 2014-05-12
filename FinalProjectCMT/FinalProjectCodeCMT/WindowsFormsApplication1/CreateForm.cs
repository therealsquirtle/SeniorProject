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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            //Random rndchar = new Random();
            //int chid = rndchar.Next(1000, 3000);
            //Charactervars.characterID = chid;
            Charactervars.characterID = 0;
            Charactervars.charName = "Nobody Owens";
            Charactervars.pName = "David Wong";
            Charactervars.cclass = "human";
            Charactervars.raceID = 0;
            Charactervars.age = 0;
            Charactervars.cLevel = 0;
            Charactervars.ECL = 0;
            Charactervars.size = "small";
            Charactervars.gender = "none";
            Charactervars.alignment = "none";
            Charactervars.religon = "none";
            Charactervars.height = 0;
            Charactervars.cweight = 0;
            Charactervars.cDescription = "This is the no variable description";
            Charactervars.touchAC = 0;
            Charactervars.flatAC = 0;
            Charactervars.hitPoints = 0;
            Charactervars.experiencePoints = 0;
            Charactervars.lightCarry = 0;
            Charactervars.medCarry = 0;
            Charactervars.heavyCarry = 0;
            Charactervars.Strength = 0;
            Charactervars.Dex = 0;
            Charactervars.Con = 0;
            Charactervars.Intell = 0;
            Charactervars.Wis = 0;
            Charactervars.Char = 0;
        }

        private void btnBaseRolls_Click(object sender, EventArgs e)
        {
            Form BaseRolls = new BaseRolls();
            BaseRolls.Show();
            btnSave.Enabled = true;

        }

        private void btnAttacks_Click(object sender, EventArgs e)
        {
            Form Attacks = new Attacks ();
            Attacks.Show();

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbConnect.insertinfo();
            dbConnect.getNum();
            btnAttacks.Enabled = true;
            btnSkills.Enabled = true;
            btnGear.Enabled = true;
            btnFeats.Enabled = true;

        }

        private void characterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDataSet1.Charactervars' table. You can move, or remove it, as needed.
        }

        private void tbxCharName_TextChanged(object sender, EventArgs e)
        {
            Charactervars.charName = tbxCharName.Text;
        }

        private void tbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            Charactervars.pName = tbxPlayerName.Text;
        }

        private void tbxClass_TextChanged(object sender, EventArgs e)
        {
            Charactervars.cclass = tbxClass.Text;
        }

        private void tbxLevel_TextChanged(object sender, EventArgs e)
        {
            Charactervars.cLevel = Convert.ToInt32(tbxLevel.Text);
        }

        private void tbxRace_TextChanged(object sender, EventArgs e)
        {
            Charactervars.raceID = Convert.ToInt32(tbxRace.Text);
        }

        private void tbxAlignment_TextChanged(object sender, EventArgs e)
        {
            Charactervars.alignment = tbxAlignment.Text;
        }

        private void tbxDiety_TextChanged(object sender, EventArgs e)
        {
            Charactervars.religon = tbxDiety.Text;
        }

        private void tbxSize_TextChanged(object sender, EventArgs e)
        {
            Charactervars.size = tbxSize.Text;
        }

        private void tbxAge_TextChanged(object sender, EventArgs e)
        {
            Charactervars.age = Convert.ToInt32(tbxAge.Text);
        }

        private void tbxGender_TextChanged(object sender, EventArgs e)
        {
            Charactervars.gender = tbxGender.Text;
        }

        private void tbx_description_TextChanged(object sender, EventArgs e)
        {
            Charactervars.cDescription = tbx_description.Text;
        }

   
        private void btnSkills_Click(object sender, EventArgs e)
        {
            Form Skills = new Skills();
            Skills.Show();
        }

        private void btnGear_Click(object sender, EventArgs e)
        {
            Form Gear = new Gear();
            Gear.Show();
        }

        private void btnFeats_Click(object sender, EventArgs e)
        {
            Form Feats = new Feats();
            Feats.Show();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form SelectionMenu = new SelectionMenu();
            SelectionMenu.Show();
        }

        private void Campaign_TextChanged(object sender, EventArgs e)
        {
            Charactervars.campaign = Campaign.Text;
        }

        void BaseRolls_enableSave() { btnSave.Enabled = true; }

        private void backToMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new SelectionMenu();
            main.Show();
        }

        private void loadACharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newChar = new SelectMenu();
            newChar.Show();
        }
    }
}
