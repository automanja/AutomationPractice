using System.IO;

namespace AutomationPracticeLibrary.Manager
{
    public class DataManager
    {
        public void WriteResults(string result)
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Results.txt");

            if (File.Exists(startupPath))
            {
                string existingText = File.ReadAllText(startupPath);
                existingText += result;
                WriteToFile(startupPath, existingText);
            }
            else WriteToFile(startupPath, result);
        }

        private void WriteToFile(string startupPath, string text)
        {
            var streamWriter = new StreamWriter(startupPath);
            streamWriter.WriteLine(text);
            streamWriter.Close();
        }
    }
}
