using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.PasswordChecker.PasswordRequirements
{
    public class FilterNull : Filter
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
                => !string.IsNullOrEmpty(password.MyPassword);
    }
}
