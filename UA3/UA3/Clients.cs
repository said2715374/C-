using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Clients
    {
        public class Client
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            

            public Client(string nom, string prenom, DateTime dateEmprunt)
            {
                Nom = nom;
                Prenom = prenom;
                DateEmprunt = dateEmprunt;
            }
            public override string ToString()
            {
                return base.ToString() + "nom : " + nom + "\n" +
                                    "prenom : " + prenom;
            }



        }
    }
