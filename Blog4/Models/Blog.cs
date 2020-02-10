using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog4.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Post Type")]
        public Category Post_Type { get; set; }

        [Required]
        public ICollection<Post> Post { get; set; }
    }
}
