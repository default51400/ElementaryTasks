using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4FileParser
{
    public class Parser
    {
        public string Path { get; set; }

        public Parser(string path)
        {
            Path = path;
        }

        public virtual int GetCountEntries(string searchingString)
        {
            int countEntry = 0;

            using (StreamReader reader = new StreamReader(Path, Encoding.Default))
            {
                // more effective than string
                StringBuilder line = new StringBuilder();

                while ((line.Append(reader.ReadLine())) != null)
                {
                    if (line.Length == 0)
                        break;
                    countEntry += GetCountEntry(line.ToString(), searchingString);
                    line.Clear();
                }
            }

            return countEntry;
        }
        
        public virtual void ReplaceAll(string searchingString, string replacementString)
        {
            int countEntry = 0;

            string tempFileName = System.IO.Path.GetRandomFileName() + ".txt";

            using (File.Create(tempFileName)) { }
            
            using (StreamWriter writer = new StreamWriter(tempFileName))
            {
                using (StreamReader reader = new StreamReader(Path, Encoding.Default))
                {
                    // more effective than string
                    StringBuilder line = new StringBuilder();
                    
                    while ((line.Append(reader.ReadLine())) != null)
                    {
                        if (line.Length == 0)
                            break;
                        countEntry += GetCountEntry(line.ToString(), searchingString);
                        if (countEntry > 0)
                        {
                            line = line.Replace(searchingString, replacementString);
                            writer.WriteLine(line);
                            //Console.WriteLine(line);
                        }
                        line.Clear();
                    }
                    
                }
            }
            if (countEntry == 0)
            {
                TrySaveFile(countEntry, tempFileName);
                throw new ArgumentException("Searching string not found at this text");
            }

            TrySaveFile(countEntry, tempFileName);
        }

        private void TrySaveFile(int countEntry, string tempFileName)
        {
            try
            {
                if (countEntry > 0)
                    File.Replace(tempFileName, Path, null);
                if (countEntry == 0)
                    return;
            }
            catch(IOException ex)
            {
                throw new IOException($"File save failed: {tempFileName} \nException: {ex.Message}");
            }
        }

       

        private static int GetCountEntry(string line, string searchingString)
        {
            int startIndex = 0;
            int countEntry = 0;
            do
            {
                //TODO: ASK need StringComparisonType ? 
                startIndex = line.IndexOf(searchingString, startIndex);
                if (startIndex > -1)
                {
                    countEntry++;
                    startIndex++;
                }
            } while (startIndex > -1);

            return countEntry;
        }
    }
}
