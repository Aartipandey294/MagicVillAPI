using MagicVillAPI.Models;
using System.Linq.Expressions;

namespace MagicVillAPI.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<Villa>
    {
      
        Task<Villa> UpdateAsync(Villa entity);
  
    }
}
