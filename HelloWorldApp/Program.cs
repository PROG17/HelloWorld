using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Är det dags för lunch snart eller?
            Console.WriteLine("Hello Nackademin!");

            Console.WriteLine("Andreas was here!");

            Console.WriteLine("Fredrik was here!");

            Console.WriteLine("Jag smög in en...//Elias");

            Console.WriteLine("johanna");

            Console.WriteLine("Thomas was here, but the he left");
            Console.WriteLine("Jag smög in en...");

            Console.WriteLine("hejhej på dig!");

            Console.WriteLine("Feyona is here to stay!");

            Console.WriteLine("HEj hej");
            
            Console.WriteLine (new string (Array.ConvertAll(new int[]
 {107,97,108,108,101,32,119,97,115,32,104,101,114,101},c=>(char)c))) ;
        }
    }
}
