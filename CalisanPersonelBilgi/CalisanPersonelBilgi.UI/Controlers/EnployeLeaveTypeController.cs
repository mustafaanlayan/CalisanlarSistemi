using CalisanBiligi.BusinesEngine.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalisanPersonelBilgi.UI.Controlers
{
    public class EnployeLeaveTypeController : Controller
    {
        private readonly IEmployeLeaveTypeBusinesEngine _employeLeaveTypeBusinesEngine;

        public EnployeLeaveTypeController(IEmployeLeaveTypeBusinesEngine employeLeaveTypeBusinesEngine)
        {
            _employeLeaveTypeBusinesEngine = employeLeaveTypeBusinesEngine;
        }

        public IActionResult Index()
        {
            var data = _employeLeaveTypeBusinesEngine.GetAllEmployeLeaveType();
            if (data.IsSucces)
            {
                var result = data.Data;
                return View(result);
            }
            return View();
        }
    }
}
