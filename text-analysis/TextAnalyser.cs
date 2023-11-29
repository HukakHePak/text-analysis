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
<<<<<<< HEAD
            Uri Load = new Uri(uri);
            Content = File.ReadAllText(Load.OriginalString);
            return Content;
=======
            //Uri Load = new Uri(uri);
            return default;
>>>>>>> origin
        }

        private string[] PunctuationMarks = { "!", "?", ":", ",", "." };

        public TextAnalyser(string path)
        {
            Content = File.ReadAllText(path);
        }

        public TextAnalyser()
        {

        }
    }
}
