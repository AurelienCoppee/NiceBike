using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
		}
		public void bikeLoad()
		{
			DbObject bike = new DbObject();
			bike.id = 1;
			bike.name = "bob";
			bike.stock = 0;

			_bikes.Add(bike);
		}
		public void bikeDump()
		{

		}
		public void partLoad()
		{
            DbObject bike = new DbObject();
            bike.id = 1;
            bike.name = "bob";
            bike.stock = 0;

            _bikeParts.Add(bike);

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

