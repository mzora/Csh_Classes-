using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Design a class called Post. This class models a StackOverflow post. 
 
    It should have properties for title, description and the date/time it was created. 
 We should be able to up-vote or down-vote a post. 
 We should also be able to see the current vote value.
 
    In the main method, create a post, up-vote and down-vote it a few times
 and then display the the current vote value.

In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. 
You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. 

The class should always protect its state and hide its implementation detail.

Educational tip: The aim of this exercise is to help you understand that classes should
encapsulate data AND behaviour around that data. 
Many developers (even those with years of experience) tend to create classes that are purely data containers,
and other classes that are purely behaviour (methods) providers. 

This is not object-oriented programming. 
This is procedural programming. Such programs are very fragile. Making a change breaks many parts
of the code.
*/

namespace Exercise_StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tap 'y' to create a new Post");
            
            string createPost = Console.ReadLine();
            var postsList = new List<Post>();
            int id = 1;

            while (createPost.ToLower() == "y")
            {
                Console.WriteLine("Type the title: ");
                string postTitle = Console.ReadLine();
                
                Console.WriteLine("Type the description: ");
                string postDescr = Console.ReadLine();

                postsList.Add(new Post(id, postTitle, postDescr));
                
                id += 1;
                
                Console.WriteLine("Tap 'y' to create another post or 'n': ");
                createPost = Console.ReadLine();
            }

            Console.WriteLine("The following are your posts: ");

            for (var i = 0; i < postsList.Count; i++)
            {
                Console.WriteLine(postsList[i].Getid() + " " + postsList[i].GetTitle());
            }

            bool gameOn = true;
            
            while (gameOn)
            {
                Console.Write("Please up or down vote posts typing the post number and '+' or '-'" + "or hit enter finish: ");
                var inputVotes = Console.ReadLine();

                char[] PostAndVotes = inputVotes.ToCharArray();
                int postNo = Convert.ToInt32(PostAndVotes[0].ToString());
                var postVote = PostAndVotes[1].ToString();

                for (var i = 0; i < postsList.Count; i++)
                {
                    if (postNo == postsList[i].Getid())
                    {
                        if (postVote == "+")
                        {
                            postsList[i].UpVoting();
                        }
                        else if (postVote == "-")
                        {
                            postsList[i].DownVoting();
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid entry");
                        }
                    }                   
                }
                
                Console.WriteLine("'Enter' to other Vote or 'n' to next section");
                
                if(Console.ReadLine() == "n")
                    gameOn = false;
                
            }

            Console.WriteLine("Summary of posts with their votes");
            for (var i = 0; i < postsList.Count; i++)
            {
                Console.WriteLine("{0} {1} post has {2} votes", postsList[i].Getid(), postsList[i].GetTitle(), postsList[i].GetNumberOfVotes());
                Console.WriteLine(postsList[i].GetDescription());
                Console.WriteLine("*****************");
            }

            Console.ReadKey();
        }
    }
}
