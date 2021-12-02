using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CalisanBilgi.Data.DbModel
{
   public class EmployeLeaveAlloction:BaseEntity
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }

        public string EmployeId { get; set; }
        [ForeignKey("EmployeId")]
        public Employe Employe { get; set; }

        public int EmployeLeaveTypeId { get; set; }
        [ForeignKey("EmployeLeaveTypeId")]
        public EmployeLeaveType EmployeLeaveType { get; set; }

    }
}
