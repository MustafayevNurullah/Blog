using Blog_site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_site.Services
{
   public interface IPostService
    {
        Post GetPost(int Id);

        Post AddPost(string Title, string Text);

        List<Post> AllPost();
        

    }
}
