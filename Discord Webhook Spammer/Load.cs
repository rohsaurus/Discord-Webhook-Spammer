using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Webhook_Spammer
{
    class Load
    {
        static string webhook = "";
        static string message = "";
        static string name = "";
        static string avatar = "";

        static void Main(string[] args)
        {

            Console.Title = "Discord Webhook Spammer by alecchernobyl";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Thank you for using my Discord Webhook Spammer!\nPlease Input the Webhook URL: ");
            webhook = Console.ReadLine();

            Console.WriteLine("Please Input the Username: ");
            name = Console.ReadLine();

            Console.WriteLine("Please Input the Avatar URL: ");
            avatar = Console.ReadLine();

            Console.WriteLine("Please Input the Message: ");
            message = Console.ReadLine();

            Console.Clear();

            while (true)
            {
                spammer();
            }

        }
        static async void spammer()
        {
            try
            {
                _ = Http.Post(webhook, new NameValueCollection()
                {
                {
                    "username",
                    name

                },
                {
                    "avatar_url",
                    avatar

                },
                {
                    "content",
                    message
                },


            });
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Successfully sended Webhook!");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] Couldn't send Webhook!");
            }
        }
    }
}
