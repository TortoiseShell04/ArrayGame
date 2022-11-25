using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameIsOn = true;
            char cntrl;
            int[] oldDim = new int[] {3,3};
            int[] newDim = new int[] {3,3};
            int[,] game = new int[,] {  {0,0,0,0,0,0,0,0}
                                       ,{0,0,0,0,0,0,0,0}
                                       ,{0,0,0,0,0,0,0,0}
                                       ,{0,0,0,1,0,0,0,0}
                                       ,{0,0,0,0,0,0,0,0}
                                       ,{0,0,0,0,0,0,0,0}
                                       ,{0,0,0,0,0,0,0,0}
                                       ,{0,0,0,0,0,0,0,0}   };

            while (gameIsOn){
             for (int x = 0; x < 8; x++)
              {
                    for (int y = 0; y < 8; y++)
                   {
                       if (y == 7)
                         {
                            Console.WriteLine(game[x,y]);
                         }
                        else 
                          {
                            Console.Write(game[x,y]);
                          }
                     }


             }
             Console.WriteLine("Enter yout move: (W,A,S,D)");
                cntrl = Convert.ToChar(Console.ReadLine());
                if (cntrl == 'w' || cntrl == 'W')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[0] -= 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                if (cntrl == 'a' || cntrl == 'A')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[1] -= 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                if (cntrl == 's' || cntrl == 'S')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[0] += 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                if (cntrl == 'd' || cntrl == 'D')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[1] += 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                
            }
                                
                               
        }
    }
}