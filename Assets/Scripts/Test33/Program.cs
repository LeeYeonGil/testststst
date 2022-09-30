using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220906005
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Items = new Dictionary<string, int>(); // 해시맵
            Items.Add("Sword", 30);
            Items.Add("Bow", 10);
            Items["Gun"] = 100;
            Items["Sword"] = 20;

            if (Items.ContainsKey("Bow")) // Bow값이 존재하면 Arrow 추가
            {
                Items.Add("Arrow", 5);
            }

            Items.Remove("Bow");


            for (int i = 0; i < Items.Keys.Count; i++)
            {
                Items[Items.Keys.ToArray()[i]] = 0;
            }

            foreach (KeyValuePair<string, int> p in Items)
            {
                //Console.WriteLine($"{p.Key} : {p.Value}");
            }

            for(int i = 0; i < Items.Keys.Count; i++)
            {
                Console.WriteLine($"{Items.Keys.ToArray()[i]} : {Items[Items.Keys.ToArray()[i]]}");
            }
            Console.WriteLine($"Size : {Items.Count}");

        }
    }
}
