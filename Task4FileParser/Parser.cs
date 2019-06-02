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
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    countEntry = GetCountEntry(line, searchingString, countEntry);
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
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        countEntry = GetCountEntry(line, searchingString, countEntry);
                        if (countEntry > 0)
                        {
                            line = line.Replace(searchingString, replacementString);
                            writer.WriteLine(line);
                            Console.WriteLine(line);
                        }
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
            catch
            {
                throw new IOException($"File save failed: {Path}");
            }
            finally
            {
                TryDeleteFile(tempFileName);
            }
        }

        private void TryDeleteFile(string tempFileName)
        {
            try
            {
                File.Delete(tempFileName);
            }
            catch
            {
                throw new IOException($"Temporary file delete failed: {tempFileName}  ");
            }
        }

        private static int GetCountEntry(string line, string searchingString, int countEntry)
        {
            int startIndex = 0;
            do
            {
                //TODO: ASK StringComparisonType ? 
                startIndex = line.IndexOf(searchingString, startIndex);
                if (startIndex > -1)
                {
                    countEntry++;
                    startIndex++;// = Math.Min(++startIndex, line.Length);
                }
            } while (startIndex > -1);

            return countEntry;
        }
    }
}
