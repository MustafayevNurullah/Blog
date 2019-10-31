using Blog_site.Models;
using Blog_site.Services;
using Blog_site.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_site.Controllers
{
    public class PostController:Controller
    {

        private  IPostService postService;

        public PostController(IPostService _postService)
        {
            postService = _postService;

        }

        [HttpGet]

        public IActionResult All()
        {
            var posts = postService.AllPost();


            var vm = posts.Select(x => new PostViewModel
            {
                Title=x.Title,
                Text=x.Text
              
                
            }).ToList();
            return View(vm);
        }

        [HttpGet]

        public IActionResult GetPost(int Id)
        {
            var post = postService.GetPost(Id);

            var vm = new PostViewModel() { Text = post.Title, Title = post.Title };
            return View(vm);
        }



    }
}
