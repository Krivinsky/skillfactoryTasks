namespace Task13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Eugene\source\repos\skillfactory_tasks\Task13-6-1\Text.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            string[] stings = noPunctuationText.Split(' ', '\r', '\n');

            List<string> list = new List<string>();

            foreach (string str in stings)
            {
                if (str != string.Empty)
                {
                    list.Add(str);
                }
            }

            List<KeyValuePair<string, int>> keyValuePairs = GetTenWords(list);
            Console.WriteLine("10 слов чаще всего встречающиеся в тексте");

            foreach (KeyValuePair<string, int> pair in keyValuePairs)
            {
                Console.WriteLine($" Слово: \"{pair.Key}\" встречается - {pair.Value} раз");
            }

        }

        public static List<KeyValuePair<string, int>> GetTenWords(List<string> list)
        {
            Dictionary<string, int> allText = new Dictionary<string, int>();
            
            foreach (string str in list)
            {
                if (!allText.ContainsKey(str))
                {
                    allText.Add(str, 1);
                } else
                {
                    int i = allText[str];
                    i++;
                    allText[str] = i;
                }
            }
            
            List<KeyValuePair <string, int>> pair = allText.ToList();
            
            pair.Sort((x, y) => y.Value.CompareTo(x.Value));

            //дополнение
            var result = allText.OrderByDescending(x => x.Value).Take(10).ToList();
                         


            return pair.GetRange(0, 10);   
        }
    }
}