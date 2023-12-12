namespace Translator
{
    public class TranslateService
    {
        
        public Dictionary<string, string> _translation { get; set; }

        public TranslateService() 
        { 
            _translation = new Dictionary<string, string>();
            _translation.Add("dog", "собака");
            _translation.Add("cat", "кошка");
        }

        public void AddTranslation(string str1, string str2)
        {
            _translation.Add(str1, str2);
        }

        public string GetTranslation(string str)
        {
            return _translation[str];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}