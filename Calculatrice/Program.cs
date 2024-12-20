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

            bool isOver = false;
            bool isCalculated = false;

            string currentNumber = "";
            string previousNumber = "";
            string resultat = "";

            do
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine(resultat);

                Console.Write($"{(option == 0 ? decorator : "")}[ 7 ]\u001b[0m"); // 7
                Console.Write($"{(option == 1 ? decorator : "")}[ 8 ]\u001b[0m"); // 8
                Console.Write($"{(option == 2 ? decorator : "")}[ 9 ]\u001b[0m"); // 9
                Console.Write($"{(option == 3 ? decorator : "")}[ + ]\u001b[0m\n"); // +
                Console.Write($"{(option == 4 ? decorator : "")}[ 4 ]\u001b[0m"); // 4
                Console.Write($"{(option == 5 ? decorator : "")}[ 5 ]\u001b[0m"); // 5
                Console.Write($"{(option == 6 ? decorator : "")}[ 6 ]\u001b[0m"); // 6
                Console.Write($"{(option == 7 ? decorator : "")}[ - ]\u001b[0m\n"); // -
                Console.Write($"{(option == 8 ? decorator : "")}[ 1 ]\u001b[0m"); // 1
                Console.Write($"{(option == 9 ? decorator : "")}[ 2 ]\u001b[0m"); // 2
                Console.Write($"{(option == 10 ? decorator : "")}[ 3 ]\u001b[0m"); // 3
                Console.Write($"{(option == 11 ? decorator : "")}[ * ]\u001b[0m\n"); // *
                Console.Write($"{(option == 12 ? decorator : "")}[ R ]\u001b[0m"); // R
                Console.Write($"{(option == 13 ? decorator : "")}[ 0 ]\u001b[0m"); // 0
                Console.Write($"{(option == 14 ? decorator : "")}[ = ]\u001b[0m"); // =
                Console.Write($"{(option == 15 ? decorator : "")}[ / ]\u001b[0m\n"); // /

                key = Console.ReadKey(false);
                Console.WriteLine($"Key pressed: {key.Key}");

                switch (key.Key)
                {
                    case ConsoleKey.Escape: // pour sortir de mon programme
                        isOver = true;
                        break;

                    case ConsoleKey.LeftArrow:
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

                    case ConsoleKey.Enter:

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
                                if (isCalculated) // manque opérateur 
                                {
                                    Console.Clear();
                                    previousNumber = currentNumber;
                                    currentNumber = "";
                                    currentNumber += boutons[option];
                                    resultat = currentNumber;
                                }
                                else
                                {
                                    Console.Clear();
                                    currentNumber += boutons[option];
                                    resultat = currentNumber;
                                }

                                break;

                            case "+":
                                if (operateur == "")
                                {
                                    Console.Clear();
                                    previousNumber = currentNumber;
                                    currentNumber = "";
                                    resultat = previousNumber;
                                    operateur = "+";
                                }
                                else
                                {
                                    resultat = "Err !";
                                }
                                break;

                            case "-":
                                if (operateur == "")
                                {
                                    Console.Clear();
                                    previousNumber = currentNumber;
                                    currentNumber = "";
                                    resultat = currentNumber;
                                    operateur = "-";
                                }
                                else
                                {
                                    resultat = "Err !";
                                }
                                break;

                            case "*":
                                if (operateur == "")
                                {
                                    Console.Clear();
                                    previousNumber = currentNumber;
                                    currentNumber = "";
                                    resultat = currentNumber;
                                    operateur = "*";
                                }
                                else
                                {
                                    resultat = "Err !";
                                }

                                break;

                            case "/":
                                if (operateur == "")
                                {
                                    Console.Clear();
                                    previousNumber = currentNumber;
                                    currentNumber = "";
                                    resultat = currentNumber;
                                    operateur = "/";
                                }
                                else
                                {
                                    resultat = "Err !";
                                }
                                break;

                            case "R": // RESET de toutes mes valeurs stockées
                                Console.Clear();
                                previousNumber = "";
                                currentNumber = "";
                                resultat = "";
                                operateur = "";
                                break;

                            case "=":
                                if (operateur != "")
                                {
                                    switch (operateur)
                                    {
                                        case "*":
                                            resultat = (double.Parse(previousNumber) * double.Parse(currentNumber)).ToString("0.##");
                                            break;
                                        case "+":
                                            resultat = (double.Parse(previousNumber) + double.Parse(currentNumber)).ToString("0.##");
                                            break;
                                        case "-":
                                            resultat = (double.Parse(previousNumber) - double.Parse(currentNumber)).ToString("0.##");
                                            break;
                                        case "/":
                                            if (currentNumber != "0")
                                            {
                                                resultat = (double.Parse(previousNumber) / double.Parse(currentNumber)).ToString("0.##");
                                            }
                                            else
                                            {
                                                resultat = "Erreur !";
                                            }

                                            break;

                                    }

                                }

                                Console.Clear();
                                currentNumber = resultat.ToString();
                                isCalculated = true;
                                operateur = "";

                                break;

                        }

                        break;
                }


                Console.SetCursorPosition(left, 10);
                Console.WriteLine("CONTROLE");
                Console.WriteLine("CurrentNumber = " + currentNumber); // le problème intervient quand j'ai plusieurs chiffres à la suite dans current après un résultat
                Console.WriteLine("Previous = " + previousNumber);
                Console.WriteLine("Opérateur = " + operateur);
                Console.WriteLine("{0:D2}", option);

            }
            while (!isOver);



        }
    }
}

