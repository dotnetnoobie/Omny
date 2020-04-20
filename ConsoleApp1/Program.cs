using System;
using System.Net.Http;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new Omny.Client(new HttpClient());

            var x = client.Programs().GetAwaiter().GetResult();

            var xx = x;
        }
    }
}
