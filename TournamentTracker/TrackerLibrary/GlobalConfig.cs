using System.Collections.Generic;
using System.Configuration;
using TrackerLibrary.DataPersistance;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFile)
        {
            if(database)
            {
                //TODO Set up the SQL Connector properly
                SqlConnection sql = new SqlConnection();
                Connections.Add(sql);
            }

            if(textFile)
            {
                //TODO Set up the text Connector properly
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
