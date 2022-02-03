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
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new entityEntities();

            dataGridView1.DataSource = db.commandes.ToList();

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




            //MessageBox.Show("Commande ajoutée");
            if (MessageBox.Show("Confirmer la commande ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Vous avez annuler la commande");
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.commandes.ToList();

        }
    }
}
