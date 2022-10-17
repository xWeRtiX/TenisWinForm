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
    public partial class TurnajForm : Form
    {
        public ActionType Action { get; set; }

        public Turnaj MatchInstance { get; set; }
        public TurnajForm()
        {
            InitializeComponent();
        }
        private void TurnajForm_VisibleChanged(object sender, EventArgs e) // Dělá v podstatě to samé co v EditFormu.
        {
            if (Action == ActionType.Edit)
            {
                txtNazev.Text = MatchInstance.Nazev;
                txtTyp.Text = MatchInstance.Typ;
                numVyhry.Value = MatchInstance.Vyhra;
            }
            else
            {
                txtNazev.Text = "";
                txtTyp.Text = "";
                numVyhry.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Action == ActionType.New)
            {
                MatchInstance = new Turnaj(txtNazev.Text, txtTyp.Text, (int)numVyhry.Value);
                Close();
            }
            else if (Action == ActionType.Edit)
            {
                MatchInstance.Nazev = txtNazev.Text;
                MatchInstance.Typ = txtTyp.Text;
                MatchInstance.Vyhra = (int)numVyhry.Value;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
