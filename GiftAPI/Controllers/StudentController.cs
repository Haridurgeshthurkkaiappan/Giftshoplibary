using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Giftshoplibary.Business;


namespace GiftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public Istudent obj;
        public Icourse obj2;

        public StudentController(Istudent objstd,Icourse objcourse)
        {
            obj = objstd;
            obj2 = objcourse;
        }
        [HttpGet]
        public IEnumerable<Istudent> Get()
        {
            return (IEnumerable<Istudent>)obj.GetStudentList();
        }

        [HttpGet("{id}")]
        public Istudent Get(int id)
        {
            return (Istudent)obj.GetStudentDetailsById(id);
        }

        [HttpPost]
        public void Post([FromBody] Istudent value)
        {
            obj2.GetcourseList();
            obj.Save((lib.Model.Student)value);
        }

        [HttpPut("{id}")]
        public void Put( [FromBody] Istudent value)
        {
            obj2.GetcourseList();
            obj.Update((lib.Model.Student)value);

        }

        [HttpDelete("{id}")]
        public void Delete(int id)

        {
            obj.Delete(id);
        }
    }
}
