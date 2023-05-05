

namespace Password_Manager.PasswordChecker.PasswordRequirements
{
    public class FilterSpecialChar : Filter
    {
        public override bool UnlockNextFilter(Password password)
                    => IsValid(password);

        public override bool IsValid(Password password)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (password.MyPassword.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
