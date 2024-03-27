using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class String
    {
        public static void main()
        {
            string word = "hello world";
            word.Print();
            word.ToUpper().Print();
            word.ToLower().Print();
            if(word.ToUpper() == "hello world".ToUpper()) 
                true.Print();
            else
                false.Print();
            string word1 = "!!!";
            int x = 5;
            string word2 = @$"{word} + {word1} = {x}";
            word2.Print();
            int index = word.IndexOf("!!!")+3;
            word.Insert(index, " everyone").Print(); 
            word2 = word2.Remove(index-3,3).Print();
            word2 = word2.Replace("everyone", "earth").Print();
            word2 = word2.Replace("hello ", "").Print();
            word2 = word2[5..^0].Print();
            word2.Print();

        }
    }
}
