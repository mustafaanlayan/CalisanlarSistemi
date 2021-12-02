using System;
using System.Collections.Generic;
using System.Text;
using CalisanBilgi.Data.Contracts;
using CalisanBilgi.Data.DataContext;
using CalisanBilgi.Data.DbModel;

namespace CalisanBilgi.Data.Implemention
{
   public class EmployeLeaveTypeRepository:Repository<EmployeLeaveType>, IEmployeLeaveTypeRepository
   {
       private readonly CalisanBilgiContext _ctx;
        public EmployeLeaveTypeRepository(CalisanBilgiContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
