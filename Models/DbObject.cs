

namespace NiceBike.Models
{
	public class DbObject
	{
		public int id;
		public String name;
		public int stock;
		public String tableName;
		public List<Object> details;
		public void update(string key, string value)
		{
			App.db.UpdateColumnById(tableName, key, value, id);
        }
		public void yeet()
		{
			App.db.RemoveRowById(tableName, id);
        }
	}
}

