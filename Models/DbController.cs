using MySql.Data.MySqlClient;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using TestNiceBike.Models;

namespace NiceBike.Models
{
	public class DbController
	{
		private List<DbObject> _bikes;
        private List<DbObject> _bikeParts;
		public ObservableCollection<DbObject> bikes;
		public ObservableCollection<DbObject> bikeParts;
        public DbController()
		{
			_bikes = new List<DbObject>();
			_bikeParts = new List<DbObject>();
			bikes = new ObservableCollection<DbObject>();
			bikeParts = new ObservableCollection<DbObject>();
		}
		public void bikeLoad()
		{
                using MySqlConnection connection = new(App.db.connectionString);
                connection.Open();
                string queryString = "SELECT * FROM bike_list";
                using MySqlCommand command = new(queryString, connection);
                using MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                DbObject bike = new()
                {
                    id = reader.GetInt32("idbike_list"),
                    //order = reader.GetInt32("order"),
                    name = reader.GetString("model"),
                    //Config = reader.GetString("config"),
                    //status = reader.GetString("status"),
                    stock = 1,
                    };
                    _bikes.Add(bike);
                }
		}
		public void bikeDump()
		{

		}
		public void partLoad()
		{

            using MySqlConnection connection = new(App.db.connectionString);
            connection.Open();
            string queryString = "SELECT * FROM parts_stock";
            using MySqlCommand command = new(queryString, connection);
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DbObject bike = new()
                {
                    id = reader.GetInt32("idparts"),
                    name = reader.GetString("part"),
                    //supplier = reader.GetInt32("supplier"),
                    //supplier_ref = reader.GetInt32("supplier_ref"),
                    stock = reader.GetInt32("quantity"),
                    //min_quantity = reader.GetInt32("min_quantity"),
                    //unit_price = reader.GetDecimal("unit_price"),
                };
                _bikeParts.Add(bike);
            }
        }
		public void partDump()
		{

		}
		public void load()
		{
			bikeLoad();
			partLoad();
		}
		public void list()
		{
            bikes = new ObservableCollection<DbObject>(_bikes);
            bikeParts = new ObservableCollection<DbObject>(_bikeParts);
			
        }
    }
}

