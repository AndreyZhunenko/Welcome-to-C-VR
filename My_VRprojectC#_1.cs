using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter_VR
{
    class Program
    {
        static void Main(string[] args)
        {
            string generalSize = Console.ReadLine();
            string[] width_height = generalSize.Split();
            int myWidth = Convert.ToInt32(width_height[0]);
            int myHeight = Convert.ToInt32(width_height[1]);
            bool[,] canvas = new bool[w, h];
            for(int i = 0; i < myWidth; i++)
            {
                for(int j = 0; j < myHeight; j++)
                {
                    canvas[i,j] = true;
                }
            }
            string nstr = Console.ReadLine();
            int number = Convert.ToInt32(nstr);
            for(int i = 0; i < number; i++)
            {
                string all_coord = Console.ReadLine();
                string[] myXY = all_coord.Split();
                int x1 = Convert.ToInt32(myXY[0]);
                int y1 = Convert.ToInt32(myXY[1]);
                int x2 = Convert.ToInt32(myXY[2]);
                int y2 = Convert.ToInt32(myXY[3]);
                for (int j = x1; j < x2; j++)
                {
                    for (int k = y1; k< y2; k++)
                    {
                        canvas[j, k] = false;
                    }
                }
            }
            int Area = 0;
            for (int i = 0; i < myWidth; i++)
            {
                for (int j = 0; j < myHeight; j++)
                {
                    if (canvas[i, j] == true)
                    {
                        Area++;
                    }
                }
            }
            Console.WriteLine(Area);
            Console.ReadKey();
        }
    }
}