using System;

namespace CalisanBilgi.Common.VModel
{
   public class EmployeLeaveAllocotionVM:BaseVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }

        public string EmployeId { get; set; }
        
        public EmloyeVM EmployeVm { get; set; }

        public int EmployeLeaveTypeId { get; set; }
        
        public EmployeLeaveTypeVM EmployeLeaveTypeVm { get; set; }
    }
}
