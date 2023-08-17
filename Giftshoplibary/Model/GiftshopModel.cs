using System;
using System.ComponentModel.DataAnnotations;

namespace Giftshoplibary
{
    public class GiftshopModel
    { 
        int ID { get; set; }
       [Required]
        string Name { get; set; }
       [Required]
       string Email { get; set; }
        [Required]
       long Phonenumber { get; set; }
        [Required]
       string Message { get; set; }


    }
}
