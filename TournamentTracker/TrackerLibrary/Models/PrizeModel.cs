using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the unique identifier of this particular prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the number of the place of this particular prize
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place for this particular prize
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of money for this particular prize
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage for this particular prize
        /// </summary>
        public double PricePercentage { get; set; }
    }
}
