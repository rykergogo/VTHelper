using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTHelper
{
    internal class FlagPrint
    {
        public static void PrintHelp()
        {
            Console.WriteLine("____   __________________ ___         .__                       ");
            Console.WriteLine("\\   \\ /   /\\__    ___/   |   \\   ____ |  | ______   ___________ ");
            Console.WriteLine(" \\   Y   /   |    | /    ~    \\_/ __ \\|  | \\____ \\_/ __ \\_  __ \\");
            Console.WriteLine("  \\     /    |    | \\    Y    /\\  ___/|  |_|  |_> >  ___/|  | \\/");
            Console.WriteLine("   \\___/     |____|  \\___|_  /  \\___  >____/   __/ \\___  >__|   ");
            Console.WriteLine("                           \\/       \\/     |__|        \\/       ");
            
            Console.WriteLine();

            Console.WriteLine("Flags: \"-h\" OR \"--help\" to bring this page up.");
            Console.WriteLine();
            Console.WriteLine("VTHelper takes advantage of Virus Total's API to dump file info into an organized csv file.");
            Console.WriteLine();
            Console.WriteLine("API Key: You need to have a Virus Total account in order to get your API key.");
            Console.WriteLine();
            Console.WriteLine("Hash: File Hash can be generated after uploading file to Virus Total.");
        }
    }
}
