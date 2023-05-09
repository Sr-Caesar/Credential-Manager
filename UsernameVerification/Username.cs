
namespace Password_Manager.UsernameVerification
{
    public class Username
    {
        private readonly string _emailName;
        private readonly string _emailServer;
        private readonly string _emailDomain;
        private readonly string _myEmail;

        public string EmailName=> _emailName;
        public string EmailServer => _emailServer;
        public string EmailDomain => _emailDomain;
        public string MyEmail => _myEmail;

        private Username(string emailName, string emailServer, string emailDomain)
        {
            _emailName = emailName;
            _emailServer = emailServer;
            _emailDomain = emailDomain;
            _myEmail = $"{emailName}@{emailServer}{emailDomain}";
        }
        public static Username CreateThisEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                string[] strings = email.Split('@');
                string serverDomain = strings[1];
                string[] myTwoFocusParts = serverDomain.Split('.');

                if (CheckServer(myTwoFocusParts[0]) && CheckDomain(myTwoFocusParts[1]))
                {
                    return new Username(strings[0], myTwoFocusParts[0], myTwoFocusParts[1]);
                }
            }
            return null;
        }
        public static bool CheckServer(string myServer)
        {
            string[] serverList = { "gmail",
                                    "neo",
                                    "constant contact",
                                    "hubspot",
                                    "sendinblue",
                                    "aweber",
                                    "protonmail",
                                    "outlook",
                                    "yahoo",
                                    "zoho",
                                    "aol",
                                    "mail",
                                    "gmx",
                                    "icloud",
                                    "yandex" };

            myServer = myServer.ToLower();
            return serverList.Contains(myServer);
        }
        public static bool CheckDomain(string myDomain)
        {
            string[] emailDomains = {
                                "com",
                                "net",
                                "org",
                                "edu",
                                "gov",
                                "mil",
                                "biz",
                                "info",
                                "me",
                                "co",
                                "io",
                                "tv",
                                "us",
                                "ca",
                                "au",
                                "nz",
                                "uk",
                                "in",
                                "ru",
                                "fr",
                                "es",
                                "de",
                                "it",
                                "nl",
                                "ch",
                                "se",
                                "no",
                                "dk",
                                "fi",
                                "pl",
                                "gr",
                                "pt",
                                "cz",
                                "hu",
                                "ro",
                                "bg",
                                "hr",
                                "si",
                                "ee",
                                "lv",
                                "lt",
                                "ua",
                                "by",
                                "kz",
                                "tr",
                                "sa",
                                "ae",
                                "qa",
                                "om",
                                "kw",
                                "bh",
                                "il",
                                "jp",
                                "cn",
                                "hk",
                                "tw",
                                "kr",
                                "sg",
                                "my",
                                "th",
                                "vn",
                                "ph"
                            };

            myDomain = myDomain.ToLower();
            return emailDomains.Contains(myDomain);
        }
        public override string ToString()
        {
            return MyEmail;
        }
    }
}
