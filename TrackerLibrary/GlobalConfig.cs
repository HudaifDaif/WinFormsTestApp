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

        public static void InitializeConnections(bool useTextFile)
        {
            if (useTextFile) {
                TextFileConnection textConn = new TextFileConnection();
                Connections.Add(textConn);
            }
        }
    }
}
