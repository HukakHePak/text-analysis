namespace TextTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string filePath = "./TextFile1.txt";
            string fileContent = "Text file load string success";

            var TAn = new TextAnalyser();

            Assert.DoesNotThrow(() => {
                TAn.Load(filePath);
            });

            // TAn.Content = fileContent;

            Assert.That(TAn.Content, Is.EqualTo(fileContent));
            
            Assert.Pass();
        }
    }
}