using dotenv.net;
using SendGridLib;

namespace SendGridClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Config();
            EmailConf converter = new EmailConf();
            converter.VerifyEmail("");

        }
}
}