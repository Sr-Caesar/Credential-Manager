
namespace Password_Manager.PasswordChecker.PasswordRequirements
{
    public abstract class Filter
    {
        protected Filter? _nextFilter;
        protected static int _deepness = 0;

        public void SetNextFilter(Filter filter) 
        {
            _nextFilter = filter;
        }

        public abstract bool IsValid(Password password);
        public abstract bool UnlockNextFilter(Password password);

    }
}
