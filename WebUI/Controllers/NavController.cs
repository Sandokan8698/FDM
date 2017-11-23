using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Data.Abstract;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public NavController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PartialViewResult Menu(string sport = null)
        {
            IEnumerable<string> sports;

            using (_unitOfWork)
            {
                sports = _unitOfWork.SportRepository.GetAll().Select(s => s.Name);
            }
            
            return PartialView(new NavViewModel{Sports = sports, SelectedSport = sport});
        }
    }
}