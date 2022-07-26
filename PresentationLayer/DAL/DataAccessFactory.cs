using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static student_dbEntities db = new student_dbEntities();
        public static IRepo<Department,int> GetDepartmentDataAccess() {
            return new DepartmentRepo(db);
        }
        public static IRepo<Cours, int> GetCoursDataAccess() {
            return new CourseRepo(db);
        }
        public static IRepo<Student, int> GetStudentDataAccess() {
            return new StudentRepoV2(db);
        }

    }
}
