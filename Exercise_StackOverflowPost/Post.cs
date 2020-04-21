using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_StackOverflowPost
{
    class Post
    {
        private int Id;
        private string title;
        private string description;
        private DateTime postDateTime;
        private int numberOfVotes = 0;

        //constructor
        public Post(int id, string postTitle, string postDescr)
        {
            Setid(id);
            SetTitle(postTitle);
            SetDescription(postDescr);
            SetNumberOfVotes(0);
            SetPostDateTime(DateTime.Now);
        }

        //methods
        public void UpVoting()
        {
            SetNumberOfVotes(GetNumberOfVotes() + 1);
        }
        public void DownVoting()
        {
            SetNumberOfVotes(GetNumberOfVotes() - 1);
        }

        //Getters and setters. Note that some are private. 
        public string GetTitle()
        {
            return title;
        }
        private void SetTitle(string value)
        {
            title = value;
        }
        //****************
        public int Getid()
        {
            return Id;
        }
        private void Setid(int value)
        {
            Id = value;
        }
        //*****************
        public string GetDescription()
        {
            return description;
        }
        private void SetDescription(string value)
        {
            description = value;
        }
        //*****************
        public DateTime GetdateAndTimeOfPost()
        {
            return postDateTime;
        }
        private void SetPostDateTime(DateTime value)
        {
            postDateTime = value;
        }
        //******************
        public int GetNumberOfVotes()
        {
            return numberOfVotes;
        }
        private void SetNumberOfVotes(int value)
        {
            numberOfVotes = value;
        }
    }


}
