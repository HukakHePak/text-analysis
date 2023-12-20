namespace TextTests
{
    public class Tests
    {
        TextAnalyser analyser;
        string[] testFilePaths = { "TextFile1.txt" };

        List<TestFile> TestFiles;

 
        [SetUp]
        public void Setup()
        {
            TestFiles = new List<TestFile>();

            foreach (var path in testFilePaths)
            {
                var file = new TestFile(path, File.ReadAllText(path));

                TestFiles.Add(file);
            }
        }

        [Test]
        public void TestContent()
        {
            string fileContent = "Text file load string success";

            var TAn = new TextAnalyser();

            TAn.Content = fileContent;

            Assert.That(TAn.Content, Is.EqualTo(fileContent));
        }

        [Test]
        public void TestLoadFromFile()
        {
            var file = TestFiles[0];

            analyser = new TextAnalyser();

            Assert.DoesNotThrow(() =>
            {
                analyser.Load(file.Path);
            });

            Assert.That(analyser.Content, Is.EqualTo(file.Content));
        }

        [Test]
        public void TestPunctuationCount()
        {
            Assert.That(analyser.PunctuationCount, Is.EqualTo(4));
        }

        [Test]
        public void TestReadTime()
        {
            Assert.That(analyser.AverageReadTime, Is.EqualTo("00:00:05"));
        }
    }
}