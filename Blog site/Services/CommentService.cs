using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_site.Models;

namespace Blog_site.Services
{
    public class CommentService : ICommentService
    {

       private readonly Post posts;
        public Comment AddComment(string Text, int PostId)
        {
            throw new NotImplementedException();
        }


        List<Comment> ICommentService.GetComment(int Id)
        {



          return   posts.Comments.FindAll(x => x.PostId == Id);

            
        }
    }
}
