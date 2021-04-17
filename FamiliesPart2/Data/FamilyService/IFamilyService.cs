using System.Collections.Generic;
using System.Threading.Tasks;
using FamiliesPart2.Models;

namespace FamiliesPart2.Data.FamilyService
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetFamiliesAsync();
    }
}