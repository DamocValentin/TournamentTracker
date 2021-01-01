using System.Configuration;
using TrackerLibrary.DataPersistance;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                //TODO Set up the SQL Connector properly
                SqlConnection sql = new SqlConnection();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                //TODO Set up the text Connector properly
                TextConnection text = new TextConnection();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
