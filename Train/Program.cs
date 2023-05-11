using System;
using System.Collections;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static int SommeTableaux(int[] t)
        {
            int somme = 0;
            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }
            return somme;
        }

        static void AfficherTableau(int[] tableau)
        {
            // [0] 200
            // [1] 40

            for(int i = 0; i < tableau.Length;i++)
            {
                Console.WriteLine($"[{i}] {tableau[i]}");
            }
        }

        static void AfficherValeurMaximale(int[] t)
        {
            //La valeur maximal est :
            var max = t[0];
            for(int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
            }

            Console.WriteLine($"La valeur maximal du tableau est : {max}");
        }

        static void AfficherValeurMinimal(int[] t)
        {
            //La valeur maximal est :
            var min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }

            Console.WriteLine($"La valeur minimal du tableau est : {min}");
        }
        static void Tableaux()
        {

            //int[] t = new int[5];
            //t[0] = 2;
            //t[1] = 4;
            //t[2] = 1;
            //t[3] = 5;
            //t[4] = 6;

            //int[] t = { 200,40,15,8,12 };
            const int TAILLE_TABLEAU = 20;

            //int[] t
            //Initialiser chaque element valeur aléatoire entre 0 et 100
            Random rand = new Random();
            int[] t = new int[TAILLE_TABLEAU];

            for(int i = 0; i < t.Length; i++)
            {
                int randNum = rand.Next(0, 100);
                t[i] = randNum;
            }

            AfficherTableau(t);
            AfficherValeurMaximale(t);
            AfficherValeurMinimal(t);
        }

        static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            if(ordreDescendant)
            {
                liste.Reverse();
            }
            for(int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }

            //var temp = "";
            //foreach(string str in liste)
            //{
            //    if(str.Length > temp.Length)
            //    {
            //        temp = str;
            //    }
            //}
            //Console.WriteLine($"Le prénom le plus long est : {temp}");
            
            
        }

        static void AfficherElementsCommuns(List<string> l1, List<string> l2)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (l2.Contains(l1[i]))
                {
                    Console.WriteLine(l1[i]);
                }   
            }
        }

        static void Listes()
        {
            //List<int> liste = new List<int>();
            //liste.Add(5);
            //liste.Add(8);
            //liste.Add(2);
            //liste.Add(1);
            //liste.Add(3);

            //liste[2]++;
            //liste.RemoveAt(1);

            //AfficherListe(liste);

            //List<string> noms = new List<string>();
            //while(true)
            //{
            //    Console.Write("Rentrez un nom (ENTER pour finir): ");
            //    string nom = Console.ReadLine();


            //    if (nom == "")
            //    {
            //        break;
            //    }

            //    if (noms.Contains(nom))
            //    {
            //        Console.WriteLine("Erreur, ce nom est déjà dans la liste");
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        noms.Add(nom);  
            //    }

            //}
            ////List<string> lesPremiersNoms = noms.GetRange(0, 3);

            ////Filtrer : Supprimer tous les noms qui se terminent par "e"

            //for (int i = noms.Count - 1; i >= 0 ; i--)
            //{
            //    string nom = noms[i];
            //    if(nom[nom.Length-1] == 'e')
            //    {
            //        noms.RemoveAt(i);
            //    }
            //}
            //AfficherListe(noms);

            var liste1 = new List<string>() { "paul", "jean", "pierre", "emilie", "martin"};
            var liste2 = new List<string>() { "sophie", "jean", "martin", "toto"};

            AfficherElementsCommuns(liste1, liste2);
        }

        static void ArrayList()
        {
            ArrayList a = new ArrayList();
            a.Add("Toto");
            a.Add(49);
            a.Add(true);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void ListesDeListes()
        {
            // France : Paris, Toulouse, Nice, Bordeaux, Lille
            // Etats-unis : New-York, Chicago, Los angeles, San Francisco
            // Espagne : Madrid, Barcelone, Séville
            // Italie : Venise, Florence, Milan, Pise

            var pays = new List<List<string>>();
            pays.Add(new List<string> { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });
            pays.Add(new List<string> { "Etats-unis", "New-York", "Chicago", "Los angeles", "San Francisco"});
            pays.Add(new List<string> { "Espagne", "Madrid", "Barcelone", "Séville"});
            pays.Add(new List<string> { "Italie", "Venise", "Florence", "Milan", "Pise" });

            for (int i = 0; i < pays.Count; i++)
            {
                var p = pays[i];
                Console.WriteLine($"{p[0]} - {p.Count - 1} villes");

                for (int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine($"   {p[j]}");
                }
            }
        }
        static void Dictionnaire()
        {
            string personneAChercher = "Martin";
            //var d = new Dictionary<string, string>();
            //d.Add("Jean", "0622334455");
            //d.Add("Marie", "0688334455");
            //d["Martin"] = "0678905632";
            //d["Toto"] = "0642905632";

            //if (d.ContainsKey(personneAChercher))
            //{
            //    Console.WriteLine(d[personneAChercher]);
            //}
            //else
            //{
            //    Console.WriteLine("Cette personne n'a pas été trouvée");
            //}

            //Liste string [2]nom numero de tel
            var l = new List<string[] >();
            l.Add(new string[] { "Jean", "0622334455" });
            l.Add(new string[] { "Marie", "0688334455" });
            l.Add(new string[] { "Martin", "0678905632" });
            l.Add(new string[] { "Toto", "0642434445" });

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i][0] == personneAChercher)
                {
                    Console.WriteLine(l[i][1]);
                    break;
                }
            }

        }

        static void TriEtLinq()
        {
            //var noms = new List<string>() { "Toto", "Jean", "Emilie", "Sophie", "Martin", "Benoit", "Vincent"};

            //noms.Sort();

            //foreach (var nom in noms)
            //{
            //    Console.WriteLine(nom);
            //}

            //var noms = new string[] { "Toto", "Jean", "Emilie", "Sophie", "Martin", "Benoit", "Vincent" };

            //Array.Sort(noms);

            //foreach (var nom in noms)
            //{
            //    Console.WriteLine(nom);
            //}

            var noms = new List<string>() { "Toto", "Jean", "Emilie", "Sophie", "Martin", "Benoit", "Vincent" };

            var nomTriers = noms.OrderBy(nom => nom);
            foreach (var nom in nomTriers)
            {
                Console.WriteLine(nom);
            }

            noms = noms.OrderBy(nom => nom).ToList(); //Tri par ordre alphabétique
            noms = noms.OrderByDescending(nom => nom).ToList(); //Tri par ordre alphabétique inverse
            noms = noms.OrderBy(nom => nom.Length).ToList(); //Tri par longueur de chaine
            noms = noms.Where(nom => nom.Length > 4).ToList();
            noms = noms.Where(nom => nom[nom.Length-1] == 'e').ToList();// pour filtrer les noms qui se terminent par "e"
            noms = noms.Where(nom => nom[nom.Length-1] != 'e').ToList();// pour filtrer les noms qui ne se terminent par "e"
            // On peut aussi utiliser le tri et le filtre en même temps
            //noms = noms.OrderBy(nom => nom.Length).Where(nom => nom[nom.Length - 1] == 'e').ToList();
            //On peut faire des tris et des filtres sur des listes de listes
            //On peut faire des tris et des filtres sur des dictionnaires
            //On peut faire des tris et des filtres sur des tableaux
            //On peut faire des tris et des filtres sur des arraylist
            //On peut faire des tris et des filtres sur des listes de tableaux
            //On peut faire des tris et des filtres sur des listes de dictionnaires
            //On peut faire des tris et des filtres sur des dictionnaires de listes
            //On peut faire des tris et des filtres sur des dictionnaires de dictionnaires
            //On peut faire des tris et des filtres sur des dictionnaires de tableaux
            //On peut faire des tris et des filtres sur des dictionnaires de arraylist
            //On peut faire des tris et des filtres sur des arraylist de listes
            //On peut faire des tris et des filtres sur des arraylist de dictionnaires
            //On peut faire des tris et des filtres sur des arraylist de tableaux
            //On peut faire des tris et des filtres sur des arraylist de arraylist
            // On peut faire la même chose avec des nombres
        }
        static void Main(string[] args)
        {
            //Tableaux();
            //Listes();
            //ArrayList();
            //ListesDeListes();
            //Dictionnaire();
            TriEtLinq();
        }
    }
}