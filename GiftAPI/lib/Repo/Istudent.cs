using GiftAPI;
using GiftAPI.lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftshoplibary.Business
{
   public interface Istudent
    {
        public List<Student> GetStudentList();
/*        public List<StudentInfoModel> SP_GetEmployeesList();
*/

        public Student GetStudentDetailsById(int stdId);

        public void Save(Student data);

        public void Update(Student data);
        public void Delete(int stdId);
    }


    public class StudentRegister : Istudent
    {
        private Contex _context;

        public StudentRegister(Contex context)
        {
            _context = context;
        }

        public List<Student> GetStudentList()
        {

            try
            {
                var empList = _context.Set<Student>().ToList();
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


        public Student GetStudentDetailsById(int stdId)
        {

            try
            {
                var emp = _context.Find<Student>(stdId);
                return emp;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Save(Student data)
        {
            try
            {
                var emp = _context.Add<Student>(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Student data)
        {
            try
            {
                _context.Update<Student>(data);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int stdId)
        {
            try
            {
                var tobeDeleted = GetStudentDetailsById(stdId);
                _context.Remove<Student>(tobeDeleted);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
