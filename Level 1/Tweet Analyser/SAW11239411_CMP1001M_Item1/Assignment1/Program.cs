//#define Test
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment1
{
    class HashTagVisualiser
    {
        public static void Main(string[] args)
        {
            HashTagVisualiser Check = new HashTagVisualiser();
            TextReader tr = new StreamReader("tweets.txt");
            int TotalHash = 0; //counter for total number of hashtags
            int IndiHash = 0;  //counter for the number of unique hashtags
            string Tweets = "";
            char[] purge = {'#'}; //char array for use with the .trim method allowing the program to get rid of the '#' character in tweets.
            int x = 0;
            int charcount = 0;
            int MeanChar = 0;
            Dictionary<string, int>
                TweetStore = new Dictionary<string, int>();//Creates Dictionary to hold information about tweets.

            
            TextWriter tf = new StreamWriter("Test_File.txt"); //Creates test file, nothing is written to it unless in test mode, created here to prevent error code when passing parameter to methods.

#if Test //Test, Checks to make sure that the tweets.txt file exists and therefore will be opened correctly.
            DateTime Time = DateTime.Now;
            tf.WriteLine("~~~Test on {0}~~~", Time);
            Console.WriteLine("~~~Test Commencing~~~");
            if (File.Exists("tweets.txt"))
            {
                tf.WriteLine("File Found and Opened.");
            }
            else
            {
                tf.WriteLine("File Not Found.");
            }
#endif

            while (true)//Loop to read from tweets.txt file and then add these values to the dictionary.
            {

                
                Tweets = tr.ReadLine();
                    if (Tweets == null)
                        break;


                    if (Tweets != "#")
                    {
                        TotalHash++;
                        Tweets = Tweets.Trim(purge);
                        Tweets = Tweets.ToLower();
                        charcount = charcount + Tweets.Length;


                        if (TweetStore.ContainsKey(Tweets))
                        {
                            TweetStore[Tweets]++;
                        }
                        else
                        {
                            TweetStore.Add(Tweets, 1);
                        }
                    }
            }

#if Test //Test to look through the dictionary and make sure that the # has been removed and there were no "null" values stored in the dictionary. 
            if (TweetStore.ContainsKey("#"))
            {
                tf.WriteLine("Unaltered # found.");
            }
            if (TweetStore.ContainsKey(""))
            {
                tf.WriteLine("Null value discovered.");
            }
            
#endif 
            
            IndiHash = TweetStore.Count;
            MeanChar = charcount / TotalHash;

            TextWriter tw = GenerateOutput(TotalHash, IndiHash, ref x, charcount, MeanChar, TweetStore, tf);
            tw.Close();
#if Test 
            tf.Close();
#endif
            
        }

        private static TextWriter GenerateOutput(int TotalHash, int IndiHash, ref int x, int charcount, int MeanChar, Dictionary<string, int> TweetStore, TextWriter tf)//method that creates .html file and writes to it as well as outputting important information to the screen.
        {
            TextWriter tw = new StreamWriter("HashTags.html");//Creates new .html file.
#if Test//test to see if new .html file has been created.
            if (File.Exists("HashTags.html"))
            {
                tf.WriteLine(".html File Created.");
            }
            else
            {
                tf.WriteLine(".html File Not Created.");
            }
#endif
            tw.WriteLine("<html> \n<body> \n<h1>Hashtag Visualiser</h1>");
            Console.WriteLine("\nNumber of hashtags is: {0} \nTotal number of individual hashtags is: {1} \nTotal number of characters is: {2} \nMean number of characters in a tweet is: {3}\n", TotalHash, IndiHash, charcount, MeanChar);
            tw.WriteLine("<p>Number of hashtags is: {0}</p> \n<p>Total number of individual hashtags is: {1}</p>\n<p>Total number of characters is: {2}</p> \n<p>Mean number of characters in a tweet is: {3}</p>", TotalHash, IndiHash, charcount, MeanChar);
            tw.WriteLine("\n<h3>Top 20 Hashtags selected by number of times tweeted</h3> \n<table border> \n<tr> \n\t<td>Hashtag</td> \n\t<td>Number of Tweets</td> \n</tr>");

            foreach (KeyValuePair<string, int> pair in TweetStore.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                tw.WriteLine("\n<tr>\n\t<td>{0}</td> \n\t<td>{1}</td> \n</tr>", pair.Key, pair.Value);
                x++;
                if (x == 20)//If statement to break the loop when top 20 values have been output.
                {
                    break;
                }

            }
            tw.WriteLine("\n</table>");
            tw.WriteLine("\n<h3> Summary of all Hashtags</h3> \n<table border> \n<tr> \n\t<td>Hashtag</td> \n\t<td>Number of Tweets</td> \n</tr>");
            foreach (KeyValuePair<string, int> pair in TweetStore.OrderByDescending(key => key.Value))
            {
                tw.WriteLine("\n<tr>\n\t<td>{0}</td> \n\t<td>{1}</td> \n</tr>", pair.Key, pair.Value);
            }
            tw.WriteLine("\n</table>");
            tw.WriteLine("\n</body> \n</html>");
            return tw;
        }


    }

}
	
