using System.Collections.Generic;

namespace CGM.Bowling
{
    public class Frame
    {
        public List<AttemptToRoll> Attempts { get; private set; }
        public bool IsComplete { get; set; }
        public int Score { get; set; }

        public Frame(int maxAttempts, bool isFinalFrame)
        {
            //attempts for this Frame
            Attempts = InitializeAttempts(maxAttempts, isFinalFrame);
        }
        private List<AttemptToRoll> InitializeAttempts(int maxAttempts, bool isFinalFrame)
        {
            //Frame's max number of attempts
            List<AttemptToRoll> attempts = new List<AttemptToRoll>();
            for (int i = 0; i < maxAttempts; i++)
            {
                attempts.Add(new AttemptToRoll());
            }

            return attempts;
        }
    }
}