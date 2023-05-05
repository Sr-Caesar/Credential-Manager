

namespace Password_Manager.PasswordChecker.PasswordRequirements
{
    public class FilterLength : Filter
    {
        public override bool UnlockNextFilter(Password password)
        {
            if (IsValid(password) && _nextFilter != null)
            {
                return _nextFilter.UnlockNextFilter(password);
            }
            return false;
        }
        public override bool IsValid(Password password)
                => password.MyPassword.Length >= 7;
    }
}
