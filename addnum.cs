using System;

namespace addnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Random losowa = new Random();
            int z=0, p=0, rand1, rand2, rand3, rand4, rand5;
            int rd_sum=0, wynik,N; 
            
            do
            {
            rand1 = losowa.Next(10,100);
            rand2 = losowa.Next(2,8);
            rand3 = losowa.Next(2,8);
            rand4 = losowa.Next(2,8);
            rand5 = losowa.Next(2,8);

            
            if (rand1 >= 60)
            {
                Console.Write($"Oblicz: {rand2} * {rand3} + {rand4} + {rand5} = ");
                rd_sum = rand2 * rand3 + rand4 + rand5;
            }
            else if (rand2 < 60)
            {
                Console.Write($"Oblicz: {rand2} * {rand3} - {rand4} + {rand5} = ");
                rd_sum = rand2 * rand3 - rand4 + rand5;
            }


            N = Convert.ToInt32(Console.ReadLine());

            if (rd_sum == N)
            {
                Console.WriteLine("wynik poprawny!\n");
                    p++;
            }
            else if (rd_sum != N)
            {
                
                Console.WriteLine("wynik nie poprawny!\n");
            }
            else 
            {
                Console.WriteLine("brak rozwiazan");
            }
                z++;
            } while (z != 3);
            Console.WriteLine($"\nkoniec programu\n\nzgadłeś {p} razy");
            if (p == 3) Console.WriteLine("jestem z Ciebie taki dumny!");
            Console.ReadKey();
            
        }
    }
}
