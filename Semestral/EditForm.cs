using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestral
{
    public enum ActionType { New, Edit};

    public partial class EditForm : Form
    {
        public ActionType Action { get; set; }
        public Hrac PlayerInstance { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_VisibleChanged(object sender, EventArgs e) // Při otevření dialogu v ActionType.Edit, se otevře dialog s již vyplněnými daty pro snadnější úpravu
        {
            if(Action == ActionType.Edit)
            {
                txtJmeno.Text = PlayerInstance.Jmeno;
                txtPrijmeni.Text = PlayerInstance.Prijmeni;
                txtPohlavi.Text = PlayerInstance.Pohlavi;
                numRok.Value = PlayerInstance.RokNarozeni;
                numVyhry.Value = PlayerInstance.Vyhral;
            }
            else
            {
                txtJmeno.Text = "";
                txtPrijmeni.Text = "";
                txtPohlavi.Text = "";
                numRok.Value = 1930;
                numVyhry.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) // Záleží na typu dialogu který vyskočí, dle toho se zvolí co se má v dialogu objevit.
        {
            if(Action == ActionType.New)
            {
                PlayerInstance = new Hrac(txtJmeno.Text, txtPrijmeni.Text, txtPohlavi.Text, (int)numRok.Value, (int)numVyhry.Value);
                Close();
            }
            else if (Action == ActionType.Edit)
            {
                PlayerInstance.Jmeno = txtJmeno.Text;
                PlayerInstance.Prijmeni = txtPrijmeni.Text;
                PlayerInstance.Pohlavi = txtPohlavi.Text;
                PlayerInstance.RokNarozeni = (int)numRok.Value;
                PlayerInstance.Vyhral = (int)numVyhry.Value;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) // Zavře dialog
        {
            Close();
        }
    }
}
