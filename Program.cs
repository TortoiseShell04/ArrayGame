using System;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        { 
            // MISC DECLARATION
            bool gameIsOn = true;
            bool gameHasStarted = false;
            bool gameLevel = true;
            char cntrl = 'i';
            int[] boxDim = new int[] {0,0};
            int[] oldDim = new int[] {0,0};

            // GAME ZONE
            
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

                
            while (gameLevel)
            {
                gameIsOn = true;
                if (gameHasStarted == true)
                {
                   game[oldDim[0],oldDim[1]] = 0;
                   gameHasStarted = false;
                }

                // GAME START
                for (int moveCount = 0; gameIsOn ; moveCount++)
                {
                 if (gameHasStarted == false)
                 {
                    // PLAYER CORDS
                    Random ran = new Random();
                    int xP = ran.Next((int) 9);
                    if (xP == 0) {xP++;}
                    int yP = ran.Next((int) 9);
                    if (yP == 0) {yP++;}
                    oldDim[0] = xP; oldDim[1] = yP;

                    // BOX CORDS
                    Random box = new Random();
                    int xB = box.Next((int) 9);
                    if (xB == 0) {xB++;}
                    int yB = box.Next((int) 9);
                    if (yB == 0) {yB++;}
                    

                    boxDim[0] = xB; boxDim[1] = yB;
                    game[boxDim[0],boxDim[1]] = 3;

                    game[oldDim[0],oldDim[1]] = 1;
                    gameHasStarted = true;

                    }


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

                    if (oldDim[0] == boxDim[0] && oldDim[1] == boxDim[1])
                        {
                           Console.WriteLine("You WON the game!!");
                           gameIsOn = false;
                           break;
                    
                        }


                  // PLAYER CONTROL
                  Console.WriteLine("Enter yout move: (W,A,S,D)");
                   cntrl = Convert.ToChar(Console.ReadLine());

                  if (cntrl == 'w' || cntrl == 'W')
                  {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[0] -= 1;
                    if (oldDim[0] == 0) {Console.WriteLine("Invalid Move!!"); oldDim[0] += 1;}
                    game[oldDim[0],oldDim[1]] = 1;
                  }
                  if (cntrl == 'a' || cntrl == 'A')
                  {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[1] -= 1;
                    if (oldDim[1] == 0) {Console.WriteLine("Invalid Move!!"); oldDim[1] += 1;}
                    game[oldDim[0],oldDim[1]] = 1;
                  }
                  if (cntrl == 's' || cntrl == 'S')
                  {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[0] += 1;
                    if (oldDim[0] == 9) {Console.WriteLine("Invalid Move!!"); oldDim[0] -= 1;}
                    game[oldDim[0],oldDim[1]] = 1;
                   }
                   if (cntrl == 'd' || cntrl == 'D')
                  {
                    game[oldDim[0],oldDim[1]] = 0;
                    oldDim[1] += 1;
                    if (oldDim[1] == 9) {Console.WriteLine("Invalid Move!!"); oldDim[1] -= 1;}
                    game[oldDim[0],oldDim[1]] = 1;
                  }
                
             }
                                
                               
            }
        }
    }
}