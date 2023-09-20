using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRater
{
    /// <summary>
    /// Holds a question used for ranking.<br/>
    /// Uses a shared ranking system with all other questions.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// The question being asked.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// List of ranks the user can choose to rank the game.
        /// </summary>
        public List<Rank> Ranks { get; set; }

        /// <summary>
        /// The <see cref="GameRater.Rank"/> based on the numerical <see href="Ranking"/> property.
        /// </summary>
        public Rank? Rank { get; private set; }

        /// <summary>
        /// The numerical ranking given to the <see cref="Question"/>.
        /// </summary>
        public int Ranking
        {
            get { return _rank; }
            set
            {
                foreach (Rank rank in Ranks)
                    if (rank.Value == value)
                    {
                        Rank = rank;
                        _rank = value;
                    }
            }
        }

        /// <summary>
        /// How important this question is.<br/>
        /// ex. 1 is normal, 2 is twice as important, 0.5 is half as important.
        /// </summary>
        public float Weight { get; private set; }

        /// <summary>
        /// Whether or not the question is relevant to the game.
        /// </summary>
        public bool Relevant { get; set; }

        // Fields
        private int _rank;

        /* Constructor */
        public Question(float weight, string description)
        {
            Weight = weight;
            Description = description;
            Relevant = true;

            // Defaults Ranks
            Ranks = RankingSystem.DefaultRanks;

            // Default ranking (average)
            Ranking = (int)(RankingSystem.MinimumRank + (RankingSystem.MaximumRank - RankingSystem.MinimumRank) / 2f);

        } // end constructor

    } // end class Question

} // end namespace