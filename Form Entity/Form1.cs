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
            //db.commandes.
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            commande c = new commande();
            c.DateCmd = dateTimePicker1.Value;
            c.montant = double.Parse(txtMontant.Text);
            c.idClient = 1;

            db.commandes.Add(c);




            //MessageBox.Show("Commande ajoutée");
            if (MessageBox.Show("Confirmer la commande ?,", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Vous avez annuler la commande");
            }
        }
    }
}
