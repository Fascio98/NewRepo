using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace OrganizationsCatalog.Controllers
{
    public class ManageController : Controller
    {

        private readonly IManageOperation _operation;

        public ManageController(IManageOperation operation)
        {
            _operation = operation;
        }


        public IActionResult Person()
        {
            var dataList = _operation.GetAllPeople();
            return View(dataList);
        }

        public IActionResult Organization()
        {
            return View();
        }
    }
}