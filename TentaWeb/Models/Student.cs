using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TentaWeb.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string GitHubHomeURl { get; set; }
        public string GoogleAccount { get; set; }
    }
}
