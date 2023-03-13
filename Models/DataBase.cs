using MySql.Data.MySqlClient;

namespace NiceBike.Models;

public class Database
{
    public readonly string connectionString = "server=pat.infolab.ecam.be;port=63314;database=NiceBike;user=admin;password=password;";

    public int NumberOfRowsWithValue<T>(string tableName, string columnName, T columnValue)
    {
        using MySqlConnection connection = new(connectionString);
        connection.Open();
        string valueString = columnValue is string ? $"'{columnValue}'" : columnValue.ToString();
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
        string valueString = value is string ? $"'{value}'" : value.ToString();
        using MySqlCommand command = new($"UPDATE {tableName} SET {columnName}={valueString} WHERE id={id}", connection);
        command.ExecuteNonQuery();
    }
    public void RemoveRowById(string tableName, int id)
    {
        using MySqlConnection connection = new(connectionString);
        connection.Open();
        using MySqlCommand command = new($"DELETE FROM {tableName} WHERE id = {id}", connection);
        command.ExecuteNonQuery();
    }
    public void AddRow<T>(string tableName, T value)
    {
        using MySqlConnection connection = new(connectionString);
        connection.Open();
        string valueString = value is string ? $"'{value}'" : value.ToString();
        using MySqlCommand command = new($"INSERT INTO {tableName} VALUES ({valueString})", connection);
        command.ExecuteNonQuery();
    }
    public string GetColumnValueByPrimaryKey<T>(string tableName, string primaryKeyColumnName, T primaryKeyValue, string columnName) {
        using MySqlConnection connection = new(connectionString);
        connection.Open();
        string primaryKeyValueString = primaryKeyValue is string ? $"'{primaryKeyValue}'" : primaryKeyValue.ToString();
        using MySqlCommand command = new($"SELECT {columnName} FROM {tableName} WHERE {primaryKeyColumnName} = {primaryKeyValueString}", connection);
        object result = command.ExecuteScalar();
        return result?.ToString();
    }
}
