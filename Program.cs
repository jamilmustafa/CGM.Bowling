using System;

namespace CGM.Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Game allStrikesGame = new Game();
            allStrikesGame.Shot(0, 0, 10);
            allStrikesGame.Shot(0, 1, 0, true);
            allStrikesGame.Shot(1, 0, 10);
            allStrikesGame.Shot(1, 1, 0, true);
            allStrikesGame.Shot(2, 0, 10);
            allStrikesGame.Shot(2, 1, 0, true);
            allStrikesGame.Shot(3, 0, 10);
            allStrikesGame.Shot(3, 1, 0, true);
            allStrikesGame.Shot(4, 0, 10);
            allStrikesGame.Shot(4, 1, 0, true);
            allStrikesGame.Shot(5, 0, 10);
            allStrikesGame.Shot(5, 1, 0, true);
            allStrikesGame.Shot(6, 0, 10);
            allStrikesGame.Shot(6, 1, 0, true);
            allStrikesGame.Shot(7, 0, 10);
            allStrikesGame.Shot(7, 1, 0, true);
            allStrikesGame.Shot(8, 0, 10);
            allStrikesGame.Shot(8, 1, 0, true);
            //Final Shot
            allStrikesGame.Shot(9, 0, 10);
            allStrikesGame.Shot(9, 1, 10);
            allStrikesGame.Shot(9, 2, 10, true);

            Console.WriteLine("Total Score of All Strikes: {0}", allStrikesGame.GetTotalScore());




            Game gameWithSpare = new Game();
            gameWithSpare.Shot(0, 0, 4);
            gameWithSpare.Shot(0, 1, 6, true);
            gameWithSpare.Shot(1, 0, 7); //Bonus 10+7+7+3 =27
            gameWithSpare.Shot(1, 1, 3, true);
            Console.WriteLine("Total Score after given shots/rolls: {0}", gameWithSpare.GetTotalScore());


        }
    }
}
