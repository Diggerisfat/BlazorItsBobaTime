
using BlazorItsBobaTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lincoln Bautista Period 2

namespace BlazorItsBobaTime.Data
{
    public class BobaData : IBobaData
    {
        private readonly ISqlDataAccess _db = new SqlDataAccess();

        public async Task CreateBoba(BobaModel boba)
        {
            string sql = "INSERT INTO boba (Size, Type, Boba, Ice, Sugar, Temperature, Toppings) VALUES (@Size, @Type, @Boba, @Ice, @Sugar, @Temperature, @Toppings);";
            await _db.SaveData(sql, boba);
        }

        public async Task UpdateBoba(BobaModel boba)
        {
            string sql = "UPDATE `boba` SET `Size` = @Size, `Type` = @Type, `Boba` = @Boba, `Ice` = @Ice, `Sugar` = @Sugar, `Temperature` = @Temperature, `Toppings` = @Toppings WHERE `boba`.`ID` = @ID";
            await _db.SaveData(sql, boba);
        }

        public async Task DeleteBoba(BobaModel boba)
        {
            string sql = "DELETE FROM boba WHERE id = @id;";
            await _db.SaveData(sql, boba).ConfigureAwait(true);
        }

        public async Task<List<BobaModel>> ReadAllBobas()
        {
            string sql = "SELECT * FROM `boba`";
            IEnumerable<BobaModel> bobas = await _db.LoadData<BobaModel, dynamic>(sql, new { });
            return bobas.ToList();
        }

        public async Task<BobaModel> ReadBobaByID(int id)
        {
            string sql = "SELECT * FROM boba WHERE boba.id = @id";
            IEnumerable<BobaModel> results = await _db.LoadData<BobaModel, dynamic>(sql, new { id });
            List<BobaModel> boba = results.ToList();
            if (boba.Count > 0)
            {
                return boba[0];
            }
            return null;
        }


    }
}
