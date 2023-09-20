using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRater
{
    /// <summary>
    /// A rank that can be chosen for a <see cref="Question"/>.<br/>
    /// All ranks are stored in <see cref="RankingSystem"/>.
    /// </summary>
    public class Rank
    {
        /// <summary>
        /// The position in the ranking.
        /// <example>
        /// <br/><br/>For example, on a 1-10 <see cref="RankingSystem"/> scale, the <see href="Value"/> could be 3.
        /// </example>
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// The name of the ranking.
        /// <example>
        /// <br/><br/>For example, a 5 on a 1-10 scale could be "Average".
        /// </example>
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The description of the ranking.<br/>
        /// Explains anything not evident in the <see href="Name"/>.
        /// </summary>
        public string Description { get; private set; }

        /* Constructor */
        public Rank(int value, string name, string description)
        {
            Value = value;
            Name = name;
            Description = description;

        } // end constructor

    } // end class Rank

} // end namespace
