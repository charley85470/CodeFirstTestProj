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
				// 輸入部門名稱
                Console.Write("Insert Department Name:");
                var depName = Console.ReadLine();

				// 建立部門物件
                var dep = new Department { DepartmentId = Guid.NewGuid(), DepartmentName = depName };
				// 將部門物件輸入至資料庫
                db.Departments.Add(dep);
                db.SaveChanges();

				// 執行Linq查詢(T-SQL:SELECT * FROM Departments)
                var qry = from d in db.Departments
                          select d;

				// Print Department
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
