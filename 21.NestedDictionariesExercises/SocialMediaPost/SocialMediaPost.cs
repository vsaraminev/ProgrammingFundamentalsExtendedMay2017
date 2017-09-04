using System;
using System.Collections.Generic;

namespace SocialMediaPost
{
    public class SocialMediaPost
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var socialDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            while (input != "drop the media")
            {
                var currentInput = input.Split(' ');
                var command = currentInput[0];
                var post = currentInput[1];

                if (!socialDictionary.ContainsKey(post))
                {
                    socialDictionary[post] = new Dictionary<string, List<string>>();
                }

                if (command == "like")
                {
                    if (!socialDictionary[post].ContainsKey("Like"))
                    {
                        socialDictionary[post]["Like"] = new List<string>();
                    }

                    socialDictionary[post]["Like"].Add(command);
                }
                else if (command == "dislike")
                {
                    if (!socialDictionary[post].ContainsKey("Dislike"))
                    {
                        socialDictionary[post]["Dislike"] = new List<string>();
                    }

                    socialDictionary[post]["Dislike"].Add(command);
                }
                else if (command == "comment" )
                {
                    var commentName = currentInput[2];
                    var lenght = command.Length + post.Length + commentName.Length + 3;

                    var comment = input.Substring(lenght);

                    if (!socialDictionary[post].ContainsKey(commentName))
                    {
                        socialDictionary[post][commentName] = new List<string>();
                    }

                    socialDictionary[post][commentName].Add(comment);
                }

                input = Console.ReadLine();                
            }

            foreach (var post in socialDictionary)
            {
                var likes = 0;
                var dislikes = 0;

                bool foundComment = false;

                foreach (var item in post.Value)
                {
                    if (item.Key == "Like")
                    {
                        likes = item.Value.Count;
                    }
                    else if (item.Key == "Dislike")
                    {
                        dislikes = item.Value.Count;
                    }
                }

                Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                foreach (var comment in post.Value)
                {
                    if (comment.Key!= "Like" && comment.Key!= "Dislike")
                    {
                        foundComment = true;

                        foreach (var item in comment.Value)
                        {
                            Console.WriteLine($"*  {comment.Key}: {item}");
                        }
                    }
                }

                if (!foundComment)
                {
                    Console.WriteLine("None");
                }

            }
        }
    }
}
