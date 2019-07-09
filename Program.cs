using System;
using System.Collections.Generic;

namespace words_dictionay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Sauce", "What students put on the Awesome");
            wordsAndDefinitions.Add("Dank", "When something is even better than Awesome");
            wordsAndDefinitions.Add("Lit", "When students are on a roll writing C#");
            wordsAndDefinitions.Add("Trill", "When students who write C# are well respected for their mad skills");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Dank"]);
            Console.WriteLine(wordsAndDefinitions["Trill"]);
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of '{word.Key}' is '{word.Value}'");
            };

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> famWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            famWord.Add("word", "fam");
            famWord.Add("definition", "all your friends and also people you don't know");
            famWord.Add("part of speech", "noun");
            famWord.Add("example sentence", "It's lit fam!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(famWord);

            // create another Dictionary and add that to the list

            Dictionary<string, string> sackWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            sackWord.Add("word", "hackey-sack");
            sackWord.Add("definition", "the best game ever invented for you and your fam");
            sackWord.Add("part of speech", "noun");
            sackWord.Add("example sentence", "Hey fam this game of hackey-sac is lit!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(sackWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (var dict in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (var kvpair in dict)
                {
                    Console.WriteLine($"{kvpair.Key}: {kvpair.Value}");
                }
            }
        }
    }
}
