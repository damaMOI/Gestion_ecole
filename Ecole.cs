using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    internal class Ecole
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public decimal Budget { get; set; }
        public List<Professeur> ListeProfesseurs { get; } = new List<Professeur>();
        public List<Eleve> ListeEleves { get; } = new List<Eleve>();


    public Ecole(string nom, string adresse, decimal budget)
    {
        Nom = nom;
        Adresse = adresse;
        Budget = budget;
    }

    public void AjouterProfesseur(Professeur professeur)
    {
        ListeProfesseurs.Add(professeur);
    }

    public void AjouterEleve(Eleve eleve)
    {
        ListeEleves.Add(eleve);
    }

    public void Afficher()
    {
        Console.WriteLine($"Nom de l'école : {Nom}");
        Console.WriteLine($"Adresse : {Adresse}");
        Console.WriteLine($"Budget disponible : {Budget:C}");
        Console.WriteLine($"Nombre de professeurs : {ListeProfesseurs.Count}");
        //Console.WriteLine($"Nombre d'élèves : {ListeEleves.Count}");

        Console.WriteLine("\nInformations des professeurs :");
        foreach (var professeur in ListeProfesseurs)
        {
            professeur.Afficher();
        }

        Console.WriteLine("\nInformations des élèves :");
        /*foreach (var eleve in ListeEleves)
        {
            Eleve eleve1 = new Eleve("Martin", "Sophie", 15);
            eleve.Afficher();
        }*/
    }
}
}
