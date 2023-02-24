using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSB.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addCommment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void removeCommment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            //StringBuilder
            StringBuilder sB = new StringBuilder();
            sB.AppendLine(Title);
            sB.Append(Likes);
            sB.Append("Likes - ");
            sB.AppendLine(Moment.ToString("dd/mm/yyyy HH:MM:ss"));
            sB.AppendLine(Content);
            sB.Append("Comments: ");
            foreach (Comment comment in Comments)
            {
                sB.AppendLine(comment.Text);
            }
            return sB.ToString();
        }
    }
}