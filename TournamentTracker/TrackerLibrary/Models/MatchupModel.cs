using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the unique identifier for this matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents a list of matchup entries for this particular matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner of this particular matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round for this particular matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
