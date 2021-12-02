using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CalisanBilgi.Data.DbModel
{
  public  class EmployeLeaveRequest:BaseEntity
    {
        //---------------------------------------------------------//
        //TUDO:Talepte Bulunan Kullanıcı
        public string RequestingEmployeId { get; set; }
        [ForeignKey("RequestingEmployeId")]
        public Employe RequestingEmploye { get; set; }

        //TUDO:Onayda Bulunan Kullanıcı
        public string ApprovedEmployeId { get; set; }
        [ForeignKey("ApprovedEmployeId")]
        public Employe ApprovedEmploye { get; set; }


        public int EmployeLeaveTypeId { get; set; }
        [ForeignKey("EmployeLeaveTypeId")]
        public EmployeLeaveType EmployeLeaveType { get; set; }

        //---------------------------------------------------------//

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComment { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
