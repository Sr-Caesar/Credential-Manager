
namespace Password_Manager.PasswordChecker
{
    public class Password
    {
        private readonly string _password;

        public string MyPassword => _password;

        public Password(string password)
        {
            _password = password;
        }

    }
}
