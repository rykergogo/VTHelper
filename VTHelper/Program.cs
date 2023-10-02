using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: -h <hash> -a <api-key>");
            } else if (args[0] == "-h" || args[0] == "--help")
            {
                FlagPrint.PrintHelp();

            } else if (args[0].Contains("-h") || args[1].Contains("-h"))
            {
                // TODO: handle Hash
            } else if (args[0].Contains("-a") || args[1].Contains("-a"))
            {
                // TODO: handle api key
            } else
            {
                Console.WriteLine("Welcome to VTHelper!");
                Console.WriteLine();
                WelcomePrint.WelcomeScript();
            }
        }
    }
}
