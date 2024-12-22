using System;
using System.ComponentModel.Design;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] boutons = ["7", "8", "9", "+", "4", "5", "6", "-", "1", "2", "3", "*", "R", "0", "=", "/"];

            Console.CursorVisible = false;
            (int left, int top) = Console.GetCursorPosition();
            ConsoleKeyInfo key;

            string decorator = "\u001b[45m";
            int option = 0;

            string operateur = "";

            bool isOver = false; // passe à true si l'utilisateur fait esc 
            bool isCalculated = false; // est true quand un calcul a été réalisé précédemment 

            string currentNumber = "";
            string previousNumber = "";
            string resultat = "";

            bool assignerOperateur(string nouvelOperateur, ref string operateur, ref string previousNumber, ref string currentNumber)
            {
                if (operateur == "")
                {
                    Console.Clear();
                    operateur = nouvelOperateur;
                    previousNumber = currentNumber;
                    currentNumber = "";
                    return true;
                }
                else
                {
                    resultat = "Erreur : l'opérateur " + operateur + " est déjà assigné !";
                    return false;
                }
            }

            void Reset()
            {
                Console.Clear();
                previousNumber = "";
                currentNumber = "";
                resultat = "";
                operateur = "";
                isCalculated = false;
            }

            void affichageCalculatrice()
            {
                for (int i = 0; i < boutons.Length; i++)
                {
                    if ((i + 1) % 4 == 0)
                    {
                        Console.Write($"{(option == i ? decorator : "")}[ {boutons[i]} ]\u001b[0m\n");
                    }
                    else
                    {
                        Console.Write($"{(option == i ? decorator : "")}[ {boutons[i]} ]\u001b[0m");
                    }
                }
            }


            do
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine("Utilisez les flêches du clavier pour choisir une touche et entrée pour valider votre choix : \n");
                Console.WriteLine(resultat + "\n");
                //Console.WriteLine(resultat);

                //Console.WriteLine($"{(option == 1 ? decorator : "")}\u2554" + new string('\u2550', 3) + "\u2557\u001b[0m");
                //Console.WriteLine($"{(option == 1 ? decorator : "")}\u2551 {boutons[1]} ║\u001b[0m");
                //Console.WriteLine($"{(option == 1 ? decorator : "")}\u255A" + new string('\u2550', 3) + "\u255D\u001b[0m");
                ////Console.WriteLine("\u255A" + new string('\u2550', 3) + "\u255D");

                affichageCalculatrice();

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.Escape: // pour sortir du programme
                        isOver = true;
                        break;

                    case ConsoleKey.LeftArrow: // retour à l'extrémité inverse du tableau 
                        option = (option == 0) ? 15 : option - 1;
                        break;

                    case ConsoleKey.RightArrow:
                        option = (option == 15) ? 0 : option + 1;
                        break;

                    case ConsoleKey.UpArrow:
                        // si option == 0, 1, 2, 3 alors 12 sinon option -4
                        if (option == 0 || option == 1 || option == 2 || option == 3)
                        { option = 12; }
                        else
                        { option -= 4; }
                        break;

                    case ConsoleKey.DownArrow:
                        // si option == 12, 13, 14, 15 alors option -12 sinon option +4
                        if (option == 12 || option == 13 || option == 14 || option == 15)
                        { option -= 12; }
                        else
                        { option += 4; }
                        break;

                    case ConsoleKey.Enter: // quand l'utilisateur appuie sur entrée, on passe en paramètre la case correspondante 
                        switch (boutons[option])
                        {
                            case "1":
                            case "2":
                            case "3":
                            case "4":
                            case "5":
                            case "6":
                            case "7":
                            case "8":
                            case "9":
                            case "0":
                                                            
                                if (isCalculated && operateur == "") 
                                {
                                    Console.Clear();
                                    currentNumber = "";
                                    isCalculated = false;
                                    currentNumber += boutons[option];
                                    resultat = currentNumber;
                                } else
                                {
                                    Console.Clear();
                                    currentNumber += boutons[option];
                                    resultat = currentNumber;
                                }

                                break;

                            case "+":
                            case "-":
                            case "*":
                            case "/":

                                Console.Clear();
                                if (!assignerOperateur(boutons[option], ref operateur, ref previousNumber, ref currentNumber))
                                {
                                    Console.WriteLine(resultat);
                                }
                                break;

                            case "R": // RESET de toutes mes valeurs stockées
                                Reset();
                                break;

                            case "=":
                                if (operateur != "")
                                {
                                    if (double.TryParse(previousNumber, out double previous) && double.TryParse(currentNumber, out double current))
                                    {
                                        switch (operateur)
                                        {
                                            case "*":
                                                resultat = (previous * current).ToString("0.##"); break;
                                            case "+":
                                                resultat = (previous + current).ToString("0.##"); break;
                                            case "-":
                                                resultat = (previous - current).ToString("0.##"); break;
                                            case "/":
                                                if (current != 0) { resultat = (previous / current).ToString("0.##"); }
                                                else { resultat = "Erreur : Division par zéro impossible."; }
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        resultat = "Erreur : Entrée non valide.";
                                    }
                                } else
                                {
                                    resultat = "Erreur : pas d'opérateur assigné !";
                                }

                                Console.Clear();
                                currentNumber = resultat;
                                isCalculated = true;
                                operateur = "";
                                break;
                        }
                        break;
                }

                //Console.SetCursorPosition(0, 10);
                //Console.WriteLine("--- ZONE CONTROLE ---");
                //Console.WriteLine("Touche du clavier = " + key.Key);
                //Console.WriteLine("CurrentNumber = " + currentNumber);
                //Console.WriteLine("PreviousNumber = " + previousNumber);
                //Console.WriteLine("Opérateur = " + operateur);
                //Console.WriteLine("{0:D2}", option);
                //Console.WriteLine("iscalculated ? " + isCalculated);

            }
            while (!isOver);

        }
    }
}

