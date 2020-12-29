using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of this particular tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee for a team to this particular tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        ///  Represents a list of teams that entered this particular tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents a list of prizes for this particular tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents a list of rounds of this particular tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
