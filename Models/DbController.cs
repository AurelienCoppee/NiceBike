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

		}
		public void bikeDump()
		{

		}
		public void partLoad()
		{

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

