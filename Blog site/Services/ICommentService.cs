using Blog_site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_site.Services
{
   public interface ICommentService
    {
       List< Comment> GetComment(int Id);

        Comment AddComment(string Text,int PostId);
    }
}
