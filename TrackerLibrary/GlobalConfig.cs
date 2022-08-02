using TrackerLibrary.DataAccess;

namespace TrackerLibrary;
public static class GlobalConfig
{
    public static List<IDataConnector> Connections { get; private set; } = new List<IDataConnector>();
    public static void InitializeConnections(bool database, bool textFiles)
    {
        if (database)
        {
            // TODO - Create the SQL Connection
            var sql = new SqlConnector();
            Connections.Add(sql);
        }

        if (textFiles)
        {
            // TODO - Create the text Connection
            var text = new TextConnector();
            Connections.Add(text);
        }
    }
}
