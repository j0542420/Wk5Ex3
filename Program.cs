using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex3
{
    internal class Program
    {
        static List<string> page = new List<string>();

        static void newPage()
        {
            Console.WriteLine("Enter webpage URL: ");
            string url = Console.ReadLine();

            page.Add(url);
        }
        static void goBack()
        { 
        
        }
        static void history()
        { 
        
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome Web Browser Back button Application");
                Console.WriteLine("1 - Visit New Page");
                Console.WriteLine("2 - Go Back");
                Console.WriteLine("3 - View Browsing History");
                Console.WriteLine("4 - EXIT");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        newPage();
                        break;
                    case "2":
                        goBack();
                        break;
                    case "3":
                        history();
                        break;
                    case "4":
                        Console.WriteLine("Closing the program....");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;

                }
            }
        }
    }
}
