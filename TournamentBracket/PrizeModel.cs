using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentBracket
{
    public class PrizeModel
    {
        /// <summary>
        /// Result number
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Result name
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize purse
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of prize purse
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
