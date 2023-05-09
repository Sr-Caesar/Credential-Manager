

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

        public Account? GetByMatricola(int myID)
        {
            string command = @"SELECT * 
                             FROM Account
                             WHERE Matricola = @Matricola";
            return GetAccount(command, "@Matricola", myID);
        }
        public Account? Insert(Username username, Password password)
        {
            var command = @"
            INSERT INTO [Account] ([Username],[Password])
            VALUES ( @Username, @Password)";
            return InsertAccount(command, "@Username", "@Password", username, password);
        }
        private Account? InsertAccount(string command, string parameterUsername, string parameterPassword, Username username, Password password)
        {
            try 
            {
                using var cn = new SqlConnection(ConnectionString);
                cn.Open();
                using var cmd = new SqlCommand(command, cn);
                cmd.Parameters.AddWithValue(parameterUsername, username.MyEmail);
                cmd.Parameters.AddWithValue(parameterPassword, password.MyPassword);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Account account = new Account(username, password);
                    return account;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine(ex);
            }
            return null;
        }
        private Account? GetAccount(string command, string parameterName, int myID)
        {
            try 
            {
                using var cn = new SqlConnection(ConnectionString);
                cn.Open();
                using var cmd = new SqlCommand(command, cn);
                cmd.Parameters.AddWithValue(parameterName, myID);
                using var reader = cmd.ExecuteReader();
                if (reader?.Read() == true)
                {
                    return new Account
                    (
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3)
                    );
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
