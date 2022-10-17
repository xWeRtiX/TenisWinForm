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
    public partial class Form1 : Form
    {
        // Vytvoření proměnných pro využití daných Formů.
        EditForm tenistaForm = new EditForm();
        TurnajForm turnajForm = new TurnajForm();

        public Form1()
        {
            InitializeComponent();
            dgvVolniHraci.DataSource = Databaze.Hraci;
            dgvTurnaje.DataSource = Databaze.Turnaje;
            SetButtons();
        }

        private void btnPridat_Click(object sender, EventArgs e) // Přidávání hráčů do turnajů
        {
            Databaze.Pridat(dgvVolniHraci.CurrentRow.DataBoundItem, dgvTurnaje.CurrentRow.DataBoundItem);
            SetButtons();
        }

        private void btnOdebrat_Click(object sender, EventArgs e) // Odebírá hráče z turnaje
        {
            Databaze.Odebrat(dgvHraciTurnaje.CurrentRow.DataBoundItem, dgvTurnaje.CurrentRow.DataBoundItem);
            SetButtons();
        }

        private void SetButtons() // Povoluje nebo blokuje tlačítka které by v daných případech neměly smysl.
        {
            btnPridat.Enabled = (dgvVolniHraci.Rows.Count > 0);
            btnOdebrat.Enabled = (dgvHraciTurnaje.Rows.Count > 0);
            btnOdebratTenistu.Enabled = (dgvVolniHraci.Rows.Count > 0);
            btnOdstranitTurnaj.Enabled = (dgvTurnaje.Rows.Count > 0);
        }

        private void dgvTurnaje_SelectionChanged(object sender, EventArgs e)
        {
            dgvHraciTurnaje.DataSource = ((Turnaj)dgvTurnaje.CurrentRow.DataBoundItem).HranyTurnaj;
            SetButtons();
        }

        private void Form1_FormClosed(object sender, EventArgs e)
        {
            Databaze.Serializuj();
        }

        private void btnPridatTenistu_Click(object sender, EventArgs e) // Vyvolá dialog s ActionType.New pro vytvoření nového tenisty.
        {
            tenistaForm.Action = ActionType.New;
            if (tenistaForm.ShowDialog() == DialogResult.OK)
            {
                Databaze.Hraci.Add(tenistaForm.PlayerInstance);
            }

        }
        private void btnOdebratTenistu_Click(object sender, EventArgs e) // Smaže tenistu
        {
            Databaze.Hraci.Remove((Hrac)dgvVolniHraci.CurrentRow.DataBoundItem);
        }

        private void btnUpravitTenistu_Click(object sender, EventArgs e) // Vyvolá dialog s ActionType.Edit pro upravení tenisty.
        {
            tenistaForm.Action = ActionType.Edit;
            tenistaForm.PlayerInstance = (Hrac)dgvVolniHraci.CurrentRow.DataBoundItem;
            tenistaForm.ShowDialog();
        }

        private void btnVytvoritTurnaj_Click(object sender, EventArgs e) // Vyvolá dialog pro vytvoření turnaje
        {
            turnajForm.Action = ActionType.New;
            if (turnajForm.ShowDialog() == DialogResult.OK)
            {
                Databaze.Turnaje.Add(turnajForm.MatchInstance);
            }
        }

        private void btnUpravitTurnaj_Click(object sender, EventArgs e) // Vyvolá dialog pro úpravu turnaje
        {
            turnajForm.Action = ActionType.Edit;
            turnajForm.MatchInstance = (Turnaj)dgvTurnaje.CurrentRow.DataBoundItem;
            turnajForm.ShowDialog();
        }

        private void btnOdstranitTurnaj_Click(object sender, EventArgs e) // Smaže turnaj
        {
            Turnaj t = (Turnaj)dgvTurnaje.CurrentRow.DataBoundItem;
            foreach (DataGridViewRow item in dgvHraciTurnaje.Rows)
            {
                Databaze.Odebrat(item.DataBoundItem, dgvTurnaje.CurrentRow.DataBoundItem);
            }
            
            Databaze.Turnaje.Remove(t);

        }
    }
}
