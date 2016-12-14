using CodeFirstTestProj.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CompanyContext())
            {
                Console.Write("Insert Department Name:");
                var depName = Console.ReadLine();

                var dep = new Department { DepartmentId = Guid.NewGuid(), DepartmentName = depName };
                db.Departments.Add(dep);
                db.SaveChanges();

                var qry = from d in db.Departments
                          select d;

                foreach (var item in qry)
                {
                    Console.WriteLine($@"ID = {item.DepartmentId} , Name = {item.DepartmentName}");
                }

                Console.WriteLine("Press any key to quite.");
                Console.ReadKey();
            }
        }
    }
}
