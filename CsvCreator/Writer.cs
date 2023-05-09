using Password_Manager.Repository;
using Password_Manager.Models;

namespace Password_Manager.CsvCreator
{
    public static class Writer
    {
        const string FilePath = @"C:\Users\Giuli\source\repos\Password_Manager\MyCsvFile";
        public static void Write(Account myAccount)
        {
            string filename = Path.Combine(FilePath,myAccount.AccNameFile());
            using StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine("Matricola;Email;Password;Data Di Creazione");
            writer.WriteLine(myAccount.GetSpec());
        }
    }
}
