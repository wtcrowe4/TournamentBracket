using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentBracket
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matchups
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Winner of matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Round of matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
