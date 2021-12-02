using System;
using System.Collections.Generic;
using System.Text;
using CalisanBilgi.Data.Contracts;
using CalisanBilgi.Data.DataContext;

namespace CalisanBilgi.Data.Implemention
{
  public  class UnitOfwork:IUnitOfwork
    {
        private readonly CalisanBilgiContext _ctx;

        public UnitOfwork( CalisanBilgiContext ctx)
        {
            _ctx = ctx;
            employeLeaveAllocotion = new EmployeLeaveAllocationRepository(_ctx);
            employeLeaveRequest = new EmployeLeaveRequestRepository(_ctx);
            employeLeaveType = new EmployeLeaveTypeRepository(_ctx);
        }

        public IEmployeLeaveAllocationRepository employeLeaveAllocotion { get; private set; }
        public IEmployeLeaveRequestRepository employeLeaveRequest { get; private set; }
        public IEmployeLeaveTypeRepository employeLeaveType { get; private set; }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        
    }
}
