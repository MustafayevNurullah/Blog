using Blog_site.Services;
using Blog_site.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_site.Controllers
{
    public class CommentController:Controller
    {

        private readonly ICommentService commentService;


        public CommentController(ICommentService _commentService)
        {
            commentService = _commentService;

        }

        [HttpGet]

        public IActionResult GetComment(int Id)
        {
            var comments = commentService.GetComment(Id);


            var vm = comments.Select(x => new CommentViewModel
            {
                Text = x.Text
            }).ToList();


            return View(vm);

        }


    }
}
