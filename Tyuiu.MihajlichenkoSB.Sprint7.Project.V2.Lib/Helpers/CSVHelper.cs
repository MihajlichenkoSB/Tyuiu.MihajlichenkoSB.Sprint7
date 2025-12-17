using System.IO;
using System.Linq;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Helpers
{
    public static class CSVHelper
    {
        public static void SaveToCSV(string path, List<string[]> data)
        {
            var lines = data.Select(d => string.Join(";", d));
            File.WriteAllLines(path, lines);
        }

        public static List<string[]> LoadFromCSV(string path)
        {
            if (!File.Exists(path)) return new List<string[]>();

            var lines = File.ReadAllLines(path);
            return lines.Select(l => l.Split(';')).ToList();
        }
    }
}