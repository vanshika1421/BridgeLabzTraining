//Linear Search Problem 2: Search for a Specific Word in a List of Sentences
//Problem: You are given an array of sentences. Write a program that performs
//Linear Search to find the first sentence containing a specific word.


using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_Search
{
    internal class SearchForSpecificWord
    {
        public void FindSentenceContainingWord(String word , String[] sentences)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {

                    Console.WriteLine(sentences[i]);
                    return;
                }
            }

        }
    }
}
