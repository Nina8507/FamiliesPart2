using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data
{
    public interface IUserService
    {
        Task<User> ValidateLoginAsync(string username, string password);
    }
}