using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckAvability.Entities;
namespace CheckAvability.DAL
{
    public class IphonePlus : IIphonePlus
    {
        public async Task Create(Entities.IphonePlus plus)
        {
            using (var db = new DataModel())
            {
                db.Plus.Add(plus);
                await db.SaveChangesAsync();
            }
        }

        public async Task Create(List<Entities.IphonePlus> plus)
        {
            using (var db = new DataModel())
            {
                foreach (var p in plus)
                {
                    db.Plus.Add(p);
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}
