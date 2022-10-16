using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentBracket
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entry fee for tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of teams in tournament
        /// </summary>
        public List<TeamModel> Team { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Lists of matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
