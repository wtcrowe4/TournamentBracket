using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentBracket
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// One team in a matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Score for this team in matchup
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Matchup from where this team came from as winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
