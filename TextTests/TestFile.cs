using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTests
{
    internal class TestFile
    {
        public string Path;
        public string Content;

        public TestFile(string path, string content)
        {
            Path = path;
            Content = content;
        }
    }
}
