using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader wordsReader = new StreamReader(wordsFilePath);
            var wordCount = new Dictionary<string, int>();

            wordCount = Read(wordsReader, wordCount, textFilePath);
            wordCount = wordCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            StreamWriter writer = new StreamWriter(outputFilePath);

            using (writer)
            {
                foreach (var word in wordCount)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }

        public static Dictionary<string, int> Read(StreamReader wordsReader, Dictionary<string, int> wordCount, string textFilePath)
        {
            using (wordsReader)
            {
                string[] words = wordsReader.ReadLine().Split();

                StreamReader textReader = new StreamReader(textFilePath);
                using (textReader)
                {
                    while (true)
                    {
                        string line = textReader.ReadLine();
                        if (line == null) break;

                        foreach (var word in words)
                        {
                            if (line.Contains(word))
                            {
                                if (!wordCount.ContainsKey(word))
                                {
                                    wordCount.Add(word, 0);
                                }
                                wordCount[word]++;
                            }
                        }
                    }
                }
            }
            return wordCount;
        }
    }
}

