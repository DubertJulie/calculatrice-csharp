using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Entrée des valeurs de l'utilisateur (à modif : tryparse) 
            //Console.Write("Entrez le premier nombre :");
            //double nombre1 = double.Parse(Console.ReadLine());
            //Console.Write("Entrez le deuxième nombre :");
            //double nombre2 = double.Parse(Console.ReadLine());

            //// Entrée de l'opérateur
            //Console.WriteLine("Choisissez un opérateur : + , - , * , /");
            //string operateur = Console.ReadLine();

            ////  Fonctions pour mes opérations de calcul
            //double Addition(double nombre1, double nombre2)
            //{ return nombre1 + nombre2; }

            //double Multiplication(double nombre1, double nombre2)
            //{ return nombre1 * nombre2; }

            //double Soustraction(double nombre1, double nombre2)
            //{ return nombre1 - nombre2; }

            //double Division(double nombre1, double nombre2)
            //{ return nombre1 / nombre2; }


            //// En fonction de l'opérateur choisi, déclenche la fonction correspondante 
            //if (operateur == "+")
            //{
            //    Console.WriteLine(Addition(nombre1, nombre2));
            //}
            //else if (operateur == "-")
            //{
            //    Console.WriteLine(Soustraction(nombre1, nombre2));
            //}
            //else if (operateur == "*")
            //{
            //    Console.WriteLine(Multiplication(nombre1, nombre2));
            //}
            //else if (operateur == "/" && nombre2 == 0)
            //{
            //    Console.WriteLine("La division par 0 n'est pas possible ");
            //}
            //else if (operateur == "/")
            //{
            //    Console.WriteLine(Division(nombre1, nombre2));
            //}


            //// DOCUMENTATION 
            //+---------------------------+
            //| [ 1,264.45              ] |
            //+---------------------------+
            //|                           |
            //| [ ( ] [ ) ] [sqr] [ / ] |
            //|                           |
            //| [ 7 ] [ 8 ] [ 9 ] [ * ] |
            //|                           |
            //| [ 4 ] [ 5 ] [ 6 ] [ - ] |
            //|                           |
            //| [ 1 ] [ 2 ] [ 3 ] [ + ] |
            //|                           |
            //| [ 0 ] [ . ] [+/-] [ = ] |
            //|                           |
            //+---------------------------+

            // A réutiliser pour entrer mes chiffres ?
            //Console.WriteLine("First Name: ");
            //Console.WriteLine("Last Name: ");
            //Console.WriteLine("Badge Number: ");
            //Console.SetCursorPosition(12, 0);
            //string fname = Console.ReadLine();
            //Console.SetCursorPosition(11, 1);
            //string lname = Console.ReadLine();
            //Console.SetCursorPosition(14, 2);
            //string badge = Console.ReadLine();

            // 

            //string[] boutons = ["7", "8", "9"];

            //ConsoleKeyInfo key;
            //key = Console.ReadKey(true);

            ////Console.Write(" [ " + boutons[0] + " ] ");
            ////Console.Write(" [ " + boutons[1] + " ] ");
            ////Console.Write(" [ " + boutons[2] + " ] ");

            //switch (key.Key)
            //{
            //    case ConsoleKey.LeftArrow:
            //        

            //}

            //https://learn.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.key?view=net-9.0
            //    ConsoleKeyInfo cki;
            //    // Prevent example from ending if CTL+C is pressed.
            //    Console.TreatControlCAsInput = true;

            //    Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            //    Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            //    do
            //    {
            //        cki = Console.ReadKey();
            //        Console.Write(" --- You pressed ");
            //        if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            //        if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            //        if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            //        Console.WriteLine(cki.Key.ToString());
            //    } while (cki.Key != ConsoleKey.Escape);


            //https://github.com/ricardogerbaudo/Console.InteractiveMenu/blob/main/Program.cs
            //Console.Clear();
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.CursorVisible = false;
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Welcome to the world of C#!");
            //Console.ResetColor();
            //Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
            //(int left, int top) = Console.GetCursorPosition();
            //var option = 1;
            //var decorator = "✅ \u001b[32m";
            //ConsoleKeyInfo key;
            //bool isSelected = false;

            //while (!isSelected)
            //{
            //    Console.SetCursorPosition(left, top);

            //    Console.WriteLine($"{(option == 1 ? decorator : "   ")}Option 1\u001b[0m");
            //    Console.WriteLine($"{(option == 2 ? decorator : "   ")}Option 2\u001b[0m");
            //    Console.WriteLine($"{(option == 3 ? decorator : "   ")}Option 3\u001b[0m");

            //    key = Console.ReadKey(false);

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            option = option == 1 ? 3 : option - 1;
            //            break;

            //        case ConsoleKey.DownArrow:
            //            option = option == 3 ? 1 : option + 1;
            //            break;

            //        case ConsoleKey.Enter:
            //            isSelected = true;
            //            break;
            //    }
            //}

            //Console.WriteLine($"\n{decorator}You selected Option {option}");
            //Console.ReadLine();

        }

    }
    }

