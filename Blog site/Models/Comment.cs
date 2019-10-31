using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_site.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }

    }
}
