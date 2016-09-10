using System.Threading.Tasks;
using CheckAvability.Model;

namespace CheckAvability.Service
{
    public interface ICheckIphoneService
    {
        Task<object> GetIphoneTaskAsyn();
    }
}