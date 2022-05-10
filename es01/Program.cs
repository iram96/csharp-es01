// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ciao, scegli due numeri!");
            int number1;

            // TryParse prova a vedere se si tratta di una stringa, se no false
            if(!int.TryParse(System.Console.ReadLine(), out number1))
            {
                Console.WriteLine("Non hai inserito un numero");
                System.Environment.Exit(1);
                //^ termina il programma con una risposta ( 0 = Ok, 0 =/= Err)
            }
            int number2;
            //int number2 = int.Parse(System.Console.ReadLine());
            if (!int.TryParse(System.Console.ReadLine(), out number2))
            {
                Console.WriteLine("Non hai inserito un numero");
                System.Environment.Exit(1);
            }
            System.Console.WriteLine("risultato: {0}, {1}",
                Mol(number1, number2), "Ciao");

        }
        static int Mol(int number1, int number2)
        {
            
            return number1 * number2;
        }

    }
}
