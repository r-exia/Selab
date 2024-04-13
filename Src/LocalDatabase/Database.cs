using Selab.Src.Model;
using SQLite;

namespace Selab.Src.LocalDatabase
{
    public class Database : ISqlService
    {
        private SQLiteAsyncConnection _connection;

        public Database()
        {
            SetUpDB();
        }
        private async void SetUpDB()
        {
            if (_connection == null)
            {
                string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), "Selab.db3");
                _connection = new SQLiteAsyncConnection(dbPath);
                //Create Table
                // Table Video
                await _connection.CreateTableAsync<Video>();
                // Table User
                await _connection.CreateTableAsync<User>();
            }
        }

        //Table Video 
        public async Task<int> AddVideoAsync(Video video)
        {
            return await _connection.InsertAsync(video);
        }

        public async Task<int> DeleteVideoAsync(Video video)
        {
            return await _connection.DeleteAsync(video);
        }

        public async Task<List<Video>> GetVideoListAsync()
        {
            return await _connection.Table<Video>().ToListAsync();
        }

        public async Task<int> UpdateVideoAsync(Video video)
        {
            return await _connection.UpdateAsync(video);
        }


        //Table User
        public async Task<List<User>> GetUserListAsync()
        {
            return await _connection.Table<User>().ToListAsync();
        }
     

        public async Task<int> AddUserAsync(User user)
        {
            return await _connection.InsertAsync(user);
        }

        public async Task<int> UpdateUserAsync(User user)
        {
            return await _connection.UpdateAsync(user);
        }

        public async Task<int> DeleteUserAsync(User user)
        {
            return await _connection.DeleteAsync(user);
        }
    }
}
