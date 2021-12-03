using CalisanBilgi.Data.Contracts;
using CalisanBiligi.BusinesEngine.Contracts;

namespace CalisanBiligi.BusinesEngine.Implemention
{
   public class EmployeLeaveTypeBusinesEngine: IEmployeLeaveTypeBusinesEngine
   {
       private readonly IUnitOfwork _unitOfwork;

       public EmployeLeaveTypeBusinesEngine(IUnitOfwork unitOfwork)
       {
           _unitOfwork = unitOfwork;
           
       }
   }
}
