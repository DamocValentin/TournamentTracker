using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents the list of members for this particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of this particular team
        /// </summary>
        public string TeamName { get; set; }
    }
}
