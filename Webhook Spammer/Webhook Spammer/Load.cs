using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Current Errors: 
/*
 * I have no clue why but the read input for the integer determing
 * the amount of times to loop is not reading the number the user entered
 * Right now it has choosen 49 and then after changing the code, it went to 50
 * 
 */
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
            
            
            
            Console.Title = "Webhook Spammer [v1] by Rohan Parikh";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thank you for using my Discord Webhook Spammer!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Credits to alecchernobyl for making the orignal code on github");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please Input the Webhook URL: ");
            webhook = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please Input the Username: ");
            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please Input the Avatar URL: ");
            avatar = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Please Input the Message: ");
            message = Console.ReadLine();

            Console.WriteLine("Do you have a set amount of times you want to send a message to the webhook or do you want  \n" +
                             "it to repeat forever? Type forever if you want it forever otherwise it will automatically go \n" +
                             " for a set amount of times" );
            
            String forever;
            forever = Console.ReadLine();
            if (forever.ToLower() == "forever")
            {
                Console.Clear();
            
                while (true)
                {
                    spammer();
                }
            }
            // Function for if user wants to choose amount of times to spam a webhook
            else
            {
                Console.WriteLine("How many times do you want to send the message to the webhook?");
                int Loops;
                Loops = Console.Read();
                
                for (int i = 0; i != Loops; i++)
                {
                    Console.WriteLine("i = " + i);
                    Console.WriteLine("Loops = "  + Loops);
                    spammer();
                }
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Successfully sended Webhook!");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(System.DateTime.Now.ToString("[hh:mm:ss]") + "> ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] Couldn't send Webhook!");
            }
        }
    }
}
