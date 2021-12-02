using System;
using System.Collections.Generic;
using System.Text;
using CalisanBilgi.Data.Contracts;
using CalisanBilgi.Data.DataContext;
using CalisanBilgi.Data.DbModel;

namespace CalisanBilgi.Data.Implemention
{ 
   public class EmployeLeaveAllocationRepository:Repository<EmployeLeaveAlloction>,IEmployeLeaveAllocationRepository
   {
       private readonly CalisanBilgiContext _ctx;
        public EmployeLeaveAllocationRepository(CalisanBilgiContext ctx) : base(ctx)
        {
            _ctx = ctx;

        }
    }
}
