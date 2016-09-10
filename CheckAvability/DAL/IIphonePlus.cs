using System.Collections.Generic;
using System.Threading.Tasks;
using CheckAvability.Entities;

namespace CheckAvability.DAL
{
    public interface IIphonePlus
    {
        Task Create(List<Entities.IphonePlus> plus);
        Task Create(Entities.IphonePlus plus);
    }
}