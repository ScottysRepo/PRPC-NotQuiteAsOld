using System;
using LoginLibrary;

namespace LoginClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "abc123";
            string userName = "abc";
            LoginProvider provider = new LoginProvider();
            Console.WriteLine("Please enter password");
            string enteredPassword = Console.ReadLine();
            if(enteredPassword != password){
                Console.WriteLine("Incorrect password, please try again");
                //return enteredPassword;
            }else if(enteredPassword == password){
                Console.WriteLine("LogIn successful! Welcome {0}",userName);
               // return password;
            }else{
                 Console.WriteLine("This account does not exist");
                // return enteredPassword;
            }
           // PasswordVerify(enteredPassword);
           // string inputtedPassword = Console.ReadLine();
           // Console.WriteLine(LoginProvider.PasswordVerify(abc123));
            Console.WriteLine("Hello World!");
            //Console.WriteLine(PRPC.Method());
        }
    }
}
