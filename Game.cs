using System;
using System.Collections.Generic;

namespace CGM.Bowling
{
    public class Game
    {
        public List<Frame> Frames { get; private set; }
        public Game()
        {
            InitializeFrames();
        }

        public void Shot(int frameIndex, int attemptNumber, int pinsDown, bool isComplete = false)
        {
            Frames[frameIndex].Attempts[attemptNumber].TotalPinsDown+= pinsDown;
            Frames[frameIndex].IsComplete = isComplete;


        }

        
        private void InitializeFrames()
        {
            Frames = new List<Frame>();
            //1-9 frames with possible 2 rolls
            for (int i = 0; i < 9; i++)
            {
                Frames.Add(new Frame(2, false));
            }
            //final frame with possible 3 rolls
            Frames.Add(new Frame(3, true));
        }

        public void GetTotalScore()
        {
            int frameScore = 0;
            for (int i = 0; i < Frames.Count; i++)
            {
                if (i == 8)
                {
                    frameScore = 10 + Frames[9].Attempts[0].TotalPinsDown
                            + Frames[9].Attempts[1].TotalPinsDown;
                }
                else if (i == 9)
                {
                    frameScore = 0;
                    foreach (AttemptToRoll attempt in Frames[i].Attempts)
                    {
                        frameScore += attempt.TotalPinsDown;
                    }
                }
                else
                {
                    if (Frames[i].Attempts[0].TotalPinsDown == 10)
                    {
                        if (Frames[i + 1].Attempts[0].TotalPinsDown == 10)
                        {
                            frameScore = 10
                                + Frames[i + 1].Attempts[0].TotalPinsDown
                                + Frames[i + 2].Attempts[0].TotalPinsDown;
                        }
                        else
                        {
                            frameScore = 10
                                + Frames[i + 1].Attempts[0].TotalPinsDown
                                + Frames[i + 1].Attempts[1].TotalPinsDown;

                        }
                    }
                    // process spare
                    else if (Frames[i].Attempts[0].TotalPinsDown
                            + Frames[i].Attempts[1].TotalPinsDown == 10)
                    {
                        frameScore = 10 + Frames[i + 1].Attempts[0].TotalPinsDown;
                    }
                    // process regular
                    else
                    {
                        frameScore = 0;
                        foreach (AttemptToRoll attempt in Frames[i].Attempts)
                        {
                            frameScore += attempt.TotalPinsDown;
                        }
                    }
  
                }
                Frames[i].Score = frameScore;
            }
            Console.WriteLine("{0}",CalculateTotal());
        }

        private int CalculateTotal()
        {
            var totalScore = 0;
            foreach (Frame frame in Frames)
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