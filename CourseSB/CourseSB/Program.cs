using CourseSB.Entities;
using System.Security.Cryptography;

namespace CourseSB
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow tha's awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:33"),
                "Traveling to New Zealand",
                "I'am going to visit this...",
                12
                );

            p1.addCommment(c1);
            p1.addCommment(c2);

            Comment c3 = new Comment("Have a nice trip");
            Comment c4 = new Comment("Wow tha's awesome");
            Post p2 = new Post(
                DateTime.Parse("21/06/2018 13:05:33"),
                "Traveling to New Zealand",
                "I'am going to visit this...",
                12
                );

            p1.addCommment(c3);
            p1.addCommment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}