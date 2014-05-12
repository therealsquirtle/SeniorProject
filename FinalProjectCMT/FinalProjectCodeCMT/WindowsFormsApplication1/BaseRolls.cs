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
    public partial class BaseRolls : Form
    {
        
        public BaseRolls()
        {
            InitializeComponent();
            lbl_base1.MouseDown += new MouseEventHandler(lbl_base1_MouseDown);
            tbx_Str.AllowDrop = true;
            tbx_Str.DragEnter += new DragEventHandler(tbx_Str_DragEnter);
            tbx_Str.DragDrop += new DragEventHandler(tbx_Str_DragDrop);

            tbx_Dex.AllowDrop = true;
            tbx_Dex.DragEnter += new DragEventHandler(tbx_Dex_DragEnter);
            tbx_Dex.DragDrop += new DragEventHandler(tbx_Dex_DragDrop);

            tbx_Con.AllowDrop = true;
            tbx_Con.DragEnter += new DragEventHandler(tbx_Con_DragEnter);
            tbx_Con.DragDrop += new DragEventHandler(tbx_Con_DragDrop);

            tbx_Int.AllowDrop = true;
            tbx_Int.DragEnter += new DragEventHandler(tbx_Int_DragEnter);
            tbx_Int.DragDrop += new DragEventHandler(tbx_Int_DragDrop);

            tbx_Wis.AllowDrop = true;
            tbx_Wis.DragEnter += new DragEventHandler(tbx_Wis_DragEnter);
            tbx_Wis.DragDrop += new DragEventHandler(tbx_Wis_DragDrop);

            tbx_Char.AllowDrop = true;
            tbx_Char.DragEnter += new DragEventHandler(tbx_Char_DragEnter);
            tbx_Char.DragDrop += new DragEventHandler(tbx_Char_DragDrop);
        }

        private void BaseRolls_Load(object sender, EventArgs e)
        {
            Charactervars.Char = 0;
            Charactervars.Dex = 0;
            Charactervars.Strength = 0;
            Charactervars.Wis = 0;
            Charactervars.Con = 0;
            Charactervars.Intell = 0;
        }


        private void btn_roll_Click(object sender, EventArgs e)
        {
            multiRoller droll = new multiRoller(6,6,6);

            lbl_base1.Text = droll.multiFinalResult[0].ToString();
            lbl_base2.Text = droll.multiFinalResult[1].ToString();
            lbl_base3.Text = droll.multiFinalResult[2].ToString();
            lbl_base4.Text = droll.multiFinalResult[3].ToString();
            lbl_base5.Text = droll.multiFinalResult[4].ToString();
            lbl_base6.Text = droll.multiFinalResult[5].ToString();
            


        }

        private void lbl_base1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl_base1.Text, DragDropEffects.Copy);
        }

        private void tbx_Str_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void tbx_Str_DragEnter(object sender, DragEventArgs e)
        {
            tbx_Str.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void lbl_base2_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl_base2.Text, DragDropEffects.Copy);
        }

        private void lbl_base3_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl_base3.Text, DragDropEffects.Copy);
        }

        private void lbl_base4_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl_base4.Text, DragDropEffects.Copy);
        }

        private void lbl_base5_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl_base5.Text, DragDropEffects.Copy);
        }

        private void lbl_base6_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(lbl_base6.Text, DragDropEffects.Copy);
        }

        private void tbx_Dex_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void tbx_Con_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void tbx_Int_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void tbx_Wis_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void tbx_Char_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) e.Effect = DragDropEffects.Copy;
        }

        private void tbx_Dex_DragEnter(object sender, DragEventArgs e)
        {
            tbx_Dex.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void tbx_Con_DragEnter(object sender, DragEventArgs e)
        {
            tbx_Con.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void tbx_Int_DragEnter(object sender, DragEventArgs e)
        {
            tbx_Int.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void tbx_Wis_DragEnter(object sender, DragEventArgs e)
        {
            tbx_Wis.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void tbx_Char_DragEnter(object sender, DragEventArgs e)
        {
            tbx_Char.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void btn_saveBase_Click(object sender, EventArgs e)
        {
            try
            {
                Charactervars.Char = Convert.ToInt32(tbx_Char.Text);
                Charactervars.Strength = Convert.ToInt32(tbx_Str.Text);
                Charactervars.Dex = Convert.ToInt32(tbx_Dex.Text);
                Charactervars.Con = Convert.ToInt32(tbx_Con.Text);
                Charactervars.Intell = Convert.ToInt32(tbx_Int.Text);
                Charactervars.Wis = Convert.ToInt32(tbx_Con.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: PLEASE ENTER NUMBERS IN ALL OF THE BASE BOXES");
                Charactervars.Char = 0;
                Charactervars.Dex = 0;
                Charactervars.Strength = 0;
                Charactervars.Wis = 0;
                Charactervars.Con = 0;
                Charactervars.Intell = 0;
            }
            
            
            
            
        }

        private void BaseRolls_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
