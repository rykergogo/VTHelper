using Aspose.Cells;
using Aspose.Cells.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VTHelper
{
    internal class ConversionHandler
    {
        public static int FlipAndWrite(string json, string hash)
        {
            try
            {
                var workbook = new Workbook();

                var worksheet = workbook.Worksheets[0];

                var layoutOptions = new JsonLayoutOptions();

                layoutOptions.ArrayAsTable = true;

                JsonUtility.ImportData(json, worksheet.Cells, 0, 0, layoutOptions);
                if (File.Exists(hash + ".csv"))
                {
                    DialogResult res = MessageBox.Show($"Do you want to overwrite old report for {hash}?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Console.WriteLine($"Deleting File: {hash}.csv");

                        File.Delete($"{hash}.csv");

                        Console.WriteLine("Writing contents to new file...");
                        
                        workbook.Save($"{hash}.csv", SaveFormat.Csv);
                        
                        Console.WriteLine($"Successfully wrote contents to {hash}.csv");
                        
                        return 0;

                    } else
                    {
                        return 1;
                    }
                }
                Console.WriteLine($"Writing contents to {hash}.csv");

                workbook.Save($"{hash}.csv", SaveFormat.Csv);

                Console.WriteLine($"Successfully wrote contents to {hash}.csv");

                return 0;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            
            

        }
    }
}
