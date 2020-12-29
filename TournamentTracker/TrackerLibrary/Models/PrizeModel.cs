
namespace TrackerLibrary.Models
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
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
