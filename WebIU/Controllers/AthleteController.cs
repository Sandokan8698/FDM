using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Data.Abstract;
using Domain.Entities;
using WebIU.ViewModels;

namespace WebIU.Controllers
{
    
    public class AthleteController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public int PageSize = 50;

        public AthleteController(IUnitOfWork pUnitOfWork)
        {
            _unitOfWork = pUnitOfWork;
        }

        public ViewResult List(string sport)
        {
            IEnumerable<Athlete> athletes;
            
            using (_unitOfWork)
            {
                athletes = _unitOfWork.AthleteRepository.GetAll()
                    .Where(a => a.Sport.Name == sport);
            }

            var athleteViewModel = new AthleteListViewModel
            {
                Athletes = athletes,
                CurrentSport = sport
            };
            
            return View(athleteViewModel);
        }

        [HttpPost]
        public ActionResult Create(Athlete athlete)
        {
            return View();
        }

        public ActionResult New()
        {
            IEnumerable<Sport> sports;
            using (_unitOfWork)
            {
                sports = _unitOfWork.SportRepository.GetAll();
            }
            AthleteNewViewModel viewModel = new AthleteNewViewModel
            {
                Sports = sports
            };
            return View(viewModel);
        }
    }
}