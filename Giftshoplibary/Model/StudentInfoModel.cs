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
        public StudentInfoModel()
        {
            CourcesBE = new List<CourseModel>();
            DOB = new DateTime(1990,01,01);
        }
       public  int studentid { get; set; }
        [Required]
        [MinLength(5),MaxLength(350)]

        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public String College { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(50)]

        public string Email { get; set; }
        [Required]
       [ RegularExpression(@"^[0-9]{10}$")]
        public long Mobilenumber { get; set;}
       
        public List<CourseModel> CourcesBE { get; set; }
    }

}
