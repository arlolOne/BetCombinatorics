using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BetCombinatorics
{
    public static class FileTXT
    {
        private static StreamWriter writer;
        private static StreamReader reader;

        public static string GetDirectory(bool isSaving)
        {
            string directory = "";
            dynamic file;

            if (isSaving) 
            {
                file = new SaveFileDialog();
            } else 
            {
                file = new OpenFileDialog();
            }

            file.RestoreDirectory = true;
            file.DefaultExt = "txt";
            file.Filter = "txt files (*.txt) | *.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                directory = file.FileName;
            }

            file.Dispose();

            return directory;
        }

        public static void CreateReader(string directory)
        {
            reader = new StreamReader(directory, Encoding.Default);
        }

        public static string Read()
        {
            return reader?.ReadToEnd();
        }

        public static void RemoveReader()
        {
            reader?.Dispose();
        }

        public static void CreateWriter(string directory)
        {
            writer = File.CreateText(directory);
        }

        public static void Write(string text)
        {
            writer?.WriteLine(text);
        }

        public static void RemoveWriter()
        {
            writer?.Dispose();
        }
    }
}
