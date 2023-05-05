
using System.Runtime.CompilerServices;

namespace Password_Manager.UsernameVerification
{
    public class Username
    {
        private readonly string _emailName;
        private readonly string _emailDomain;
        private readonly string _emailDotContext;

        public string EmailName=> _emailName;
        string EmailDomain => _emailDomain;
        string EmailDotContext => _emailDotContext;

        Username(string emailName, string emailDomain, string emailDotContext)
        {
            _emailName = emailName;
            _emailDomain = emailDomain;
            _emailDotContext = emailDotContext;
        }
        public Username(string myEmail)
        {
            CheckCorrectness(myEmail);
        }
        private bool CheckCorrectness(string email)
        {
            throw new NotImplementedException();
        }
    }
}
