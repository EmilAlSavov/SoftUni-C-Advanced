using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);

                using (writer)
                {
                    int counter = 0;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                            break;

                        writer.WriteLine(counter + ". " + line);
                        counter++;
                    }
                }
            }
        }
    }
}

