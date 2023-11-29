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
            Uri Load = new Uri(uri);
            Content = File.ReadAllText(Load.OriginalString);
            return Content;
        }

        private string[] PunctuationMarks = { "!", "?", ":", ",", "." };

        public TextAnalyser(string path)
        {
            Content = File.ReadAllText(path);
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
