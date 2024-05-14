using BlazorItsBobaTime.Data;
using BlazorItsBobaTime.Models;


namespace BlazorItsBobaTime.Services
{
    public class BobaServices : IBobaServices
    {
        private IBobaData _db = new BobaData();

        public async Task<List<BobaModel>> GetAllBobas()
        {
            List<BobaModel> bobas = await _db.ReadAllBobas();
            return bobas;
        }

        public async Task<BobaModel> GetByBobaID(int id)
        {
            BobaModel boba = await _db.ReadBobaByID(id);
            return boba;
        }

        public async Task SaveBoba(BobaModel boba)
        {
            await _db.UpdateBoba(boba);
        }

        public async Task AddBoba(BobaModel boba)
        {
            await _db.CreateBoba(boba);
        }

        public async Task RemoveBoba(BobaModel boba)
        {
            await _db.DeleteBoba(boba);
        }
    }
}
