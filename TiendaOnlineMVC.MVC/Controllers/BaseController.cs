using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaOnlineMVC.MVC.Utils;

namespace TiendaOnlineMVC.MVC.Controllers
{
    public class BaseController : Controller
    {
        public Connect Connect { get; private set; }
        public BaseController()
        {
            Connect = new Connect();
        }
    }
}