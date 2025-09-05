using stock_finance_api.Models;

namespace stock_finance_api.Interfaces
{
    public interface ITokenService
    {
       string CreateToken(AppUser user);
    }
}
