using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = StudentService.Get();
            foreach(var d in data)
            {
                Console.WriteLine("{0} -- {1} -- {2}", d.Id, d.Name, d.Cgpa);
            }
        }
    }
}
