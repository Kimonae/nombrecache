using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations
            int valeur, essai;

            //saisie du nombre à chercher
            Console.Write("Entrez le nombre à chercher = ");
            valeur = int.Parse(Console.ReadLine());
            Console.Clear();
            //Saisie du 1er essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
            //Boucle sur les essais 
            while (essai != valeur)
            { 
            
            //test de l'essai par rapport à la valeur à chercher
            if (essai > valeur)
            {
                Console.WriteLine("--> trop grand !");
           }
            else
            {
                Console.WriteLine("--> trop petit !");
            }
                //Saisie d'un essai
                Console.Write("Entrez un essai = ");
                essai = int.Parse(Console.ReadLine());
            }
            // valeur trouvée
            Console.WriteLine("Vous avez trouvé !");
            Console.ReadLine();
        }
        }
        }
