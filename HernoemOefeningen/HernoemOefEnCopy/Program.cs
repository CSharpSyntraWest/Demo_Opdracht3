using System;
using System.IO;

namespace HernoemOefEnCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string destFolder = @"C:\COMPARE";

            //CopyFolder(@"C:\OEF\Andrea\Herhalingsoef26tot40", destFolder, "Andrea_");
            CopyFolder(@"C:\OEF\Andrea\herhalingsoef41tot49", destFolder, "Andrea_");
            // CopyFolder(@"C:\OEF\BRIANA\SyllabusHFDSTK1_2_3_4", destFolder, "Briana_");
            //CopyFolder(@"C:\OEF\Dries\ProjectenVisualStudio", destFolder, "Dries_");
            //CopyFolder(@"C:\OEF\Evert1\Oefeningen", destFolder, "Evert_");
            //CopyFolder(@"C:\OEF\Jasper\Oefeningen_Week1", destFolder, "Jasper_");
            //CopyFolder(@"C:\OEF\Jesse\OefeningenSyllabus", destFolder, "Jesse_");
            //CopyFolder(@"C:\OEF\Lander\TEMP", destFolder, "Lander_");
            //CopyFolder(@"C:\OEF\Louisa", destFolder, "Louisa_");
            //CopyFolder(@"C:\OEF\Matthias\Lesweek1Oefeningen",destFolder,"Matthias_");
            //CopyFolder(@"C:\OEF\Pascal\PascalVanWijk", destFolder, "Pascal_");
            //CopyFolder(@"C:\OEF\Remy\Oefening_1", destFolder, "Remy_");
            //CopyFolder(@"C:\OEF\Stijn\StijnClareboutOefSyllabus", destFolder, "Stijn_");
        }

        static void CopyFolder(string sourceFolder, string destFolder, string prefix)
        {
            if (!Directory.Exists(destFolder))
            {
                Console.WriteLine($"Aanmaken van folder {destFolder}");
                Directory.CreateDirectory(destFolder);
            }
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                if (file.EndsWith(".cs") && !file.EndsWith("AssemblyInfo.cs") && !file.EndsWith("AssemblyAttributes.cs"))
                {
                    string vanBestandsNaam = Path.GetFileName(file);
                    string dirName = new DirectoryInfo(sourceFolder).Name.Replace(" ", ""); 
                    string naarPadMetBestandsNaam = Path.Combine(destFolder, prefix + dirName + vanBestandsNaam);
                    Console.WriteLine($"Kopiëren van bestand {vanBestandsNaam} naar {naarPadMetBestandsNaam}");
                    File.Copy(file, naarPadMetBestandsNaam);
                }
            }

            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string naam = Path.GetFileName(folder);
                string naarPad = Path.Combine(destFolder, naam);
                Console.WriteLine($"Kopiëren van subfolder {naam} naar {naarPad}");
                CopyFolder(folder, naarPad,prefix);
            }
        }
    }
}
