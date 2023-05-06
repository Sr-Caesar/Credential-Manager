using Password_Manager.PasswordChecker;
using Password_Manager.UsernameVerification;
using Password_Manager.Models;

namespace Password_Manager.Repository
{
    public interface IAccountRepository
    {
        Account? GetByEmail(Username username);
        Account? Insert(Username username, Password password);
    }
}
