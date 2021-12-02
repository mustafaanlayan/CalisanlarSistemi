using System;

namespace CalisanBilgi.Data.DbModel
{
  public class EmployeLeaveType: BaseEntity
    {
       public string Name { get; set; }
       public string DefaultsDay { get; set; }
       public  DateTime DateCreated { get; set; }
    }
}
