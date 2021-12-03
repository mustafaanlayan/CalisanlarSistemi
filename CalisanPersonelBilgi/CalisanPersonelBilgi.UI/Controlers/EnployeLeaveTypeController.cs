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
            return View();
        }
    }
}
