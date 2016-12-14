using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTestProj.Models
{
    /// <summary>
    /// 部門
    /// </summary>
    class Department
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
