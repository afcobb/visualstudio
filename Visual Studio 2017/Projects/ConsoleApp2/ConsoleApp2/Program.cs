using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bowling {
    class ScoreFrame {
        private int score1, score2, scoreCount;
        public ScoreFrame() { score1 = score2 = scoreCount = 0; }
        public int Total { get { return score1 + score2; } }
        public bool IsStrike { get { return scoreCount == 1 && Total == 10; } }
        public bool IsSpare { get { return scoreCount == 2 && Total == 10; } }
        public bool IsDone { get { return IsStrike || scoreCount == 2; } }
        public int ScoreCount { get { return scoreCount; } }
        int GetScore(int n) { return (n == 1) ? score1 : (n == 2) ? score2 : -1; }
        public void AddScore(int score) {
            if (scoreCount != 2) {
                if (++scoreCount == 1) {
                    score1 = score;
                } else {
                    score2 = score;
                }
            }
        }
    }

    class ScoreGame {
        const int FrameCount = 12;
        private ScoreFrame[] frames;
        private int currentFrame;
        ScoreGame() {
            frames = new ScoreFrame[FrameCount];
            for (int i = 0; i < FrameCount; i++) { frames[i] = new ScoreFrame(); }
            currentFrame = 0;
        }

        public int CurrentScore {
            get {
                int total = 0;
                for (int i = 0; i < 10; i++) { total += GetFrameTotal(i); }
                return total;
            }
        }

        public bool IsDone { get { /* your code here */  } }

        public void AddScore(int score) {
            /* your code here */
        }

        public int GetFrameTotal(int index) {
            int total = frames[index].Total;
            if (frames[index].IsStrike) { // your code here
            } else if (frames[index].IsSpare) {  // your code here
            }
            return total;
        }
    }
}