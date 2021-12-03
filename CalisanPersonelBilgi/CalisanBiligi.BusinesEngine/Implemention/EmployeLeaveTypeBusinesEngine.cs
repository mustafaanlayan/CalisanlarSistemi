using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CalisanBilgi.Common.ConstansModel;
using CalisanBilgi.Common.ResultModels;
using CalisanBilgi.Common.VModel;
using CalisanBilgi.Data.Contracts;
using CalisanBilgi.Data.DbModel;
using CalisanBiligi.BusinesEngine.Contracts;

namespace CalisanBiligi.BusinesEngine.Implemention
{
   public class EmployeLeaveTypeBusinesEngine: IEmployeLeaveTypeBusinesEngine
   {
        #region Varibles
            private readonly IUnitOfwork _unitOfwork;
            private readonly IMapper _mapper;
        #endregion

        #region Consracter
        public EmployeLeaveTypeBusinesEngine(IUnitOfwork unitOfwork,IMapper mapper)
        {
            _unitOfwork = unitOfwork;
            _mapper = mapper;

        }
        #endregion

        #region CustomMetods
        public Result<List<EmployeLeaveType>> GetAllEmployeLeaveType()
        {
            var data = _unitOfwork.employeLeaveType.GetAll().ToList();

            if (data !=null)
                {
                  List<EmployeLeaveType> returnData = new List<EmployeLeaveType>();
                foreach (var item in data)
                {
                    returnData.Add(new EmployeLeaveType()
                  {
                        Id = item.Id,
                      DateCreated = item.DateCreated,
                      DefaultDays = item.DefaultDays,
                       Name = item.Name

                   });
              }

             return new Result<List<EmployeLeaveType>>(true, ResultConstant.RecordFound, returnData);
            }
            else
           {
               return new Result<List<EmployeLeaveType>>(false, ResultConstant.RecordNotFound);
             }
            //var leaveType = _mapper.Map<List<EmployeLeaveType>, List<EmployeLeaveTypeVM>>(data);

            //return new Result<List<EmployeLeaveTypeVM>>(true, ResultConstant.RecordFound, leaveType);
        } 
        #endregion
    }
}
