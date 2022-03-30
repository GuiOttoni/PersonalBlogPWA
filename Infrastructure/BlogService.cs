using PersonalBlogPWA.Infrastructure.Interface;
using PersonalBlogPWA.Models;

namespace PersonalBlogPWA.Infrastructure
{
    public class BlogService : IBlogService
    {
        public BlogService()
        {
        }

        private List<BlogPost> Posts
        {
            get
            {
                return new List<BlogPost>() {
                new BlogPost { PostId = 1, Title = "xxx-1", ShortDescription = "xxx-1" },
                new BlogPost { PostId = 2, Title = "xxx-2", ShortDescription = "xxx-2" },
                new BlogPost { PostId = 3, Title = "xxx-3", ShortDescription = "xxx-3" },
                new BlogPost { PostId = 4, Title = "xxx-4", ShortDescription = "xxx-4" },
                new BlogPost { PostId = 5, Title = "xxx-6", ShortDescription = "xxx-6" }
            };
            }
        }

        public string GetPostText(string link)
        {
            var post = Posts.FirstOrDefault(_ => _.Link == link);
            return "";
        }

        public List<BlogPost> GetLatestPosts()
        {
            return Posts.OrderByDescending(_ => _.PostId).Take(3).ToList();
        }

    }
}
