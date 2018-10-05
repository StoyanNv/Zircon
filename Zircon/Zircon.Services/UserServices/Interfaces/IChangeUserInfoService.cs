namespace Zircon.Services.UserServices.Interfaces
{
    using System.Threading.Tasks;

    public interface IChangeUserInfoService
    {
        Task ChangeNameAsync(string name, string email);

        Task ChangeSurnameAsync(string surname, string email);

    }
}