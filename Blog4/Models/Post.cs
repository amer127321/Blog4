using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog4.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int PostId { get; set; }
        public Blog Blog { get; set; }
    }
}
