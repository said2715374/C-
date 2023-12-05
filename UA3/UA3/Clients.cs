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
            public DateTime DateEmprunt { get; set; }
            private List<Avis> avis = new List<Avis>();

            public Client(string nom, string prenom, DateTime dateEmprunt)
            {
                Nom = nom;
                Prenom = prenom;
                DateEmprunt = dateEmprunt;
            }
            public override string ToString()
            {
                return "Nom : "+Nom+"\n"+
                        "Prenom"+Prenom+"\n"+
                        "Date de l'emprunt"+DateEmprunt;
            }

            public override bool Equals(object? obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                Client otherClients = (Client)obj;

                return Nom == otherClients.Nom &&
                        Prenom == otherClients.Prenom &&
                        DateEmprunt == otherClients.DateEmprunt;
            }

            public void AjouterAvis(string commentaire, int note)
            {
                avis.Add(new Avis(commentaire, note));
            }


        }
    }
}
