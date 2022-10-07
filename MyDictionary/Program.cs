using Microsoft.VisualBasic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("istanbul", 34);
            dictionary.Add("ankara", 06);
            dictionary.Add("adana", 01);
            dictionary.Add("izmir", 35);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            MyDictionary<string, int> dictionary2 = new MyDictionary<string, int>();
            dictionary2.Add("eskişehir", 26);
            dictionary2.Add("konya", 42);
            dictionary2.Show();
            
        }
    }

    class MyDictionary<T1, T2>
    {
        KeyValuePair<T1, T2>[] dictionary;

        public MyDictionary()
        {
            dictionary = new KeyValuePair<T1, T2>[0];
        }

        public void Add(T1 key, T2 value)
        {
            KeyValuePair<T1, T2>[] _tempDict =  dictionary;
             dictionary= new KeyValuePair<T1, T2>[dictionary.Length +1];
            for (int i = 0; i < _tempDict.Length; i++)
            {
                dictionary[i] = _tempDict[i];
            }
            dictionary[dictionary.Length - 1] = new KeyValuePair<T1, T2>(key, value);
            
        }

        public void Show()
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("[" + item.Key + ", " + item.Value + "]");
            }
        }
    }

   
}