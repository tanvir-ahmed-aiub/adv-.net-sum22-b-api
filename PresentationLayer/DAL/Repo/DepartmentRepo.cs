using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DepartmentRepo :IRepo<Department,int>
    {
        student_dbEntities db;
        public DepartmentRepo(student_dbEntities db)
        {
            this.db = db;
        }

        public bool Create(Department obj)
        {
            db.Departments.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            db.Departments.Remove(obj);
            return db.SaveChanges() > 0;
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
