using System.Collections.Generic;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAllAdultsAsync();
        Task<Adult> GetAdultAsync(int id);
        Task AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task UpdateAdultAsync(Adult adult);
    }
}