using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // MISC DECLARATION
            int moveCount = 0;
            bool gameIsOn = true;
            char cntrl;

            // PLAYER CORDS
            Random ran = new Random();
            int xP = ran.Next((int) 10);
            if (xP == 0) {xP ++;}
            int yP = ran.Next((int) 10);
            if (yP == 0) {xP ++;}

            // GAME ZONE
            int[] oldDim = new int[] {xP,yP};
            int[,] game = new int[,] {  {8,8,8,8,8,8,8,8,8,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8}
                                       ,{8,0,0,0,0,0,0,0,0,8} 
                                       ,{8,8,8,8,8,8,8,8,8,8} };


            // GAME START
            for (game[oldDim[0],oldDim[1]] = 1; gameIsOn ; moveCount++)
            {
             for (int x = 0; x < 10; x++)
              {
                    for (int y = 0; y < 10; y++)
                   {
                       if (y == 9)
                         {
                            Console.WriteLine(game[x,y]);
                         }
                        else 
                          {
                            Console.Write(game[x,y]);
                          }
                     }


             }

             // PLAYER CONTROL
             Console.WriteLine("Enter yout move: (W,A,S,D)");
                cntrl = Convert.ToChar(Console.ReadLine());
                if (cntrl == 'w' || cntrl == 'W')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[0] -= 1;
                    if (oldDim[0] == 0) {Console.WriteLine("Invalid Move!!");}
                    oldDim[0] += 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                if (cntrl == 'a' || cntrl == 'A')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[1] -= 1;
                    if (oldDim[0] == 0) {Console.WriteLine("Invalid Move!!");}
                    oldDim[1] += 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                if (cntrl == 's' || cntrl == 'S')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[0] += 1;
                    if (oldDim[0] == 9) {Console.WriteLine("Invalid Move!!");}
                    oldDim[0] -= 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                if (cntrl == 'd' || cntrl == 'D')
                {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[1] += 1;
                    if (oldDim[0] == 9) {Console.WriteLine("Invalid Move!!");}
                    oldDim[1] -= 1;
                    game[oldDim[0],oldDim[1]] = 1;
                }
                
            }
                                
                               
        }
    }
}