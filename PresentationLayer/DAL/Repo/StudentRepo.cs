using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo:IRepo<Student,int>
    {
         student_dbEntities db = new student_dbEntities();
        public StudentRepo(student_dbEntities db)
        {
            this.db = db;   
        }
        public  List<Student> Get()
        {
            return db.Students.ToList();
        }
        public  Student Get(int id)
        {
            return db.Students.SingleOrDefault(s => s.Id == id);
        }
        public  bool Create(Student student)
        {
            db.Students.Add(student);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }
        public  bool Update(Student student)
        {
            var exst = db.Students.FirstOrDefault(x => x.Id == student.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(student);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            db.Students.Remove(Get(id));
            db.SaveChanges();
            return true;
        }
    }
}
