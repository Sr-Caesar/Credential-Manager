
namespace Password_Manager.PasswordChecker.PasswordRequirements
{
    public class SetUpChain
    {
        private readonly Filter _chain;

        public SetUpChain() 
        {
            FilterNull filterNull = new();
            FilterCapitalLetter filterCapital = new();
            FilterLength filterLength = new();
            FilterNumber filterNumber = new();
            FilterSpecialChar filterSpecialChar = new();

            filterNull.SetNextFilter(filterCapital);
            filterCapital.SetNextFilter(filterLength);
            filterLength.SetNextFilter(filterNumber);
            filterNumber.SetNextFilter(filterSpecialChar);
            _chain = filterNull;
        }
        public Filter GetChain() => _chain;
    }
}
