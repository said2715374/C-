using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UA3
{
    internal class Magasines : Documents
    {
      

        public string Categories { get; set; }
        public string Article {  get; set; }
        public List<int> evaluationsArticles = new List<int>();

        public Magasines(string titre, string resume, int code, double prix, string dateDexpedition, string etager, int Case,string categories, string article) : base(titre, resume, code, prix, dateDexpedition)
        {
            this.NumeroCase = Case;
            this.Etagere = etager;
            Categories = categories;
            Article = article;
            this.Disponible = 1;
        }

        public override string ToString()
        {
            return base.ToString()+"Categorie : "+Categories+"\n"+
                                    "Article : "+Article;
        }

       public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public void AjouterEvaluationArticle(int evaluation)
        {
            evaluationsArticles.Add(evaluation);
        }

        public double CalculerMoyenneEvaluationsArticles()
        {
            if (evaluationsArticles.Count == 0)
                return 0;

            return evaluationsArticles.Average();
        }

          public List<int> GetEvaluationsArticles()
            {
                return evaluationsArticles;
            }
        }
    }

