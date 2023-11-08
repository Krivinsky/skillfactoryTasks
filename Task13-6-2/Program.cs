namespace Task13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string text = File.ReadAllText(@"C:\Users\Eugene\source\repos\skillfactory_tasks\Task13-6-1\Text.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            string[] stings = noPunctuationText.Split(' ', '\r', '\n');

            foreach (string str in stings)
            {
                if (str != string.Empty)
                {
                    list.Add(str);
                }
            }

            GetTenWords(list);

        }


        public static List<string> GetTenWords(List<string> list)
        {
            Dictionary<string, int> tenWords = new Dictionary<string, int>();
            
            foreach (string str in list)
            {
                if (!tenWords.ContainsKey(str))
                {
                    tenWords.Add(str, 1);
                } else
                {
                    int i = tenWords[str];
                    i++;
                    tenWords[str] = i;
                }
            }

            List<KeyValuePair <string, int>> pair = tenWords.OrderBy(x => x.Value).ToList();

            List<string> strings = new List<string>();

            for (int i = pair.Count; i < (pair.Count-9); i++)
            {
                strings.Add(pair[i].Key);
            }

            return strings;
        }
    }
}