using System;
using System.Collections.Generic;
using System.Text;

namespace CGM.Bowling
{
    public static class GameScoreCalculatorExtension
    {
        public static int GetTotalScore(this Game game)
        {
            for (int i = 0; i < game.Frames.Count; i++)
            {
                int frameScore;
                //process second last roll
                if (i == 8)
                {
                    frameScore = 10 + game.Frames[9].Attempts[0].TotalPinsDown
                            + game.Frames[9].Attempts[1].TotalPinsDown;
                }
                //process last (special) roll
                else if (i == 9)
                {
                    frameScore = 0;
                    foreach (AttemptToRoll attempt in game.Frames[i].Attempts)
                    {
                        frameScore += attempt.TotalPinsDown;
                    }
                }
                else
                {
                    // process strike
                    if (game.Frames[i].Attempts[0].TotalPinsDown == 10)
                    {
                        if (game.Frames[i + 1].Attempts[0].TotalPinsDown == 10)
                        {
                            frameScore = 10
                                + game.Frames[i + 1].Attempts[0].TotalPinsDown
                                + game.Frames[i + 2].Attempts[0].TotalPinsDown;
                        }
                        else
                        {
                            frameScore = 10
                                + game.Frames[i + 1].Attempts[0].TotalPinsDown
                                + game.Frames[i + 1].Attempts[1].TotalPinsDown;

                        }
                    }
                    // process spare
                    else if (game.Frames[i].Attempts[0].TotalPinsDown
                            + game.Frames[i].Attempts[1].TotalPinsDown == 10)
                    {
                        frameScore = 10 + game.Frames[i + 1].Attempts[0].TotalPinsDown;
                    }
                    // process regular
                    else
                    {
                        frameScore = 0;
                        foreach (AttemptToRoll attempt in game.Frames[i].Attempts)
                        {
                            frameScore += attempt.TotalPinsDown;
                        }
                    }

                }
                game.Frames[i].Score = frameScore;
            }
            return CalculateTotal(game);
        }

        private static int CalculateTotal(Game game)
        {
            var totalScore = 0;
            foreach (Frame frame in game.Frames)
            {
                if (frame.IsComplete)
                {
                    totalScore += frame.Score;
                }
            }
            return totalScore;
        }

    }
}
