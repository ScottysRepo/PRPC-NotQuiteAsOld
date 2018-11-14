using dotenv.net;
using SendGridLib;
namespace PRPC_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Config();
            VerifyEmail converter = new VerifyEmail();
            converter.VerifyEmail("");

        }
}
}