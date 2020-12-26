using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_VR
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = 1;
            int n = Convert.ToInt32(input);
            int nn = n * n;
            bool[] b = new bool[nn];
            for(int i = 0; i < nn; i++)
            {
                b[i] = true;
            }
            int[,] sud = new int[nn, nn];
            for (int i = 0; i < nn; i++)
            {
                input = System.Console.ReadLine();
                string[] rarr = input.Split();
                for (int j = 0; j < nn; j++)
                {
                    int k = Int32.Parse(rarr[j]);
                    if (k > nn)
                    {
                        result = 0;
                        break;
                    }
                    sud[i, j] = k;
                }
                if (result == 0)
                {
                    break;
                }
            }
            if (result != 0)
            {
                for (int i = 0; i < nn; i++)
                {
                    for (int j = 0; j < nn; j++)
                    {
                        if (b[sud[i, j] - 1] == false)
                        {
                            result = 0;
                            break;
                        }
                        else
                        {
                            b[sud[i, j] - 1] = false;
                        }
                    }
                    for (int l = 0; l < nn; l++)
                    {
                        b[l] = true;
                    }
                }
                for (int i = 0; i < nn; i++)
                {
                    for (int j = 0; j < nn; j++)
                    {
                        if (b[sud[j, i] - 1] == false)
                        {
                            result = 0;
                            break;
                        }
                        else
                        {
                            b[sud[j, i] - 1] = false;
                        }
                    }
                    for (int l = 0; l < nn; l++)
                    {
                        b[l] = true;
                    }
                }
                int col = 0;
                int row = 0;
                for (int o = 0; o < n; o++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        for (int i = col; i < col + 3; i++)
                        {
                            for (int j = row; j < row + 3; j++)
                            {
                                if (b[sud[i, j] - 1] == false)
                                {
                                    result = 0;
                                    break;
                                }
                                else
                                {
                                    b[sud[i, j] - 1] = false;
                                }
                            }
                        }
                        for (int l = 0; l < nn; l++)
                        {
                            b[l] = true;
                        }
                        col = col + 3;
                    }
                    row = row + 3;
                    col = 0;
                }
            }
            if (result == 0)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                Console.WriteLine("Correct");
            }

            Console.ReadKey();
        }
    }
}