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
    public partial class SelectionMenu : Form
    {
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void btn_createNew_Click(object sender, EventArgs e)
        {
            Form Create = new CreateForm();
            this.Hide();
            Create.Show();
            
        }

        private void btn_loadExist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form SelectMenu = new SelectMenu();
            SelectMenu.Show();
        }


    }
}
