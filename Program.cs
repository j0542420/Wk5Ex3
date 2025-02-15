using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex3
{
    internal class Program
    {
        //crating a stack to hold data of pages visited
        static Stack<string> page = new Stack<string>();

        //method of going to a new page
        static void newPage()
        {
            //message to tell the user to input a page
            Console.WriteLine("Enter webpage URL: ");
            //user inputs a page to go to
            string url = Console.ReadLine();

            //saving the visited page to the stack
            page.Push(url);

        }
        //method for going back to a previse page
        static void goBack()
        {
            //making sure there is a page to go back too
            while (page.Count > 1)
            {
                //removing the current page the user is on
                page.Pop();
                //shows the previse page the user visited
                Console.WriteLine($"Going back to: {page.Peek()}");
            }
            //space so that the menu wont show after previse message
            Console.WriteLine();

        }
        static void history()
        {
            //message to say the history of the previse pages the user entered
            Console.WriteLine("Viewing your history: ");
            //making sure that there are pages to show
            while (page.Count > 0)
            {
                //shows the previse pages with a coma to seperate them 
                Console.Write(page.Pop() + "," );
            }
            //telling the user that there is no more pages to show
            Console.WriteLine("End of history");
        }
        //method of the menu
        static void Main(string[] args)
        {
            //loping through the menu
            while (true)
            {
                //showing the menu to the user so that they can pick a choice
                Console.WriteLine("Welcome Web Browser Back button Application");
                Console.WriteLine("1 - Visit New Page");
                Console.WriteLine("2 - Go Back");
                Console.WriteLine("3 - View Browsing History");
                Console.WriteLine("4 - EXIT");

                //inputs the user choice of operation
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
