using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace W.A.F.E.M.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "This field is required, You cannot continue without filling this field.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [StringLength(50)]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }
        [StringLength(50)]
        [DisplayName("Position")]
        public string Position{ get; set; }
        [StringLength(50)]
        [DisplayName("Task / Current Task")]
        public string OfficeLocation { get; set; }


    }
}
