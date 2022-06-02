using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader reader1 =  new StreamReader(firstInputFilePath);
            StreamReader reader2 = new StreamReader(secondInputFilePath);

            string input1 = reader1.ReadToEnd();
            string input2 = reader2.ReadToEnd();

            StreamWriter writer = new StreamWriter(outputFilePath);

            using (writer)
            {
                if (input1.Length >= input2.Length)
                {
                    int counter = 0;
                    for (int i = 0; i < input2.Length; i++)
                    {
                        if (counter <= 1)
                        {
                            writer.Write(input1[i]);
                        }
                        else
                        {
                            writer.Write(input2[i]);
                            counter = -1;
                        }
                        counter++;
                    }
                    for (int i = input2.Length; i < input1.Length; i++)
                    {
                        writer.Write(input1[i]);
                    }
                }
                else
                {
                    int counter = 0;
                    for (int i = 0; i < input1.Length; i++)
                    {
                        if (counter <= 1)
                        {
                            writer.Write(input1[i]);
                        }
                        else
                        {
                            writer.Write(input2[i]);
                            if (counter == 3)
                            {
                                counter = -1;
                            }
                        }
                        counter++;
                    }
                    for (int i = input1.Length; i < input2.Length; i++)
                    {
                        writer.Write(input2[i]);
                    }
                }
            }
        }
    }
}

