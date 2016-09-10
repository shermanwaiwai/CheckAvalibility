using System.Threading.Tasks;

namespace CheckAvability.Service
{
    public interface IAuthService
    {
        Task GetLoginUrlTask();
    }
}