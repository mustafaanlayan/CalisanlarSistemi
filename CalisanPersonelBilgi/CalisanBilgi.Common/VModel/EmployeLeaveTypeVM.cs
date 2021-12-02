using System;
using System.ComponentModel.DataAnnotations;

namespace CalisanBilgi.Common.VModel
{
   public class EmployeLeaveTypeVM:BaseVM
    {
        [Required]
        public string Name { get; protected set; }
        public string DefaultDays { get;protected set; }
        public DateTime DateCreated { get;protected set; }


        public void SetEmployeType()
        {

        }
    }
}
