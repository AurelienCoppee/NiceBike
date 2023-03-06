using MySql.Data.MySqlClient;

namespace NiceBike.Models;

public class Database
{
    private readonly string connectionString = "server=pat.infolab.ecam.be;port=63314;database=NiceBike;user=admin;password=password;";
    public MySqlConnection connection;
    public void OpenConnection()
    {
        MySqlConnection connection = new(connectionString);
        connection.Open();
    }
    public int NumberOfRowsWithValue<T>(string tableName, string columnName, T columnValue)
    {
        MySqlConnection connection = new(connectionString);
        connection.Open();
        string valueString = columnValue.ToString();
        if (typeof(T) == typeof(string))
        {
            valueString = $"'{valueString}'";
        }
        string queryString = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = {valueString}";
        using MySqlCommand command = new(queryString, connection);
        object result = command.ExecuteScalar();
        int rowCount = Convert.ToInt32(result);
        return rowCount;
    }
    public void CloseConnection()
    {
        connection.Close();
    }
}
