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
        [Required]
        public string course { get; set; }
        public int courseid { get; set; }
       
    }
}
