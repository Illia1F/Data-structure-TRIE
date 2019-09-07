using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie<int>();

            trie.Add("Hello", 50);
            trie.Add("world", 100);
            trie.Add("honor", 200);

            Console.WriteLine(trie.TrySearch("honor", out int n));
            Console.WriteLine(trie.TrySearch("Hello", out int n1));
            Console.WriteLine(trie.TrySearch("world", out int n2));

            trie.Remove("Hello");

            Console.WriteLine(trie.TrySearch("Hello", out int n4));

            Console.ReadKey();
        }
    }
}
