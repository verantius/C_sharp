using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1. Napisz program sprawdzający czy imię wprowadzone z klawiatury jest imieniem męskim czy żeńskim (tradycyjne polskie imiona żeńskie kończą się na literę a.)

            Console.Write("Podaj imie:\n>");
            string name = Console.ReadLine();

            if (name.EndsWith("a"))
            {
                Console.WriteLine("Imię jest żeńskie!");
            }
            else
            {
                Console.WriteLine("Imię nie jest żeńskie");
            }

            Console.WriteLine("\nkoniec programu!");

            Console.ReadLine();
            //----------------------------------------------------------------------------------------
            //Zadnie 2.Napisz program wstawiający do tablicy n losowych liczb i wyświetlający najmniejszą i największą z nich.

            Random rnd = new Random();

            int n = rnd.Next(1, 11);
            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                tab[i] = rnd.Next(1, 21);

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tab[i]);

            }

            int max = tab.Max();
            int min = tab.Min();
            Console.WriteLine($"\nIlosc wylosowanych liczb: {n} wartosc maxymalna to:{max} a liczba minimalna to: {min}");

            Console.ReadLine();
            //--------------------------------------------------------------------------------------------
            //Zadanie 4------------------------------------------------------
            static void Main(string[] args)
            {
                int check = 0;
                Random rand = new Random();

                int[] losowa = new int[50];



                for (int i = 0; i < losowa.Length;)
                {
                    check = rand.Next(1, 101);
                    while (!(losowa.Contains(check)))
                    {

                        losowa[i] = check;
                        i++;
                    }

                    Console.WriteLine(check);

                }
                Console.Read();
            }
            //---------------------------------------------------------------------------------------------
            //Zadanie 6. Napisz program, który dla n losowych liczb z przedziału od (0,100) umieszczonych w tablicy wyświetli osobno sumę liczb parzystych i nieparzystych.
            int parz = 0;
            int nparz = 0;

            Random rnd = new Random();
            int n = rnd.Next(0, 100);
            Console.WriteLine($"Ilosc wylosowanych liczb wynosi:{n}");
            int[] P = new int[n];

            for (int i = 0; i < n; i++)
            {
                P[i] = rnd.Next(0, 100);
                Console.Write(P[i] + " ");

                if (P[i] % 2 == 0)
                {
                    parz = parz + P[i];
                }
                else if (P[i] % 2 == 1)
                {
                    nparz = nparz + P[i];
                }

            }
            Console.WriteLine($"\nSuma liczb parzystych wynosi: {parz}\nSuma liczb nieparzystych wynosi: {nparz}\n");
            Console.ReadLine();
            //---------------------------------------------------------------------------------------------------
            //Zadanie 8. Napisz program wykonujący sumowanie cyfr w liczbie.Przykład.Wejście: 348 Wyjście: 15
            Console.Write("Podaj liczbe:\n>");
            string sum = Console.ReadLine();

            int result = sum.ToString().Sum(c => c - '0');
            Console.WriteLine($"\nSuma liczby: {sum} wynosi: {result}");

            Console.ReadLine();
            //--------------------------------------------------------------------------------
            //Zadanie 10
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.Write("Podaj liczbe w systemie szesnastkowym:\n>");
                string hex_value = Console.ReadLine();

                int int_value = Convert.ToInt32(hex_value, 16);


                Console.WriteLine("hex_value = {0}", hex_value);
                Console.WriteLine("int_value = {0}", int_value);


                Console.ReadLine();




            }
        }
    }
    //Zadanie 14. Napisz program sumujący liczby całkowite z przedziału A,B osobno parzyste i nieparzyste.
    int A;
            int B;
            int parz = 0;
            int nparz = 0;
            Console.Write("Podaj poczatek przedziału A:\n>");
            A = int.Parse(Console.ReadLine());
            Console.Write("Podaj poczatek przedziału B:\n>");
            B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                Console.Write(i + " ");
                if (i % 2 == 0)
                {
                    parz = parz + i;
                }
                else if (i % 2 == 1)
                {
                    nparz = nparz + i;
                }
            }
            Console.WriteLine($"\nSuma liczb parzystych wynosi: {parz}\nSuma liczb nieparzystych wynosi: {nparz}\n");
            Console.ReadLine();
            //------------------------------------------------------------------------------------------

        }
    }
}
