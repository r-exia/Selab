using Selab.Src.Model;

namespace Selab.Src.LocalDatabase
{
    public interface ISqlService
    {
        Task<List<Video>> GetVideoListAsync();

        Task<int> AddVideoAsync(Video video);
        Task<int> UpdateVideoAsync(Video video);
        Task<int> DeleteVideoAsync(Video video);

        Task<List<User>> GetUserListAsync();
        Task<int> AddUserAsync(User user);
        Task<int> UpdateUserAsync(User user);
        Task<int> DeleteUserAsync(User user);
     
    }
}
