using BLL.BOs;
using DAL;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentModel> Get() {
            var data = DataAccessFactory.GetStudentDataAccess().Get();
            var rdata = new List<StudentModel>();
            foreach (var item in data)
            {
                rdata.Add(new StudentModel() { 
                    Id = item.Id, Name = item.Name, 
                    Cgpa = item.Cgpa, Dob = item.Dob 
                });
            }
            return rdata;
        }
        public static List<Student> GetVarStudentCount(int count) {
            return DataAccessFactory.GetStudentDataAccess().Get().Take(count).ToList();
        }
        public static Student GetStudent(int id) {
            return DataAccessFactory.GetStudentDataAccess().Get(id);
        }
        public static bool Create(StudentModel item) {
            var student =new Student()
            {
                Id = item.Id,
                Name = item.Name,
                Cgpa = item.Cgpa,
                Dob = item.Dob
            };
            return DataAccessFactory.GetStudentDataAccess().Create(student); 
        }
        public static bool Update(Student student) { 
            return DataAccessFactory.GetStudentDataAccess().Update(student);
        }
    }
}
