using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftshoplibary.Model
{
   public  class CourseModel
    {
        public int courseid { get; set; }
        [Required]
        public string course { get; set; }
    }
}
