using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class frmCommande : Form
    {
        public frmCommande()
        {
            InitializeComponent();
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {
            //db = new modelEntities();
            cmbclient.DataSource = clsDb.db.clients.ToList() ;
            cmbclient.DisplayMember = "nom";
            cmbclient.ValueMember = "id";

            comboBox2.DataSource = clsDb.db.clients.ToList();
            comboBox2.DisplayMember = "nom";
            comboBox2.ValueMember = "id";

            dataGridView1.DataSource = clsDb.db.commandes.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            clsDb.AjouterCommande(dateTimePicker1.Value, float.Parse(txtMontant.Text), int.Parse(cmbclient.SelectedValue.ToString()));

        }

        private void cmbclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            commande obj = (commande)dataGridView1.Rows[i].DataBoundItem;
            txtId.Text = obj.id.ToString();
            txtMontant.Text = obj.montant.ToString();
            dateTimePicker1.Value = DateTime.Parse(obj.DateCmd.ToString());
            cmbclient.SelectedItem = obj.client;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viderForm();
        }

        public void viderForm()
        {
            txtId.Text = "";
            txtMontant.Text = String.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cmbclient.Text = "";
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var req2 = clsDb.db.commandes.Where(
                (commande c) => c.id == id
            );

            var req = from x in clsDb.db.commandes
                      where x.id == id
                      join cl in clsDb.db.clients on x.client equals cl
                      select new { x, cl };

            dataGridView1.DataSource = req.ToList();
        }
    }
}
