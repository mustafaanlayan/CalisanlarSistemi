using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CalisanBilgi.Common.VModel;
using CalisanBilgi.Data.DbModel;

namespace CalisanBilgi.Common.Mapping
{
   public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<EmployeLeaveType, EmployeLeaveTypeVM>().ReverseMap();
            CreateMap<EmployeLeaveAlloction, EmployeLeaveAllocotionVM>().ReverseMap();
            CreateMap<EmployeLeaveRequest, EmployeLeaveRequestVM>().ReverseMap();
            CreateMap<Employe, EmloyeVM>().ReverseMap();
        }
    }
}
