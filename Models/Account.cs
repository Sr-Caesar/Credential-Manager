
using Password_Manager.PasswordChecker;
using Password_Manager.UsernameVerification;
using System.Diagnostics.Metrics;

namespace Password_Manager.Models
{
    public class Account
    {
        public int Matricola { get; set; }
        public Username? Username { get; set; }
        public Password? Password { get; set; }
        public DateTime SubscriptionDate { get; set; }

        public override string ToString()
                => $"Matricola:{Matricola}, Email:{Username?.MyEmail}, Data Creazione:{SubscriptionDate}";
    }
}
