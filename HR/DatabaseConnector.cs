using MySql.Data.MySqlClient;

public class DatabaseConnector
{
    private MySqlConnection connection;
    private string connectionString = "Server=localhost;Database=hr;User Id=root;Password=;";

    public DatabaseConnector()
    {
        connection = new MySqlConnection(connectionString);
    }

    public MySqlConnection Connection  // Corrected property name
    {
        get { return connection; }
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // Add more methods for executing queries, etc.
}
