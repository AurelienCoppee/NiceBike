using MySql.Data.MySqlClient;

namespace NiceBike.Models;

public class Database
{
    public readonly string connectionString = "server=pat.infolab.ecam.be;port=63314;database=NiceBike;user=admin;password=password;";
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
    public void UpdateColumnById<T>(string tableName, string columnName, T value, int id)
    {
        using MySqlConnection connection = new(connectionString);
        connection.Open();
        if (typeof(T) == typeof(string))
        {
            value = (T)(object)($"'{value}'");
        }
        using MySqlCommand command = new($"UPDATE {tableName} SET {columnName}={value} WHERE id={id}", connection);
        command.ExecuteNonQuery();
    }
    public void RemoveRowById(string tableName, int id)
    {
        using MySqlConnection connection = new(connectionString);
        connection.Open();
        using MySqlCommand command = new($"DELETE FROM {tableName} WHERE id = {id}", connection);
        command.ExecuteNonQuery();
    }
    public void CloseConnection()
    {
        connection.Close();
    }
}
