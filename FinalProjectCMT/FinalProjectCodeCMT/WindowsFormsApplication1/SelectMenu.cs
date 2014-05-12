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
    public partial class SelectMenu : Form
    {
        public SelectMenu()
        {
            InitializeComponent();
        }

        private void SelectMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dDCharDataSet.Character' table. You can move, or remove it, as needed.
            this.characterTableAdapter.Fill(this.dDCharDataSet.Character);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Charactervars.characterID = Convert.ToInt32(cbx_charChoose.SelectedValue);
            Form EditChar = new EditChar();
            this.Hide();
            EditChar.Show();
            
        }

        private void backToMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form mainmnu = new SelectionMenu();
            mainmnu.Show();
        }

        private void createANewCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Create = new CreateForm();
            Create.Show();
        }
    }
}
