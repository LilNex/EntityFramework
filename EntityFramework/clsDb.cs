using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class clsDb
    {
         public static modelEntities db = new modelEntities();


        DateTime derniereValidation { get; set; }

        public static void AjouterCommande(DateTime dateCmd, float montant, int idClient)
        {
            commande c = new commande();
            c.DateCmd = dateCmd;
            c.montant = montant;
            c.idClient = idClient;
            Console.WriteLine("Commande crée");

            clsDb.db.commandes.Add(c);
            clsDb.db.SaveChanges();

            Console.WriteLine("Commande ajoutée");
        }



    }

}
