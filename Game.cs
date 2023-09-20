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
            List<Question> questions = new List<Question>()
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

            // Replability
            questions[3].Ranks = new List<Rank>()
            {
                new Rank(10, "Phenominal", "Could play occassionally forever."),
                new Rank(9, "Exceptional", "Could play for years."),
                new Rank(8, "Great", "Could play for months."),
                new Rank(7, "Good", "Could play a lot."),
                new Rank(6, "Okay", "Could play more than most games."),
                new Rank(5, "Average", "Nothing special."),
                new Rank(4, "Flawed", "Stale after a while."),
                new Rank(3, "Boring", "Stale really quick."),
                new Rank(2, "Snoozefest", "Stale almost immediately."),
                new Rank(1, "Abysmal", "Immediately stale."),
            };

            // Impact
            questions[4].Ranks = new List<Rank>()
            {
                new Rank(10, "Life-Changing", "Indescribable effect on me."),
                new Rank(9, "Obsession", "Shaped my interests substantially."),
                new Rank(8, "Inspiring", "Inspired me."),
                new Rank(7, "Yearning", "I want to experience it again for the first time."),
                new Rank(6, "Fond Memory", "I look back to playing pleasantly."),
                new Rank(5, "Average", "Didn't really affect me."),
                new Rank(4, "Bad Memory", "I look back to playing unpleasantly."),
                new Rank(3, "Never Again", "Glad I'm not playing it anymore."),
                new Rank(2, "Hate", "Very negative affect on me."),
                new Rank(1, "Addiction", "Made my life miserable."),
            };

            // Return
            return questions;

        } // end DefaultQuestions

    } // end class Game

} // end namespace