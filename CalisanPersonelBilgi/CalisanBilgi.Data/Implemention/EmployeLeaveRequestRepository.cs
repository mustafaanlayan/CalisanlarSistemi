using System;
using System.Collections.Generic;
using System.Text;
using CalisanBilgi.Data.Contracts;
using CalisanBilgi.Data.DataContext;
using CalisanBilgi.Data.DbModel;

namespace CalisanBilgi.Data.Implemention
{
   public class EmployeLeaveRequestRepository:Repository<EmployeLeaveRequest>,IEmployeLeaveRequestRepository
    {
        private readonly CalisanBilgiContext _ctx;
        public EmployeLeaveRequestRepository(CalisanBilgiContext ctx) : base(ctx)
        {
        }
    }
}
