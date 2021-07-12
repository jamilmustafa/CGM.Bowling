using System;

namespace CGM.Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            game.Shot(0, 0, 10);
            game.Shot(0, 1, 0,true);
            game.Shot(1, 0, 2);
            game.Shot(1, 1, 6, true);
            //game.Shot(2, 0, 10);
            //game.Shot(2, 1, 0,true);
            //game.Shot(3, 0, 10);
            //game.Shot(3, 1, 0,true);
            //game.Shot(4, 0, 10);
            //game.Shot(4, 1, 0,true);
            //game.Shot(5, 0, 10);
            //game.Shot(5, 1, 0,true);
            //game.Shot(6, 0, 10);
            //game.Shot(6, 1, 0,true);
            //game.Shot(7, 0, 10);
            //game.Shot(7, 1, 0,true);
            //game.Shot(8, 0, 10);
            //game.Shot(8, 1, 0,true);


            //game.Shot(9, 0, 10);
            //game.Shot(9, 1, 10);
            //game.Shot(9, 2, 10,true);
            game.GetTotalScore();

        }
    }
}
