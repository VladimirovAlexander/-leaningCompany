using Сleaning.Models;

namespace Сleaning.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
