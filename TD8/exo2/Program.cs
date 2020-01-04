using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Puissance4
    {

        public static string[,] initialiserGrille()
        {
            int nbCol = 7;
            int nbRow = 6;
            string[,] grille = new string[nbRow, nbCol];
            for (int ligne = 0; ligne < grille.GetLength(0); ligne++)
            {
                for (int col = 0; col < grille.GetLength(1); col++)
                {
                    grille[ligne, col] = " ";
                }
            }

            return grille;
        }

        public static void afficheBords()
        {
            for(int i= 0; i < 7; i++)
            {
                Console.Write("+-");
            }
            Console.WriteLine("+");
        }

        public static void afficheLigne(string[,] tab, int ligne)
        {
            for(int i = 0; i < 7; i++)
            {
                Console.Write($":{tab[ligne, i]}");
            }
            Console.WriteLine(":");
        }

        public static void afficheGrille(string[,] grille)
        {
            for(int i = 0; i < 6; i++)
            {
                afficheBords();
                afficheLigne(grille, i);
            }
            afficheBords();
            
            for(int i = 0; i < 7; i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");
            //Console.ReadKey();
        }

        public static bool colonneRemplie(int num, string[,] grille)
        {
            int count = 0;

            for(int row = 0; row < grille.GetLength(0); row++)
            {
                if(grille[row, num] != " ")
                {
                    count++;
                }
            }

            if(count == grille.GetLength(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool grilleRemplie(string[,] grille)
        {
            int count = 0;
            for(int col = 0; col < grille.GetLength(1); col++)
            {
                if(colonneRemplie(col, grille))
                {
                    count++;
                }
            }

            if(count == grille.GetLength(1))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static string[,] jouer(string[,] grille, string joueur, string symbole, out int x, out int y)
        {
            Console.Write($"{joueur} : Colonne n°");
            int colonne = Int32.Parse(Console.ReadLine());

            if(colonneRemplie(colonne, grille))
            {
                Console.WriteLine("Cette colonne est remplie");
                jouer(grille, joueur, symbole, out x, out y);
            }

            else
            {
                for (int row = grille.GetLength(0) - 1; row >= 0; row--)
                {
                    if (grille[row, colonne] == " ")
                    {
                        x = colonne;
                        y = row;
                        grille[row, colonne] = symbole;
                        return grille;
                    }
                }
            }

            //triche pour éviter une erreur relou
            x = 0;
            y = 0;
            return grille;
            
        }

        public static bool gagner(string[,] grille)
        {
            Console.WriteLine("La partie est-elle gagnée ? Taper \"oui\" ou \"non\"");
            string rep = Console.ReadLine();

            if(rep == "oui")
            {
                return true;
            }

            else if (rep == "non")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Je n'ai pas compris votre réponse");
                return gagner(grille);
            }
        }

        public static bool gagne(string[,] grille, int x, int y)
        {
            int count;
            string signe;
            Console.WriteLine($"x = {x}, y = {y}");

            //recherche gauche
            if(x-3 >= 0)
            {
                count = 1;
                signe = grille[y, x];
                for(int col = x-1; col >= x-3; col--)
                {
                    if(grille[y, col] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(count >= 4)
                {
                    return true;
                }
            }

            //recherche haut
            if (y - 3 >= 0)
            {
                count = 1;
                signe = grille[y, x];
                for (int ligne = y - 1; ligne >= y - 3; ligne--)
                {
                    if (grille[ligne, x] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }
            //recherche droite
            if (x + 3 < grille.GetLength(1))
            {
                count = 1;
                signe = grille[y, x];
                for (int col = x + 1; col <= x+3; col++)
                {
                    if (grille[y, col] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }

            //recherche bas
            if (y + 3 < grille.GetLength(0))
            {
                count = 1;
                signe = grille[y, x];
                for (int ligne = y + 1; ligne <= y+3; ligne++)
                {
                    if (grille[ligne, x] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }

            //diagonale bas droite
            if(y + 3 < grille.GetLength(0) & x + 3 < grille.GetLength(1))
            {
                count = 1;
                signe = grille[y, x];
                for (int i = 1; i <=3 ; i++)
                {
                    if (grille[y + i, x + i] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }

            //diagonale haut droit
            if (y - 3 >= 0 & x + 3 < grille.GetLength(1))
            {
                count = 1;
                signe = grille[y, x];
                for (int i = 1; i <= 3; i++)
                {
                    if (grille[y - i, x + i] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }

            //diagonale bas gauche
            if (y + 3 < grille.GetLength(0) & x - 3 >= 0)
            {
                count = 1;
                signe = grille[y, x];
                for (int i = 1; i <= 3; i++)
                {
                    if (grille[y + i, x - i] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }

            //diagonale haut gauche
            if (y - 3 >= 0 & x - 3 >= 0)
            {
                count = 1;
                signe = grille[y, x];
                for (int i = 1; i <= 3; i++)
                {
                    if (grille[y - i, x - i] == signe)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count >= 4)
                {
                    return true;
                }
            }

            //si rien trouvé
            return false;
            
        }

        static void Main(string[] args)
        {
            string[] noms = new string[2];
            Console.Write("Nom joueur 1 : ");
            noms[0] = Console.ReadLine();
            Console.Write("Nom joueur 2 : ");
            noms[1] = Console.ReadLine();

            string[] symboles = { "X", "O" };
            Console.WriteLine($"Symbole {noms[0]} = {symboles[0]},  Symbole {noms[1]} = {symboles[1]}");

            //coordonnées des positions jouées
            int x;
            int y;

            bool partieFinie = false;
            bool stopJouer = false;

            while(stopJouer == false)
            {
                string[,] grille = initialiserGrille();
                afficheGrille(grille);
                while (partieFinie == false)
                {
                    
                    grille = jouer(grille, noms[0], symboles[0], out x, out y);
                    afficheGrille(grille);
                    partieFinie = gagne(grille, x, y);

                    if (partieFinie)
                    {
                        Console.WriteLine($"{noms[0]} a gagné");
                        break;
                    }

                    grille = jouer(grille, noms[1], symboles[1], out x, out y);
                    afficheGrille(grille);
                    partieFinie = gagne(grille, x, y);

                    if (partieFinie)
                    {
                        Console.WriteLine($"{noms[1]} a gagné");
                        break;
                    }

                    if (grilleRemplie(grille))
                    {
                        partieFinie = true;
                    }
                }

                Console.WriteLine("Voulez-vous rejouer ? Répondez \"oui\" ou \"non\"");
                string rejouer = Console.ReadLine();

                if(rejouer == "oui")
                {
                    stopJouer = false;
                    partieFinie = false;
                }
                else
                {
                    stopJouer = true;
                }
            }
            

        }
    }
}
