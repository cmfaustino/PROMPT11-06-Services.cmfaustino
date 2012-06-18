using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Document;
using Raven.Client.Indexes;
using Raven.Client.Linq;

namespace RavenDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var store = new DocumentStore()
            {
                Url = "http://localhost:8080/raven"
            }.Initialize())
            {
                IndexCreation.CreateIndexes(typeof(Program.Assembly),store);
                using (var session = store.OpenSession())
                {
                    var comments = new PostComments //necessario criar os tipos, pois ravendb nao suporta tipos dinamicos
                                       {
                                           Comments = new List<PostComments.Comment>()
                                       };
                    session.Store(comments);
                    var post = new Post //necessario criar os tipos, pois ravendb nao suporta tipos dinamicos
                                      {
                                          Title = "Some Title",
                                          CreatedAt = DateTimeOffset.Parse("2011-12-15"),
                                          Body = "Blablabla",
                                          AllowComments = true,
                                          Tags = new List<string>{"tag0","tag1","tag2"},
                                          CommentsId = comments.Id
                                      };
                    session.Store(post);
                    comments.PostId = post.Id;
                    session.SaveChanges();
                    var post = (from p in session.Query<Post>()
                                from tag in p.Tags
                                group p by tag
                                into g
                                where p.IsDeleted == false
                                select new {Tag = g.Key, Count = g.Count()});
                                //select p).Single; //idx criado ByIsDeleted
                    Console.WriteLine(post.Title);
                    var comments = session.Load<PostComments>(post.CommentsId);
                    Console.WriteLine(comments.Comments.Count);
                    foreach (Post post in posts)
                    {
                        Console.WriteLine(post.Title);
                        foreach (dynamic comment in post.Comments)
                        {
                            Console.WriteLine(comment.Body);
                        }
                    }
                    var tags = session.Query<TagsIndex.ReduceResult, TagsIndex>();
                    Console.WriteLine(tags.First().Tag);
                    RavenQueryStatistics stats;
                    var posts = session.Query<Post>().Customize(x=>x.WaitForNonStaleResults()).Statistics(out stats).ToList();
                    Console.WriteLine(stats.IsStale); //falso
                    Console.WriteLine(posts.Count);

                }
            }
        }
    }

    public class TagsIndex : AbstractIndexCreationTask<Post, TagsIndex.ReduceResult>
    {
        public class ReduceResult
        {
            public string Tag { get; set; }
            public int Count { get; set; }
        }
        public TagsIndex()
        {
            Map = posts => from post in posts
                           from tag in post.Tags
                           select new
                                      {
                                          Tag = tag,
                                          Count = 1
                                      };
            Reduce = results => from r in results
                                group r by r.Tag
                                into g
                                select new
                                           {
                                               Tag = g.Key,
                                               Count = g.Sum(x => x.Count)
                                           };
        }
    }
}
