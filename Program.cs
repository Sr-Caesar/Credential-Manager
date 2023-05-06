using Password_Manager.PasswordChecker;
using Password_Manager.PasswordChecker.PasswordRequirements;
using Password_Manager.UsernameVerification;
using Password_Manager.Repository;

Filter chain = new SetUpChain().GetChain();


Password pw1 = new("");
Password pw2 = new("pad");
Password pw3 = new("Password");
Password pw4 = new("Password1");
Password pw5 = new("Passwords1!");


Console.WriteLine(chain.UnlockNextFilter(pw1));
Console.WriteLine("------------------END---------------------");
Console.WriteLine(chain.UnlockNextFilter(pw2));
Console.WriteLine("------------------END---------------------");
Console.WriteLine(chain.UnlockNextFilter(pw3));
Console.WriteLine("------------------END---------------------");
Console.WriteLine(chain.UnlockNextFilter(pw4));
Console.WriteLine("------------------END---------------------");
Console.WriteLine(chain.UnlockNextFilter(pw5));
Console.WriteLine("------------------END---------------------");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Username a = Username.CreateThisEmail("diprova@Gmail.com");
Console.WriteLine(a.EmailName);
Console.WriteLine(a.EmailServer);
Console.WriteLine(a.EmailDomain);

//string mm = "gmail";
//string nn = "it";
//Console.WriteLine(Username.CheckServer(mm));
//Console.WriteLine(Username.CheckDomain(nn));

