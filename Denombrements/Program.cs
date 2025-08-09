using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        // Fonction permutation
        static long Permutation(int nbrTotal)
        {
            long resultat = 1;
            for (int k = 1; k <= nbrTotal; k++)
                resultat *= k;
            return resultat;
        }

        // fonction arrangement
        static long Arrangement(int nbrTotal, int nbrSousEnsemble)
        {
            long resultat = 1;
            for (int k = (nbrTotal - nbrSousEnsemble + 1); k <= nbrTotal; k++)
                resultat *= k;
            return resultat;
        }

        //fonction long Combinaison
        static long Combinaison(int nbrTotal, int nbrSousEnsemble)
        {
            long resultat = Permutation(nbrTotal) / Arrangement(nbrTotal, nbrSousEnsemble);
            return resultat;
        }

        // fonction pour la saisie du choix
        static int Choix()
        {
            int c;
            do
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());
            } while (c < 0 && c > 3);
            int continuer = c;
            return continuer;
        }

        static void Main(string[] args)
        {
            int choix = 7;
            while (choix != 0)
            {
                choix = Choix();
                // executer une permutation 
                if (choix == 1)
                {
                    Console.WriteLine();
                    Console.Write("nombre total d'éléments = ");
                    int nbrTotal = int.Parse(Console.ReadLine());
                    long resultat = Permutation(nbrTotal);
                    Console.WriteLine("il y a " + resultat + " permutations possibles pour un ensemble de " + nbrTotal + " éléments ");
                    Console.WriteLine();
                }
                else
                {
                    if (choix == 2)
                    {
                        Console.WriteLine();
                        Console.Write("nombre total d'éléments = ");
                        int nbrTotal = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nbrSousEnsemble = int.Parse(Console.ReadLine());
                        long resultat = Arrangement(nbrTotal, nbrSousEnsemble);
                        Console.WriteLine("Il y a " + resultat + " arrangements possible de " + nbrSousEnsemble + "éléments dans un ensemble de " + nbrTotal + "éléments");
                        Console.WriteLine();
                    }
                    else
                    {
                        if (choix == 3)
                        {
                            Console.WriteLine();
                            Console.Write("nombre total d'éléments = ");
                            int nbrTotal = int.Parse(Console.ReadLine());
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbrSousEnsemble = int.Parse(Console.ReadLine());
                            long resultat = Combinaison(nbrTotal, nbrSousEnsemble);
                            Console.WriteLine("Il y a " + resultat + " combinaisons possible de " + nbrSousEnsemble + "éléments dans un ensemble de " + nbrTotal + "éléments");
                            Console.WriteLine();
                        }

                    }
                }
            }
            Console.ReadLine();
        }
        
    }
}
