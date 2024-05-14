using BlazorItsBobaTime.Models;

namespace BlazorItsBobaTime.Data
{
    public interface IBobaData
    {
        Task CreateBoba(BobaModel boba);
        Task DeleteBoba(BobaModel boba);
        Task<List<BobaModel>> ReadAllBobas();
        Task<BobaModel> ReadBobaByID(int id);
        Task UpdateBoba(BobaModel boba);
    }
}