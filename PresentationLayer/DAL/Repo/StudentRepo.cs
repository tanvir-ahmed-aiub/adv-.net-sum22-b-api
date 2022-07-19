using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo
    {
        static student_dbEntities db = new student_dbEntities();
        public static List<Student> Get() {
            return db.Students.ToList();
        }
        public static Student Get(int id) { 
            return db.Students.SingleOrDefault(s => s.Id == id);
        }
        public static bool Create(Student student) {
            db.Students.Add(student);
            var res = db.SaveChanges();
            if (res != 0) { 
                return true;
            }
            return false;           
        }
        public static bool Update(Student student) {
            var exst = db.Students.FirstOrDefault(x => x.Id == student.Id);
            if (exst != null) {
                db.Entry(exst).CurrentValues.SetValues(student);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id) { 
            db.Students.Remove(Get(id));
            db.SaveChanges();
            return true;
        }
    }
}
