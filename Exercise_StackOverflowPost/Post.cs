using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_StackOverflowPost
{
    class Post
    {
        public string _title { get; set; }
        //public string description{ get; set; }
        private int vote = 0;
        DateTime oraPost = DateTime.Now;

        public int currentVote()
        {
            return this.vote;
        }

        public void upVote()
        {
            this.vote++;
        }

        public void downVote()
        {
            this.vote--;
        }

        /***********************/
        private int Id;
        private string title;
        private string description;
        private DateTime postDateTime;
        private int numberOfVotes = 0;

        //ctor
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

        public int Getid()
        {
            return Id;
        }

        private void Setid(int value)
        {
            Id = value;
        }

        public string GetDescription()
        {
            return description;
        }

        private void SetDescription(string value)
        {
            description = value;
        }

        public DateTime GetdateAndTimeOfPost()
        {
            return postDateTime;
        }

        private void SetPostDateTime(DateTime value)
        {
            postDateTime = value;
        }

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
