using SQLite;

namespace Selab.Src.Model
{
    public class Video
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string imageUrl { get; set; }
        public string videoUrl { get; set; }
        public string title { get; set; }
        public int usersId { get; set; }
        public string time { get; set; }
        public int like { get; set; }
        public string detail { get; set; }
        public int view { get; set; }
        public int commentVideo { get; set; }
    }
}
