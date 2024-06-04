using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    internal class Professeur 
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public decimal Salaire { get; set; }

        
        public Professeur(string nom, string prenom, int age, decimal salaire)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Salaire = salaire;
        }

        // Méthode pour afficher les informations du professeur
        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}, Âge: {Age}, Salaire: {Salaire:C}");
        }

        public void Vieillir()
        {
            Age++;
        }

        public decimal CalculCout()
        {
            
            decimal coutTotal = Salaire * 12; 
            return coutTotal;
        }
    }

}
