using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    /*internal class Eleve
    {*/
        /*private string nom;
        private string prenom;
        private int age;

        public Eleve(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;


































































        }*/

        internal class Eleve : Personne
        {
            public List<double> ListeMoyennes { get; set; }

            public Eleve(string nom, string prenom, int age)
                : base(nom, prenom, age)
            {
                ListeMoyennes = new List<double>();
            }

            public double MoyenneGen()
            {
                if (ListeMoyennes.Count == 0)
                    return 0.0;

                double sommeMoyennes = 0.0;
                foreach (var moyenne in ListeMoyennes)
                {
                    sommeMoyennes += moyenne;
                }

                return sommeMoyennes / ListeMoyennes.Count;
            }

            public void AjouterMoyenne(double moyenne)
            {
                ListeMoyennes.Add(moyenne);
            }
        }

   // }
}
