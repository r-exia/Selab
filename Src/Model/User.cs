using SQLite;

namespace Selab.Src.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string avatar { get; set; }
        public string actor { get; set; }

    }
}
