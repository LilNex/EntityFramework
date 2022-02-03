using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        entityEntities db;
        commande selectedCommande;
        public void loadDgv()
        {
            dataGridView1.DataSource = db.commandes.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new entityEntities();


            loadDgv();
            cmbClient.DataSource = db.clients.ToList();
            cmbClient.DisplayMember = "nom";
            cmbClient.ValueMember = "id";

            comboBox2.DataSource = db.clients.ToList();
            comboBox2.DisplayMember = "nom";
            comboBox2.ValueMember = "id";

            //db.commandes.
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            commande c = new commande();
            //c.id = int.Parse(txtId.Text);
            c.DateCmd = dateTimePicker1.Value;
            c.montant = double.Parse(txtMontant.Text);
            c.idClient = int.Parse(cmbClient.SelectedValue.ToString());

            db.commandes.Add(c);

            DialogResult resultat = MessageBox.Show("Confirmer la commande ?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            //MessageBox.Show()
            //MessageBox.Show("Commande ajoutée");
            if ( resultat == DialogResult.Yes )                                                                         
            {
                db.SaveChanges();
                loadDgv();

            }
            else if (resultat == DialogResult.No)
            {
                MessageBox.Show("Vous avez annuler la commande");
                loadDgv();

            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            loadDgv();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //DataGridViewRow x = dataGridView1.Rows[i];
            //MessageBox.Show(x.Cells[1].Value.ToString());

            int i = dataGridView1.CurrentRow.Index;
            commande c = (commande)dataGridView1.Rows[i].DataBoundItem;

            afficher(c);
            


        }
        private void btnChercher_Click(object sender, EventArgs e)
        {
            commande c = db.commandes.Find(int.Parse(txtId.Text));



            afficher(c);
        }
        public void afficher(commande c)
        {
            txtId.Text = c.id.ToString();
            txtMontant.Text = c.montant.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(c.DateCmd);
            cmbClient.SelectedItem = c.client;

            selectedCommande = c;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCommande.montant = double.Parse(txtMontant.Text);
                selectedCommande.DateCmd = dateTimePicker1.Value;
                selectedCommande.idClient = int.Parse(cmbClient.SelectedValue.ToString());

                db.SaveChanges();

                selectedCommande = null;
                loadDgv();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Selectionnez une commande pour la modifier.");
                loadDgv();

            }


        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            
            try
            {
                commande c = db.commandes.Find(int.Parse(txtId.Text));
                db.commandes.Remove(c);
                //db.commandes.Remove(selectedCommande);
                db.SaveChanges();
                loadDgv();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Selectionnez une commande pour la supprimer.");
                loadDgv();

            }
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            double min = double.Parse(txtMin.Text);
            double max = double.Parse(txtMax.Text);
            var req = db.commandes.Where( (commande c) => c.montant > min && c.montant < max );
            dataGridView1.DataSource = req.ToList();
        }
    }
}
