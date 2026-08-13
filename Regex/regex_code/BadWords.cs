//9.Censor Bad Words in a Sentence
//Given a list of bad words, replace them with ****.
//Example Input: "This is a damn bad example with some stupid words."
//Expected Output: "This is a **** bad example with some **** words."


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

 namespace Regexx

{
    internal class BadWord
    {
        public void removeBadWords()
        {
            string sentence = "This is a damn bad example with some stupid words.";
            String ans = sentence;
            string[] badWords = { "damn", "stupid" };
            foreach (string word in badWords)
            {
                ans = ans.Replace(word, "***");
            }
            Console.WriteLine(ans);

        }

    }
}
