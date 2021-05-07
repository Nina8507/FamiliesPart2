using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.UserService
{
    public interface IUserService
    {
        Task<User> ValidateLoginAsync(string username, string password);
    }
}