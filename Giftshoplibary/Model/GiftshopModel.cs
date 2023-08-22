using System;
using System.ComponentModel.DataAnnotations;

namespace Giftshoplibary
{
    public class GiftshopModel
    {
        public int ID { get; set; }
       [Required]
        public string Name { get; set; }
       [Required]
        public string Email { get; set; }
        [Required]
        public long Phonenumber { get; set; }
        [Required]
        public string Message { get; set; }


    }
}
