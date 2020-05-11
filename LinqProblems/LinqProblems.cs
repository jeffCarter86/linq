using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
   public class LinqProblems
    {
      

        List<string> wordlist = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
        List<string> classGrades = new List<string>() {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"};

        List<string> shortName = new List<string>() { "Carter" };

        public LinqProblems()
        {
            WordsStartWithTh(wordlist);
            WordsRemoveDuplicates(names);
            GradesAveraged(classGrades);
            ShortenWord();
        }

        public void WordsStartWithTh(List<string> wordString)
        {
            var words = wordString;
            var thWords = words.Where(w => w.Contains("th"));
            foreach (var word in thWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        public void WordsRemoveDuplicates(List<string> names)
        {
            var words = names;
            var removedWords = words.Distinct();
            foreach (var word in removedWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}

