using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text_analysis
{
    public class TextAnalyser
    {
        public string Content;

        public string Load(string uri)
        {
            Content = File.ReadAllText(uri);

            return Content;
        }

        private char[] PunctuationMarks = {',', '.', '?', '!', ':', };
        private char[] Delimiters = { ' ', ',', '.', '?', '!', ':', '\t' };

        double SignsPerMinute = 1000;

        public int PunctuationCount
        {
            get
            {
                var count = 0;

                foreach (var sign in PunctuationMarks)
                {
                    count += Content.Count(c => c == sign);
                }

                return count;
            }
        }

        public string AverageReadTime
        {
           get
            {
                return TimeSpan.FromMinutes(Content.Length / SignsPerMinute).ToString(@"hh\:mm\:ss");
            }
        }

        public TextAnalyser(string path)
        {
            Load(path);
        }

        public TextAnalyser()
        {

        }

        public string[] ParseWords(string str)
        {
            List<string> result = new List<string>();

            result = str.Split(Delimiters).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            return result.ToArray();
        }

        public int WordsCount
        {
            get
            {
                return ParseWords(Content).Count();
            }
        }
    }
}
