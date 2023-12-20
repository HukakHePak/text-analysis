using System;

namespace text_analysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к файлу для начала анализа");

            while(true)
            {
                var path = Console.ReadLine();
                var analyser = new TextAnalyser();

                try
                {
                    analyser.Load(path);
                }
                catch
                {
                    Console.WriteLine("Ошибка загрузки файла");
                    continue;
                }

                Console.WriteLine("Количество знаков:\t" + analyser.Content.Length);
                Console.WriteLine("Количество слов:\t" + analyser.WordsCount);
                Console.WriteLine("Среднее время чтения:\t" + analyser.AverageReadTime);
                Console.WriteLine("Количество знаков препинания:\t" + analyser.PunctuationCount);
                    //Console.WriteLine("" , analyser);
                
            }
        }
    }
}
