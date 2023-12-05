using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Livres : Documents
    {
       

        public string Auteur {  get; set; }
        public int NumbreDePage { get; set; }
        public List<string> chapitres = new List<string>();
        public Livres(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case, string auteur, int numbreDePage) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            Auteur = auteur;
            NumbreDePage = numbreDePage;
            this.Disponible = 1;
        }


        public override string ToString()
        {
            return base.ToString()+"Auteur : "+Auteur+"\n"+
                                    "Nombre de page : "+NumbreDePage;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Livres otherLivres = (Livres)obj;
            return base.Equals(obj) &&
                    NumeroCase == otherLivres.NumeroCase&&
                    Etagere == otherLivres.Etagere &&
                    Auteur == otherLivres.Auteur &&
                    NumbreDePage == otherLivres.NumbreDePage ;
        }

        public void AjouterChapitre(string chapitre)
        {
            chapitres.Add(chapitre);
        }

        public List<string> GetChapitres()
    {
            return chapitres;
        }




    }
}
