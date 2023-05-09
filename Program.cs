using Password_Manager.PasswordChecker;
using Password_Manager.PasswordChecker.PasswordRequirements;
using Password_Manager.UsernameVerification;
using Password_Manager.Repository;
using Password_Manager.Models;
using Password_Manager.CsvCreator;

Filter chain = new SetUpChain().GetChain();


Username myEmail = Username.CreateThisEmail("giulio.sanna@outlook.it");
Password myPassword = new("PAssw#ods001!!!");

if (chain.UnlockNextFilter(myPassword))
{
    var accRep = new AccountRepository();
    //accRep.Insert(myEmail, myPassword);
    var a = accRep.GetByMatricola(3);
    Console.WriteLine(a.ToString());
    
    Writer.Write(a);
}
    