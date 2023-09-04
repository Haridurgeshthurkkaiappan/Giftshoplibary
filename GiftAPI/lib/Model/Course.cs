using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GiftAPI.lib.Model
{
    public class Course
    {

        [Required]
        public string course { get; set; }
        [Key]
        public int courseid { get; set; }

    }
}
