using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanBilgi.Common.VModel
{
   public class EmployeLeaveRequestVM:BaseVM
    {
        public string RequestingEmployeId { get; set; }
       
        public EmloyeVM RequestingEmploye { get; set; }

        //TUDO:Onayda Bulunan Kullanıcı
        public string ApprovedEmployeId { get; set; }
        
        public EmloyeVM ApprovedEmploye { get; set; }


        public int EmployeLeaveTypeId { get; set; }
        
        public EmployeLeaveTypeVM EmployeLeaveType { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }

        [Display(Name = "Talep Açıklama")]
        [MaxLength(300,ErrorMessage = "300 Karekterden Fazla Değer Girilemez")]
        public string RequestComment { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
