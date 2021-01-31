
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

        }

        private static List<MatchupModel> CreateFirstRound(int byes, LinkedList<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int totalTeams = 0;

            for(int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            return totalTeams - numberOfTeams;
        }

        private static int FindNumberOfRounds(int teamsCount)
        {
            int output = 1;
            int val = 2;
            
            while(val < teamsCount)
            {
                output += 1;
                val *= 2;
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
