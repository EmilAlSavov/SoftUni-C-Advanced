using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…

            StreamReader streamReader = new StreamReader(inputFilePath);

            using (streamReader)
            {
                int lineCount = 0;

                StreamWriter writer = new StreamWriter(outputFilePath);

                using (writer)
                {
                    while (true)
                    {
                        string line = streamReader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (lineCount % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        lineCount++;
                    }
                }
            }
        }
    }
}

