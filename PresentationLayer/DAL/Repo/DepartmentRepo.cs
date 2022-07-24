using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DepartmentRepo
    {
        static student_dbEntities db = new student_dbEntities();
        public static List<Department> Get()
        {
            return db.Departments.ToList();
        }
        public static Department Get(int id)
        {
            var department = db.Departments.Find(id);
            return department;
        }


    }
}
