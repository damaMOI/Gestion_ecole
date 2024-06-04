using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    internal class Program
    {
#pragma warning disable CS0017 // Plusieurs points d'entrée sont définis dans le programme. Compilez avec l'option /main pour spécifier le type qui contient le point d'entrée.
        static void Main(string[] args)
#pragma warning restore CS0017 // Plusieurs points d'entrée sont définis dans le programme. Compilez avec l'option /main pour spécifier le type qui contient le point d'entrée.
        {
            Ecole ecole = new Ecole("EPSI", "7 rue Jeam Marie", 60000);
            Personne personne1 = new Personne("Damarice", "Freddy", 30);
            Professeur professeur1 = new Professeur("Emane", "Nkoa", 40, 60000.0m);
            Eleve eleve1 = new Eleve("Martin", "Sophie", 16);

        }

        class Programe
        {
            static void Main(string[] args)
            {
                var ecole = new Ecole("Ecole ABC", "48 Rue du Roi", 69000);
                ecole.Afficher();

                var professeur = new Professeur("Nkoa", "Emame", 35, 50000);
                professeur.Afficher();
                Console.WriteLine($"Coût annuel du professeur : {professeur.CalculCout():C}");


                var eleve = new Eleve("Freddy", "Arsène", 16);
                eleve.AjouterMoyenne(16.5);
                eleve.AjouterMoyenne(13.0);
                Console.WriteLine($"Moyenne générale de l'élève : {eleve.MoyenneGen():F2}");
            }


            class Ecole
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
                    Console.WriteLine($"Nombre d'élèves : {ListeEleves.Count}");

                    Console.WriteLine("\nInformations des professeurs :");
                    foreach (var professeur in ListeProfesseurs)
                    {
                        professeur.Afficher();
                    }

                    Console.WriteLine("\nInformations des élèves :");
                    foreach (var eleve in ListeEleves)
                    {
                        Eleve eleve1 = new Eleve("Martin", "Sophie", 15);
                        eleve.Afficher();
                    }
                }
            }


            class Program
            {
                static void Main(string[] args)
                {
                    var ecole = new Ecole("Ecole ABC", "48 rue du Roi", 69000);

                    var professeur1 = new Professeur("Nkoa", "Emane", 35, 50000);
                    var professeur2 = new Professeur("Akiba", "Donevan", 40, 55000);
                    ecole.AjouterProfesseur(professeur1);
                    ecole.AjouterProfesseur(professeur2);

                    var eleve1 = new Eleve("Jorelle", "Leonel", 15);
                    var eleve2 = new Eleve("Leroy", "Emma", 14);
                    ecole.AjouterEleve(eleve1);
                    ecole.AjouterEleve(eleve2);

                    ecole.Afficher();


                }


                class Programe
                {
                    static void Main(string[] args)
                    {

                        var ecole = new Ecole("Ecole ABC", "123 Rue des Étudiants", 1000000);

                        var professeur1 = CreerProfesseur();
                        var professeur2 = CreerProfesseur();
                        ecole.AjouterProfesseur(professeur1);
                        ecole.AjouterProfesseur(professeur2);


                        var eleve1 = CreerEleve();
                        var eleve2 = CreerEleve();
                        ecole.AjouterEleve(eleve1);
                        ecole.AjouterEleve(eleve2);
                        ecole.Afficher();


                    }


                    static Professeur CreerProfesseur()
                    {
                        Console.WriteLine("Création d'un professeur :");
                        Console.Write("Nom : ");
                        string nom = Console.ReadLine();
                        Console.Write("Prénom : ");
                        string prenom = Console.ReadLine();
                        Console.Write("Âge : ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Salaire : ");
                        decimal salaire = decimal.Parse(Console.ReadLine());

                        return new Professeur(nom, prenom, age, salaire);
                    }


                    static Eleve CreerEleve()
                    {
                        Console.WriteLine("Création d'un élève :");
                        Console.Write("Nom : ");
                        string nom = Console.ReadLine();
                        Console.Write("Prénom : ");
                        string prenom = Console.ReadLine();
                        Console.Write("Âge : ");
                        int age = int.Parse(Console.ReadLine());

                        return new Eleve(nom, prenom, age);
                    }

                }
            }

        }
    }
}   
