using System;
using LoginLibrary;

namespace LoginClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginProvider provider = new LoginProvider();
            Console.WriteLine("Please enter password");
           // string inputtedPassword = Console.ReadLine();
           // Console.WriteLine(LoginProvider.PasswordVerify(abc123));
            Console.WriteLine("Hello World!");
            //Console.WriteLine(PRPC.Method());
        }
    }
}
