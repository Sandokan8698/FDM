using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Abstract;
using Domain.Entities;
using WebIU.ViewModels;

namespace WebIU.Controllers
{
    public class CoachController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public CoachController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Coach
        public ActionResult Index()
        {
            IEnumerable<Coach> coaches;

            using (_unitOfWork)
            {
                coaches = _unitOfWork.CoachRepostitory.GetAll();
            }

            return View(coaches);
        }

        // GET: Coach/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Coach/Create
        public ActionResult Create()
        {
            var viewModel = GetViewModel();
            return View(viewModel);
        }

        // POST: Coach/Create
        [HttpPost]
        public ActionResult Create(Coach coach)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = GetViewModel();
                viewModel.Coach = coach;

                return View(viewModel);
            }

            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CoachRepostitory.Add(coach);
                    _unitOfWork.Complete();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Coach/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = GetViewModel();

            if (viewModel.Coach == null)
                return HttpNotFound();

            return View(viewModel);
        }

        // POST: Coach/Edit/5
        [HttpPost]
        public ActionResult Edit(Coach coach)
        {
            try
            {
                using (_unitOfWork)
                {
                    _unitOfWork.CoachRepostitory.Update(coach);
                    _unitOfWork.Complete();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Coach/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coach/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private CoachEditCreateViewModel GetViewModel()
        {
            CoachEditCreateViewModel newCoachEditCreateViewModel = new CoachEditCreateViewModel();

            using (_unitOfWork)
            {
                newCoachEditCreateViewModel.Sports = _unitOfWork.SportRepository.GetAll();
                newCoachEditCreateViewModel.HomeTowns = new List<string>() { "Las Nave", "Caluma" };
            }

            return newCoachEditCreateViewModel;
        }
    }
}
