using Password_Manager.PasswordChecker;
using Password_Manager.UsernameVerification;
using Password_Manager.Models;

namespace Password_Manager.Repository
{
    public interface IAccountRepository
    {
        Account? GetByMatricola(int myID);
        Account? Insert(Username username, Password password);
    }
}
