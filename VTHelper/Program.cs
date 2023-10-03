using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTHelper
{
    internal class Program
    {
        static async Task Main(string[] args)
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
                    if ((args[0].Contains("-s") || args[1].Contains("-s")) && (args[0].Contains("-a") || args[1].Contains("-a")))
                    {
                        string hash = "";
                        string api = "";
                        
                        // TODO: handle Hash and API
                        switch (args[0].Contains("-s"))
                        {
                            case true:
                                hash = args[0].Substring(3);
                                break;
                            case false:
                                hash = args[1].Substring(3);
                                break;
                        }
                        switch (args[1].Contains("-a"))
                        {
                            case true:
                                api = args[1].Substring(3);
                                break;
                            case false:
                                api = args[0].Substring(3);
                                break;
                        }
                        Console.WriteLine(hash);
                        Console.WriteLine(api);
                        WelcomePrint.WelcomeScript();
                        await FileGetter.FileGetAsync(hash, api);
                        File.WriteAllText("output.txt", FileGetter.bodyData);
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
