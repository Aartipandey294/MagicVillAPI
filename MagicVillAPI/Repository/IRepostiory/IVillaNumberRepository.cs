using MagicVillAPI.Models;
using System.Linq.Expressions;

namespace MagicVillAPI.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
      
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
  
    }
}
