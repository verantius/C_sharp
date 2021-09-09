using System;

class DIJKSTRA
{
    public static void Main()
    {
        int s = 0;

        // Console.Write("ilosc przypadkow?\n> ");
        s = int.Parse(Console.ReadLine());
        do
        {
            s--;
            int arr_max;
            Console.Write("N i M ?\n> \n");
            //string scale = "3 3"; //
            string scale = Console.ReadLine();
            string[] arSpt = scale.Split(' ');
            int N = int.Parse(arSpt[0]);
            int M = int.Parse(arSpt[1]);

            if (N >= M)
                arr_max = N;
            else
                arr_max = M;

            string[] aS = new string[3];
            int[,] ArrC = new int[M, 3];
            int[,] ArrSpin = new int[arr_max, arr_max];

            for (int i = 0; i < 3; i++) //zerowanie
            {
                for (int j = 0; j < 3; j++)
                    ArrSpin[i, j] = 0;
            }
 
            for (int i = 0; i < ArrSpin.GetLength(0); i++)
            {
                for (int j = 0; j < ArrSpin.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", ArrSpin[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
 
            for (int i = 0; i < M; i++)
            {
                //string c = "1 2 5";
                string c = Console.ReadLine();
                aS = c.Split(' ');
                      
                ArrC[i, 0] = (int.Parse(aS[0])) - 1;
                ArrC[i, 1] = (int.Parse(aS[1])) - 1;
                ArrC[i, 2] = int.Parse(aS[2]);

                ArrSpin[ArrC[i, 0], ArrC[i, 1]] = ArrC[i, 2];
                ArrSpin[ArrC[i, 1], ArrC[i, 0]] = ArrC[i, 2];
            }
            Console.WriteLine("\n");
            /*
            for (int i = 0; i < ArrSpin.GetLength(0); i++)
            {
                for (int j = 0; j < ArrSpin.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", ArrSpin[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            */
           // Console.Write("A i B ?\n \n");
           // string points = "0 3"; //
            string points = Console.ReadLine();
            string[] arrPoint = points.Split(' ');
            int A = int.Parse(arrPoint[0]);
            int B = int.Parse(arrPoint[1]);
        
            int src = 0;

            int[] min_Lhg = new int[M];
            bool[] devX = new bool[M];

            for (int i = 0; i < M; i++)
            {
                min_Lhg[i] = int.MaxValue;
                devX[i] = false;
            }

            min_Lhg[src] = A;

            for (int i = 0; i < M - 1; i++)
            {
                int u = mLength(M,min_Lhg, devX);
                devX[u] = true;

                for (int c = 0; c < M; c++)
                    if (!devX[c] && ArrSpin[u, c] != 0 &&
                         min_Lhg[u] != int.MaxValue && min_Lhg[u] + ArrSpin[u, c] < min_Lhg[c])
                        min_Lhg[c] = min_Lhg[u] + ArrSpin[u, c];
            }

            int sum = 0;
            for (int i = 0; i < M; i++)
                sum = sum + min_Lhg[i];

                Console.WriteLine(sum+ "\n");
        } while (s != 0);

        Console.ReadLine();

    }
    static int mLength(int M, int[] min_Lhg, bool[] devX)
    {
        int min = int.MaxValue, idx = -1;
        for (int c = 0; c < M; c++)
            if (devX[c] == false && min_Lhg[c] <= min)
            {
                min = min_Lhg[c];
                idx = c;
            }

        return idx;
    }
}
