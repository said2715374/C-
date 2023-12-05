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

        private string _auteur;
        private int _nombreDePage;

        public string Auteur
        {
            get => _auteur;
            set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author's name cannot be null or empty.");
                }
                _auteur = value;
            }
        }

        public int NombreDePage
        {
            get => _nombreDePage;
            set
            {
                // Constraint: The number of pages must be greater than zero.
                if (value <= 0)
                {
                    throw new ArgumentException("The number of pages must be greater than zero.");
                }
                _nombreDePage = value;
            }
        }


        public Livres(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case, string auteur, int numbreDePage) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            Auteur = auteur;
            NumbreDePage = numbreDePage;
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
        
        public override bool Disponibilite()
        {
            throw new NotImplementedException();
        }

        public override void Emplacement()
        {
            Console.WriteLine("Votre livre est dans :" + "\n" +
                               "L'étager :" + Etagere + "\n" +
                               "Numéro de case : " + NumeroCase);
        }

        public override void AfficheResume()
        {
            Console.WriteLine("Voici un resumé du votre livre : "+"\n"+Resume);
        }
    }
}
