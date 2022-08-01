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
        public static IRepo<Department,int,bool> GetDepartmentDataAccess() {
            return new DepartmentRepo(db);
        }
        public static IRepo<Cours, int,bool> GetCoursDataAccess() {
            return new CourseRepo(db);
        }
        public static IRepo<Student, int,bool> GetStudentDataAccess() {
            return new StudentRepoV2(db);
        }
        public static IRepo<User, string, bool> GetUserDataAccess() { 
            return new UserRepo(db);
        }
        public static IAuth<User> GetAuthDataAccess() {
            return new UserRepo(db);
        }
        public static IRepo<Token, string, Token> GetTokenDataAccess() { 
            return new TokenRepo(db);
        }
        

    }
}
