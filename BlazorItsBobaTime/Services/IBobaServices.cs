using BlazorItsBobaTime.Models;

namespace BlazorItsBobaTime.Services
    //Lincoln Bautista Period 2
{
    public interface IBobaServices
    {
        Task AddBoba(BobaModel boba);
        Task<List<BobaModel>> GetAllBobas();
        Task<BobaModel> GetByBobaID(int id);
        Task RemoveBoba(BobaModel boba);
        Task SaveBoba(BobaModel boba);
    }
}