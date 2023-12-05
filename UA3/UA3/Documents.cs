using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal abstract class  Documents : Iresume
    {
        public string Titre {  get; set; }
        public string Resume { get; set; }
        public int Code { get; set; }
        public double Prix { get; set; }
        public string DateDexpedition { get; set; }
        public int NumeroCase { get; set; }
        public string Etagere { get; set; }

        public Documents(string titre, string resume, int code, double prix, string dateDexpedition)
        {
            Titre = titre;
            Resume = resume;
            Code = code;
            Prix = prix;
            DateDexpedition = dateDexpedition;
         }

        public override string ToString()
        {
            return "Titre : " + Titre + "\n" +
                "Code : " + Code + "\n" +
                "Prix : " + Prix + "\n" +
                "Date dexpedition : " + DateDexpedition;
        }

        public override bool Equals(object? obj)
        {// Vérifiez si l'objet passé n'est pas null et est du même type que cette instance
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Convertissez l'objet passé en instance de Documents pour pouvoir comparer les propriétés
            Documents otherDocument = (Documents)obj;

            // Comparez les valeurs des propriétés pour déterminer l'égalité
            return Titre == otherDocument.Titre &&
           Resume == otherDocument.Resume &&
           Code == otherDocument.Code &&
           Prix == otherDocument.Prix &&
           DateDexpedition == otherDocument.DateDexpedition;
        }


        public  void Emplacement()
        {
            Console.WriteLine("Votre livre est dans :" + "\n" +
                               "L'étager :" + Etagere + "\n" +
                               "Numéro de case : " + NumeroCase);
        }
        public abstract bool Disponibilite();

        public  void AfficheResume()
        {
            Console.WriteLine("Voici un resumé du votre livre : " + "\n" + Resume);
        }
        
    }
}
