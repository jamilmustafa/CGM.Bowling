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
    }
}