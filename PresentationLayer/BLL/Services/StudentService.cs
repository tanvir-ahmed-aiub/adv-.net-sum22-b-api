using BLL.BOs;
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
            var data= StudentRepo.Get();
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
            return StudentRepo.Get().Take(count).ToList();
        }
        public static Student GetStudent(int id) {
            return StudentRepo.Get(id);
        }
        public static bool Create(StudentModel item) {
            var student =new Student()
            {
                Id = item.Id,
                Name = item.Name,
                Cgpa = item.Cgpa,
                Dob = item.Dob
            };
            return StudentRepo.Create(student); 
        }
        public static bool Update(Student student) { 
            return StudentRepo.Update(student);
        }
    }
}
