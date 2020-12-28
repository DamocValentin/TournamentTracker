using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFile)
        {
            if(database)
            {
                // Set up the SQL Connector properly
                SqlConnection sql = new SqlConnection();
                Connections.Add(sql);
            }

            if(textFile)
            {
                // Set up the text Connector properly
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
