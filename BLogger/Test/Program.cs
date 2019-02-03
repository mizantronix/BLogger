using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    using Blogger;
    class Program
    {
        static void Main(string[] args)
        {
            var logPath = @"C:\test";
            var fileName = "testFileName";

            var blogger1 = new Blogger(logPath, fileName, false);

            blogger1.LogEvent("bla", "Тестовое сообщение номер 1");
            blogger1.LogEvent("bla", "Тестовое сообщение номер 2");
            blogger1.LogEvent("bla", "Тестовое сообщение номер 3");
            blogger1.LogEvent("bla", "Тестовое сообщение номер 4");

            Console.WriteLine("Done");

            var blogger2 = new Blogger(logPath, enambleDate: true);
            blogger2.LogEvent("", "Тестовое сообщение номер 1");
            blogger2.LogEvent("", "Тестовое сообщение номер 2");
            blogger2.LogEvent("bla", "testHeader", "Тестовое сообщение номер 3");

            Console.ReadLine();
        }
    }
}
