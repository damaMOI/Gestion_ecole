using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Prénom : {Prenom}");
            Console.WriteLine($"Âge : {Age} ans");
        }

        public void Vieillir()
        {
            Age++;
        }
    }
}
