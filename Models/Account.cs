
using Password_Manager.PasswordChecker;
using Password_Manager.UsernameVerification;
using System.Diagnostics.Metrics;

namespace Password_Manager.Models
{
    public class Account
    {
        private static int LastMatricola = 0;
        public int Matricola { get; set; }
        public Username? Username { get; set; }
        public Password? Password { get; set; }
        public DateTime SubscriptionDate { get; set; }

        public Account(Username? username, Password? password)
        {
            LastMatricola++;
            Matricola = LastMatricola;
            Username = username;
            Password = password;
            SubscriptionDate = DateTime.Now;
        }
        public Account(int matricola, string email, string password, DateTime myTime)
        {
            Matricola = matricola;
            Username = Username.CreateThisEmail(email);
            Password = new Password(password);
            SubscriptionDate = myTime;
        }
        public override string ToString()
                => $"Matricola: {Matricola}; Email:{Username.MyEmail}; Password:{Password.MyPassword}; Data Creazione:{SubscriptionDate}";
    }
}
