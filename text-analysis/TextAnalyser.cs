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

        private string[] PunctuationMarks = { "!", "?", ":", ",", "." };

        double ReadTime = 1000;

        public int PunctuationCount()
        {
            return Content.Count(c => PunctuationMarks.Contains(c.ToString()));
        }

        public double AverageReadTime()
        {
            return Content.Length / 1000 * ReadTime;
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
            char[] delimiterChars = { ' ', ',', '.', '?', '!', ':', '\t' };
            result = str.Split(delimiterChars).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            return result.ToArray();
        }
        public int CountWords()
        {
            return ParseWords(Content).Count();
        }
    }
}
