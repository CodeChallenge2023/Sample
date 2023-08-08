using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class Employee
    {
        public string FiveDigitEmpNo { get; set; } = string.Empty;
        public string EmpNo { get; set; } = string.Empty;
        public string EmpNameEn { get; set; } = string.Empty;
        public string EmpNameHi { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Grade { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string PgEmail { get; set; } = string.Empty;
        public string ExtEmail { get; set; } = string.Empty;
        public string CellNo { get; set; } = string.Empty;
        public string OfficeRaxNo { get; set; } = string.Empty;
        public List<Roles> Roles { get; set; }
        public bool IsRiskApprover { get; set; } = false;
        public bool IsSoApprover { get; set; } = false;
    }
}
