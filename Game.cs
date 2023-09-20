using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRater
{
    /// <summary>
    /// As specific game holding its rankings.
    /// </summary>
    [Serializable]
    public class Game
    {
        /// <summary>
        /// The name of the game.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The questions to ask and their current rankings.
        /// </summary>
        public List<Question>? Questions { get; set; }

        /// <summary>
        /// Total rankings out of maximum possible.<br/>
        /// Ranges from [0, 1].
        /// </summary>
        public float RankScore
        {
            get
            {
                if (Questions == null)
                    return 0f;

                float total = 0f;
                float max = 0f;
                foreach (Question question in Questions)
                    if(question.Relevant)
                    {
                        total += question.Ranking * question.Weight;
                        max += RankingSystem.MaximumRank * question.Weight;
                    }
                    
                return total / max;
            }
        }

        /* Constructor */
        public Game(string name)
        {
            Name = name;

        } // end constructor

        /* Get default questions */
        public static List<Question> DefaultQuestions()
        {
            return new List<Question>()
            {
                new Question(3f,    "General opinion of the game?"),
                new Question(2f,    "Gameplay?"),
                new Question(2f,    "Average level of fun?"),
                new Question(1.25f, "Replayability?"),
                new Question(1f,    "Impact on you?"),
                new Question(1.5f,  "Story?"),
                new Question(1f,    "Music?"),
                new Question(1f,    "Art style?"),
                new Question(1f,    "Sound design?"),
                new Question(1f,    "Level design?"),
                new Question(1f,    "Atmosphere?"),
            };

        } // end DefaultQuestions

    } // end class Game

} // end namespace