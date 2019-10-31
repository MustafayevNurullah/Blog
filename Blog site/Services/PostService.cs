using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_site.Models;

namespace Blog_site.Services
{
    public class PostService : IPostService
    {
        private readonly List<Post> posts;
        public PostService()
        {
            posts = new List<Post>
            {
                new Post{Title="Yaxci Oglanlar",Text="YAxci oglanlara salam.A.Y.E "},
                new Post{Title="Ramana usaqlari",Text="Ramana uwaqlari keledi asdfghj"}
            };
        }


        public Post AddPost(string Title, string Text)
        {
            throw new NotImplementedException();
        }

        public List<Post> AllPost()
        {
            return posts;
        }

        public Post GetPost(int Id)
        {
            Post post_ = posts.FirstOrDefault(x => x.Id == Id);

            return post_;

        }
    }
}
