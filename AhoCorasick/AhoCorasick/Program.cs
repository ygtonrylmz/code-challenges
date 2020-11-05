using System;
using System.Linq;

namespace AhoCorasick
{
    public class TrieOnly
    {
        static readonly int ALPHABET_SIZE = 26;
        // Trie Node
        internal class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];

            // isEndOfWord is true if the node represents
            // end of a word
            public bool isEndOfWord;

            public TrieNode()
            {
                isEndOfWord = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                    children[i] = null;
            }
        };

        static TrieNode root;

        // If not present, inserts key into trie 
        // If the key is prefix of trie node,  
        // just marks leaf node 

        static void Insert(string key)
        {
            int level;
            int length = key.Length;
            int index;

            TrieNode pCrawl = root;
            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                    pCrawl.children[index] = new TrieNode();

                pCrawl = pCrawl.children[index];
            }

            // mark last node as leaf 
            pCrawl.isEndOfWord = true;
        }

        static bool Search(string key)
        {
            int level;
            int length = key.Length;
            int index;

            TrieNode pCrawl = root;
            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                    return false;

                pCrawl = pCrawl.children[index];
            }

            return (pCrawl != null && pCrawl.isEndOfWord);
        }

        static void Main(string[] args)
        {
            //// Input keys (use only 'a'  
            //// through 'z' and lower case) 
            //string[] keys = {"the", "a", "there", "answer",
            //            "any", "by", "bye", "their"};

            //string[] output = { "Not present in trie", "Present in trie" };

            //root = new TrieNode();

            //// Construct trie 
            //int i;
            //for (i = 0; i < keys.Length; i++)
            //    Insert(keys[i]);

            //// Search for different keys 
            //if (Search("the") == true)
            //    Console.WriteLine("the --- " + output[1]);
            //else Console.WriteLine("the --- " + output[0]);

            //if (Search("these") == true)
            //    Console.WriteLine("these --- " + output[1]);
            //else Console.WriteLine("these --- " + output[0]);

            //if (Search("their") == true)
            //    Console.WriteLine("their --- " + output[1]);
            //else Console.WriteLine("their --- " + output[0]);

            //if (Search("thaw") == true)
            //    Console.WriteLine("thaw --- " + output[1]);
            //else Console.WriteLine("thaw --- " + output[0]);


            //Trie trie = new Trie();

            //// add words
            //trie.Add("hello");
            //trie.Add("world");

            //// build search tree
            //trie.Build();

            //string text = "hellow and welcome to this beautiful world!";

            //// find words
            //foreach (string word in trie.Find(text))
            //{
            //    Console.WriteLine(word);
            //}

            //Trie<int> trie = new Trie<int>();

            //// add words
            //trie.Add("hello", 123);
            //trie.Add("world", 456);

            //// build search tree
            //trie.Build();

            //string text = "hello and welcome to this beautiful world!";

            //// retrieve IDs
            //foreach (int id in trie.Find(text))
            //{
            //    Console.WriteLine(id);
            //}


            string[] text = "hello world i say to you".Split(' ');

            Trie<string, bool> trie = new Trie<string, bool>();
            trie.Add("hello world".Split(' '), true);
            trie.Build();
            bool containsHelloWorld = trie.Find(text).Any();
            Console.WriteLine(containsHelloWorld);

        }
    }
}
