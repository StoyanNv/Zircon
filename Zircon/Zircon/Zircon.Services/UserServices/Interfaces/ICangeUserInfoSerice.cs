using System.Threading.Tasks;

namespace Zircon.Services.UserServices.Interfaces
{
    public interface ICangeUserInfoSerice
    {
        Task ChangeNameAsync(string name, string email);

        Task ChangeSurnameAsync(string name, string email);

    }
}