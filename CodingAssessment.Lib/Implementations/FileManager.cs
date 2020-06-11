using CodingAssessment.Lib.Interface;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodingAssessment.Lib.Implementations
{
    /// <summary>
    /// This class would implement reading and saving on and to a physical file. 
    /// </summary>
    public class FileManager:IFileManager
    {
        private readonly string inputFilePath;
        private readonly string outputFilePath;
        public FileManager(string inputFilePath, string outputFilePath)
        {
            this.inputFilePath  = inputFilePath;
            this.outputFilePath = outputFilePath;
        }
        /// <summary>
        /// This methods is used to open and read the contents of the file.
        /// </summary>
        public List<string> Open()
        {
            if (!File.Exists(this.inputFilePath))
                throw new FileNotFoundException(message: $"File: {this.inputFilePath} was not found.");

            List<string> lines = File.ReadAllLines(this.inputFilePath).ToList<string>();
            return lines;
        }

        /// <summary>
        /// This method is used to save output to the outputFilePath.
        /// </summary>
        /// <param name="stringList"> Data to be saved.</param>
        public void Save(List<string> stringList)
        {
            CreatePathIfNotExists();

            using (TextWriter tw = new StreamWriter(this.outputFilePath))
            {
                foreach (string s in stringList)
                    tw.WriteLine(s);
            }
        }

        /// <summary>
        /// This method will create the Directory if not existing. 
        /// </summary>
        private void CreatePathIfNotExists()
        {
            var directoryName = Path.GetDirectoryName(this.outputFilePath);
            if (!Directory.Exists(directoryName))
            {
                //if directory doesn't exists try to create the it
                Directory.CreateDirectory(directoryName);
            }
        }
    }
}
