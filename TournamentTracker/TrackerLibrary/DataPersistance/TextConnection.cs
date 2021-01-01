﻿using TrackerLibrary.Models;
using TrackerLibrary.DataPersistance.TextHelper;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataPersistance
{
    public class TextConnection : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
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
    }
}
