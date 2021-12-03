using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanBilgi.Data.Contracts
{
   public interface IUnitOfwork:IDisposable
   {
        IEmployeLeaveAllocationRepository employeLeaveAllocotion { get;  }
        IEmployeLeaveRequestRepository employeLeaveRequest { get;  }
        IEmployeLeaveTypeRepository employeLeaveType { get;  }
        void Save();
   }
}
