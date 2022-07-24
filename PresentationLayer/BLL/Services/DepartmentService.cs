using BLL.BOs;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService
    {
        public static List<DepartmentModel>Get() {
            var data = DepartmentRepo.Get();
            var depts = new List<DepartmentModel>();    
            foreach(var item in data)
            {
                depts.Add(new DepartmentModel() { Id = item.Id, Name = item.Name });
            }
            return depts;
        }
        public static DepartmentModel GetOnly(int id)
        {
            var item = DepartmentRepo.Get(id);
            var d = new DepartmentModel() { Id = item.Id, Name = item.Name };
            return d;

        }
        public static DepartmentStudentModel Get(int id) {
            var dept = DepartmentRepo.Get(id);
            var d = new DepartmentStudentModel();
            d.Id = dept.Id;
            d.Name = dept.Name;
            foreach(var s in dept.Students)
            {
                d.Students.Add(new StudentModel() { Id = s.Id, Name = s.Name,Cgpa=s.Cgpa,Dob=s.Dob });    
            }
            return d;

        }
        
    }
}
