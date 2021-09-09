using System;
using System.Linq;
using System.Collections.Generic;
class SPIN_PL
{
    public static void Main()
    {
        int s = 0;

        // Console.Write("ilosc przypadkow?\n> ");
        s = int.Parse(Console.ReadLine());
        do
        {
            s--;

            //Console.Write("N i M ?\n> ");

            string idx = Console.ReadLine();
            int N = idx[idx.IndexOf('n') + 2] - '0';
            int M = idx[idx.IndexOf('m') + 2] - '0';

            int b = 0;
            int x, y, z;
            List<string> lines = new List<string>();

            int[,] spin = new int[N, N];
            int[,] aR = new int[M, 3];
            //Console.Write("krawędzie i wierzchołki?\n> ");

            string mway = Console.ReadLine();
            string uway = String.Join("", mway.Split(',', '}', '{', ' '));

            lines.AddRange(uway.Select(c => c.ToString()));
            string[] array = lines.ToArray();
            int[] myInts = Array.ConvertAll(array, s => int.Parse(s));


            for (int i = 0; i < N; i++) //zerowanie
            {
                for (int j = 0; j < N; j++)
                    spin[i, j] = 0;
            }

            for (int i = 0; i < aR.GetLength(0); i++) // dodawanie do 2D array
            {
                for (int j = 0; j < aR.GetLength(1); j++)
                {
                    aR[i, j] = myInts[b];
                    b++;
                }
            }

            for (int i = 0; i < M; i++)
            {
                x = aR[i, 0];
                y = aR[i, 1];
                z = aR[i, 2];

                spin[x, y] = z;
                spin[y, x] = z;
            }

            int[] dmt = new int[N];
            int[] vital = new int[N];

            bool[] tree = new bool[N];
            for (int i = 0; i < N; i++)
            {
                vital[i] = int.MaxValue;
                tree[i] = false;
            }
            vital[0] = 0;
            dmt[0] = -1;

            for (int count = 0; count < N - 1; count++)
            {
                int u = funG(N, vital, tree);
                tree[u] = true;

                for (int l = 0; l < N; l++)


                    if (spin[u, l] != 0 && tree[l] == false
                        && spin[u, l] < vital[l])
                    {
                        dmt[l] = u;
                        vital[l] = spin[u, l];
                    }
            }


            int sum = 0;
            for (int i = 1; i < N; i++)
                sum = sum + spin[i, dmt[i]];

            Console.WriteLine(sum);
        } while (s != 0);

        Console.ReadLine();

    }
    static int funG(int N, int[] vital, bool[] tree)
    {

        int m = int.MaxValue, wrt_min = -1;

        for (int l = 0; l < N; l++)
            if (tree[l] == false && vital[l] < m)
            {
                m = vital[l];
                wrt_min = l;
            }

        return wrt_min;
    }

}
