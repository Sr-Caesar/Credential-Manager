

using Password_Manager.UsernameVerification;
using Password_Manager.Models;
using Password_Manager.PasswordChecker;
using static Password_Manager.Repository.Constant;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Password_Manager.Repository
{
    public class AccountRepository : IAccountRepository
    {

        public Account? GetByEmail(Username mail)
        {
            string command = @"SELECT * 
                             FROM Account
                             WHERE Email = @Email";
            return GetAccount(command, "@Email", mail.MyEmail);
        }
        public Account? Insert(Username username, Password password)
        {
            var command = @"
            INSERT INTO [Account] ([Username],[Password],[SubscriptionDate])
            VALUES ( @Username, @Password, @SubscriptionDate)";
            return InsertAccount(command, "@Username", "@Password", username.MyEmail, password.MyPassword);
        }
        private Account? InsertAccount(string command, string parameterUsername, string parameterPassword, string username, string password)
        {
            throw new NotImplementedException();
        }
        private Account? GetAccount(string command, string parameterName, string email)
        {
            try 
            {
                using var cn = new SqlConnection(ConnectionString);
                using var cmd = new SqlCommand(command, cn);
                cn.Open();
                cmd.Parameters.AddWithValue(parameterName, email);
                using var reader = cmd.ExecuteReader();
                if (reader?.Read() == true)
                {
                    return new Account
                    {
                        Matricola = reader.GetInt32(0),
                        Username = Username.CreateThisEmail(reader.GetString(1)),
                        Password = new Password(reader.GetString(2)),
                        SubscriptionDate = reader.GetDateTime(3)
                    };
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }
    }
}
