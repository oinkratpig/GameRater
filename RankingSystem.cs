using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRater
{
    /// <summary>
    /// The ranking system used by all <see cref="Question"/>s.
    /// </summary>
    internal static class RankingSystem
    {
        /// <summary>
        /// The minimum rank on the scale.
        /// <example>
        /// <br/><br/>For example, on a 1-10 scale, the minimum would be 1.
        /// </example>
        /// </summary>
        public static int MinimumRank { get; private set; }

        /// <summary>
        /// The maximum rank on the scale.
        /// <example>
        /// <br/><br/>For example, on a 1-10 scale, the maximum would be 10.
        /// </example>
        /// </summary>
        public static int MaximumRank { get; private set; }

        /// <summary>
        /// List of default <see cref="Rank"/>s within the ranking scale.
        /// </summary>
        public static List<Rank> DefaultRanks { get; private set; }

        /* Constructor */
        static RankingSystem()
        {
            MinimumRank = 1;
            MaximumRank = 10;

            DefaultRanks = new List<Rank>
            {
                new Rank(10, "Phenominal", "Perfect or near perfect."),
                new Rank(9, "Exceptional", "Almost no negatives and a lot of positives."),
                new Rank(8, "Great", "Very well-done. Hard to think of negatives."),
                new Rank(7, "Good", "Has noticeably more positives than negatives."),
                new Rank(6, "Okay", "Pretty good but nothing crazy."),
                new Rank(5, "Average", "Inoffensive but unremarkable."),
                new Rank(4, "Issues", "Has some glaring issues but it okay."),
                new Rank(3, "Very Flawed", "Has more negatives than positives."),
                new Rank(2, "Bad", "Straight-up bad."),
                new Rank(1, "Worst Possible", "The worst it could possibly be."),
            };

        } // end constructor

        /// <summary>
        /// Returns a Color based on the given percent [0,1].
        /// </summary>
        public static Color ColorFromPercent(float percent)
        {
            // Color
            Color color = Color.White;
            if (percent < 0.5f)
                color = color.Blend(Color.IndianRed, 1 - percent * 2f);
            else
                color = color.Blend(Color.LightGreen, (percent - 0.5f) / 0.5f);
            return color;

        } // end ColorFromPercent

    } // end class RankingSystem

} // end namespace