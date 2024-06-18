using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepositoryWrapper<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
