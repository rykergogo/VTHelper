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
            switch (args.Length) {
                case 0:
                    Console.WriteLine("Usage: VTHelper.exe -s:hash -a:api-key");
                    break;
                case 1:
                    if (args[0] == "--h" || args[0] == "--help")
                    {
                        FlagPrint.HelpScript();

                    } else
                    {
                        Console.WriteLine("Usage: VTHelper.exe -s:hash -a:api-key");
                    }
                    break;
                case 2:
                    if ((args[0] == "-s" || args[1] == "-s") && (args[0] == "-a" || args[1] == "-a"))
                    {
                        // TODO: handle Hash and API
                        WelcomePrint.WelcomeScript();
                        FileGetter.FileGet();
                    }
                    else
                    {
                        Console.WriteLine("Usage: VTHelper.exe -s:hash -a:api-key");
                    }
                    break;
                default:
                    Console.WriteLine("Input not understood. Use \"--h\" or \"--help\" for more info.");
                    break;
            }
        }
    }
}
