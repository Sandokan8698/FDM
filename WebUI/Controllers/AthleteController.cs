using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Abstract;

namespace WebUI.Controllers
{
    public class AthleteController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public AthleteController(IUnitOfWork pUnitOfWork)
        {
            _unitOfWork = pUnitOfWork;
        }

        
    }
}