using TrackerLibrary.Models;

namespace TrackerLibrary.DataPersistance
{
    public class TextConnection : IDataConnection
    {
        // TODO - Make the Create Prize function work accordingly
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
