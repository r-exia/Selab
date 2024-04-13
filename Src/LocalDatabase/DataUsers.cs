using Selab.Src.Model;
namespace Selab.Src.LocalDatabase
{
    public class DataUsers
    {
        public static List<User> GetUsers()
        {
            return new List<User>
            {
                new User
                {
                    id = 1,
                    avatar = "https://yt3.googleusercontent.com/CgJdimI7UFMROkmSQmyoQXa9CXP7FTyU2wLaKdPVfi20u-tjTmOsFuHom4iCb0UYOwRwcasj=s176-c-k-c0x00ffffff-no-rj",
                    actor = "Eve"
                },
                new User
                {
                    id = 2,
                    avatar = "https://yt3.googleusercontent.com/I7uuzRGguJznsyPGG1tAhnsr0QB-XReVy88oNhC0sK-MKDokMCa-TFz4NaXlI3jtYZibYjKQz90=s176-c-k-c0x00ffffff-no-rj",
                    actor = "TBSアニメ"
                },

            };
        }
    }
}
