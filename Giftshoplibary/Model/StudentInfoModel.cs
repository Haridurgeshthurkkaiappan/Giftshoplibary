using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftshoplibary.Model
{
    public class StudentInfoModel
    {
       public  int studentid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long Mobilenumber { get; set;}
       
    }

}
