using GiftAPI;
using GiftAPI.lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftshoplibary.Business
{
    public interface Icourse
    {
        public List<Course> GetcourseList();
/*        public List<CourseModel> SP_GetEmployeesList();
*/

        public Course GetcourseDetailsById(int courseId);

        public void Save(Course data);

        public void Update(Course data);
        public void Delete(int courseId);
    }

    public class CourseRegister : Icourse
    {
        private Contex _context;

        public CourseRegister(Contex context)
        {
            _context = context;
        }

        public List<Course> GetcourseList()
        {

            try
            {
                var empList = _context.Set<Course>().ToList();
                return empList;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /*  public List<StudentInfoModel> SP_GetEmployeesList()
          {
              try
              {
                  var empList = _context.EmployeRegistration.FromSqlRaw<StudentInfoModel>("Select * from EmployeRegistration").ToList();

                  return empList;
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }*/


        public Course GetcourseDetailsById(int courseId)
        {

            try
            {
                var emp = _context.Find<Course>(courseId);
                return emp;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Save(Course data)
        {
            try
            {
                var emp = _context.Add<Course>(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Course data)
        {
            try
            {
                _context.Update<Course>(data);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int courseId)
        {
            try
            {
                var tobeDeleted = GetcourseDetailsById(courseId);
                _context.Remove<Course>(tobeDeleted);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

