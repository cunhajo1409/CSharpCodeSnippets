using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCodeSnippets
{
    public partial class AlgorithmsCSharp
    {
        public static void WriteToLogFile(string filePath, string message, bool includeTime = false )
        {
            try
            {
                string logEntry = "";
                
                if (includeTime)
                {
                    logEntry = $"{DateTime.Now}: {message}";
                }
                else
                {
                    logEntry = $"{message}\n";
                }    

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the log file: {ex.Message}");
            }
        }
     
        public static void AppendToLogFile(string filePath, string message, bool includeTime = false)
        {
            try
            {
                string logEntry = (includeTime)? $"{DateTime.Now}: {message}" : message;
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                        writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the log file: {ex.Message}");
            }
        }
    }
    
}

