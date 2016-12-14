using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTestProj.Models
{
    /// <summary>
    /// 員工
    /// </summary>
    class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
