using CalisanBilgi.Common.ResultModels;
using System;
using System.Collections.Generic;
using System.Text;
using CalisanBilgi.Data.DbModel;

namespace CalisanBiligi.BusinesEngine.Contracts
{
  public  interface IEmployeLeaveTypeBusinesEngine
  {
      Result<List<EmployeLeaveType>> GetAllEmployeLeaveType();
  }
}
