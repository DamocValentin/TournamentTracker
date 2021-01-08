using TrackerLibrary.Models;
using TrackerLibrary.DataPersistance.TextHelper;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataPersistance
{
    public class TextConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            model.Id = 1;

            if(people.Count > 0)
            {
                model.Id = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            model.Id = 1;

            if(prizes.Count > 0)
            {
                model.Id = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            model.Id = 1;

            if (teams.Count > 0)
            {
                model.Id = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new System.NotImplementedException();
        }
    }
}
