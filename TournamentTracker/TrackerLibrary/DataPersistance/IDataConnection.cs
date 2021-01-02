using TrackerLibrary.Models;

namespace TrackerLibrary.DataPersistance
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
    }
}
