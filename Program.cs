using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace programme_collections
{
    class Program
    {

        static int SommeTableau(int[] t)
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
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "]" + tableau[i]);
            }
        }

        static void AfficherValeurMaximale(int[] t)
        {
            // La valeur maximale est : xx
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("La valeur maximal est : " + max);
        }

        static void AfficherValeurMinimale(int[] t)
        {
            // La valeur minimale est : xx
            int min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("La valeur maximal est : " + min);
        }

        static void Tableaux()
        {
            // int[] t = { 200, 40, 15, 8, 12 };
            const int TAILLE_TABLEAU = 20;

            // int[] t
            // Initialiser chaque élément valeur aléatoire entre 0 et 100

            int[] t = new int[TAILLE_TABLEAU];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(101);
            }


            AfficherTableau(t);
            AfficherValeurMaximale(t);
            AfficherValeurMinimale(t);

        }

        static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            if (!ordreDescendant) // = if (ordreDescendant == false)
            {
                for (int i = 0; i < liste.Count; i++) // Count sert à récupérer le nombre d'élément, le length du tableau est count pour les listes
                {
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                for (int i = liste.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            string nomLePlusLong = "";
            for (int i = 0; i < liste.Count; i++)
            {
                string nom = liste[i];
                if (nom.Length > nomLePlusLong.Length)
                {
                    nomLePlusLong = nom;
                }
            }

            Console.WriteLine("Le nom le plus long est : " + nomLePlusLong);
        }

        static void AfficherElementsCommuns(List<string> liste1, List<string> liste2)
        {
            for (int i = 0; i < liste1.Count; i++)
            {
                string nom1 = liste1[i];
                if (liste2.Contains(nom1))
                {
                    Console.WriteLine(nom1);
                }
            }
        }

        static void Listes()
        {
            /*List<int> liste = new List<int>(); // on utilise system.collections.generic avec clique droit < Refactorisation pour avoir la bonne collection

            liste.Add(5);
            liste.Add(8);
            liste.Add(2);
            liste.Add(2);
            liste.Add(2);

            // liste[2]++; va ajouter 1 à l'occurrence de 2 dans la liste
            // liste.Remove(8); va par exemple supprimer la première occurrence de 8 dans la liste
            // liste.RemoveAt(0); va supprimer l'élément à l'index 0

            AfficherListe(liste);*/


            /* List<string> noms = new List<string>(); // var noms = new List<string>(); est totalement équivalent
             while (true)
             {
                 Console.WriteLine("Rentrez un nom ('ENTER' pour finir) :");
                 string nom = Console.ReadLine();


                 if (nom == "")
                 {
                     break;
                 }

                 if (noms.Contains(nom))
                 {
                     Console.WriteLine("Erreur : ce nom est déjà dans la liste");
                     Console.WriteLine();
                 }
                 else
                 {
                     noms.Add(nom);

                 }

             }*/

            // List<string> lesPremiersNoms = noms.GetRange(0, 3); ici avec GetRange on prend une portée, ici on veut les 3 premiers noms

            // Filtrer : supprimer tous les noms qui terminent par le caractère 'e'/
            // RemoveAt / longueur de la liste est altérée
            // Boucler à partir de la fin quand on est sur une liste pour éviter bugs

            /*            for (int i = noms.Count - 1; i >= 0; i--)
                        {
                            string nom = noms[i];
                            if (nom[nom.Length-1] == 'e') // le -1 fait partir de la fin, et on utilise ' ' et non " " parce qu'on récupère un char (1 lettre)
                            {
                                noms.RemoveAt(i);
                            }

                        }

                        AfficherListe(noms, true);*/

            var liste1 = new List<string>() { "paul", "jean", "pierre", "emilie", "martin" };
            var liste2 = new List<string>() { "sophie", "jean", "martin", "toto" };
            // éléments en commun : jean, martin

            AfficherElementsCommuns(liste1, liste2);

        }

        static void ArrayList() // l'ArrayList est quasiment jamais utilisé, mixer les types n'est pas une bonne solution en programmation
        {
            ArrayList a = new ArrayList(); // ArrayList est un objet qui n'est pas strictement typé, on a pas eu de <string> <int> par exemple
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
            // France : Paris, Toulouse, Nice, Bordeaux, Lille <-- List<string>
            // Etats-Unis : New-York, Chicago, Los Angeles, San Francisco <-- List<string>
            // Espagne : Madrid, Barcelone, Séville <-- List<string>
            // Italie : Venise, Florence, Milan, Pise <-- List<string>

            /* var villes = new List<string>();
            villes.Add("France : Paris, Toulouse, Nice, Bordeaux, Lille");
            villes.Add("Etats-Unis : New-York, Chicago, Los Angeles, San Francisco");
            villes.Add("Espagne : Madrid, Barcelone, Séville");
            villes.Add("Italie : Venise, Florence, Milan, Pise")*/

            var pays = new List<List<string>>();

            pays.Add(new List<string> { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });
            pays.Add(new List<string> { "Etats-Unis", "New-York", "Chicago", "Los Angeles", "San Francisco" });
            pays.Add(new List<string> { "Italie", "Venise", "Florence", "Milan", "Pise" });

            for (int i = 0; i < pays.Count; i++)
            {
                var p = pays[i];
                Console.WriteLine(p[0] + " - " + (p.Count - 1) + " villes");
                for (int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine(" " + p[j]);
                }
                Console.WriteLine();
            }

        }


        static void Dictionnaire()
        {
            string personneAChercher = "Martin";
            // Dictionary
            // clef -> valeur
            // Nom -> numéro de téléphone
            var d = new Dictionary<string, string>();
            d.Add("Jean", "0622336655");
            d.Add("Marie", "0688995577");
            d["Martin"] = "0644885522";
            d["Toto"] = "0645128973";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]);

            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvée");
            }

            // Liste string [2]nom numéro de tel
            var l = new List<string[]>();
            l.Add(new string[] { "Jean", "0622336655" });
            l.Add(new string[] { "Marie", "0688995577" });
            l.Add(new string[] { "Martin", "0644885522" });
            l.Add(new string[] { "Toto", "0645128973" });

            for (int i = 0; i < l.Count; i++) // La boucle for poser soucis lors de très nombreuses données, il est alors plus utile d'utiliser une clé -> valeur pour trouver direct le résultat
            {
                if (l[i][0] == personneAChercher)
                {
                    Console.WriteLine(l[i][1]);
                }
            }

        }


        static void BoucleForEach()
        {
            // var noms = new string[] { "Toto", "Jean", "Pierre" }; -> tableau
            // var noms = new List<string>() { "Toto", "Jean", "Pierre" }; -> Liste
            /*            for (int i = 0; i < noms.Length; i++)
                        {
                            Console.WriteLine(noms[i]);
                        }*/

            /*            foreach(var nom in noms)
                        {
                            Console.WriteLine(nom);
                        }*/

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0622336655");
            d.Add("Marie", "0688995577");
            d["Martin"] = "0644885522";
            d["Toto"] = "0645128973";

            foreach (var e in d)
            {
                Console.WriteLine(e.Key + " -> " + e.Value);
            }
        }

        static void TrisEtLinq()
        {
            /*        var noms = new List<string>() { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Martin", "Benoit", "Vincent" };

                      //noms.Sort(); -> trie par ordre alphabétique
                      //Array.Sort(noms); -> trie dans un tableau où "new List<string>()" serait "new string []"
                      var nomsTries = noms.OrderBy(nom => nom); // -> trie par ordre alphabétique
                      // un noms.Where(nom => nom.Length > 4) ici Where permet de rentrer plus de critère : ici on veut les noms qui font + de 4 caractères

                      foreach (var nom in nomsTries)
                      {
                            Console.WriteLine(nom);
                      }*/

            var notes = new List<int> { 4, 8, 1, 9, 2 };
            // notes = notes.OrderBy(n => n).ToList(); ici un OrderBy(n => -n).ToList(); -> équivaut à un OrderByDescending
            notes = notes.Where(n => n >= 5).ToList();
            foreach (var n in notes)
            {
                Console.WriteLine(n);
            }

        }

        static void PassageValeursOuRef()
        {

        }

        static void Main(string[] args) // avec ce args on va récupérer des arguments
        {
            // Tableaux();
            // Listes();
            // ArrayList();
            // ListesDeListes();
            // Dictionnaire();
            // BoucleForEach();
            // TrisEtLinq();
            PassageValeursOuRef();
        }
    }
}
