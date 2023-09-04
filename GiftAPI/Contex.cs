using GiftAPI.lib.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftAPI
{
    
    
        public class Contex : DbContext
        {
            public Contex(DbContextOptions options) : base(options)
            {

            }

            public DbSet<Student> StudentRegistration
            {
                get;
                set;
            }

        }
    
}
