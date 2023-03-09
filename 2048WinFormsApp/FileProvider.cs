using System.Text;

namespace _2048WinFormsApp
{
    public class FileProvider
    {
        public static void Replace(string pathFile, string value)
        {
            StreamWriter writer = new StreamWriter(pathFile, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static string GetValue(string pathFile)
        {
            StreamReader reader = new StreamReader(pathFile, Encoding.UTF8);
            var value = reader.ReadToEnd();
            reader.Close();

            return value;
        }

        public static bool Exists(string pathFile)
        {
            return File.Exists(pathFile);
        }

        /*public static void Clear(string pathFile)
        {
            File.WriteAllText(pathFile, string.Empty);
        }

        public static void Delete(string pathFile)
        {
            File.Delete(pathFile);
        }*/
    }
}