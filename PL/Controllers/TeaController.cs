using BLL.Models;
using PL.CountryServiceReference;
using PL.Mappers;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PL.TeaServiceReference;
using PL.Helpers;

namespace PL.Controllers
{
    public class TeaController : Controller
    {
        private ITeaService teaService;
        private ICountryService countryService;

        public TeaController()
        {
            teaService = new TeaServiceClient();
            countryService = new CountryServiceClient();
        }

        public ActionResult Index()
        {
            List<TeaView> allTea = teaService.GetAll().Select(TeaMapper.Map).ToList();
            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();

            return View(allTea);
        }

        public ActionResult Details(Guid id)
        {
            TeaView Tea = teaService.GetById(id).Map();

            return View(Tea);
        }

        public ActionResult Edit(Guid id)
        {
            TeaView Tea = teaService.GetById(id).Map();
            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View(Tea);
        }

        public ActionResult Edited(TeaView Tea)
        {
            if (ModelState.IsValid)
            {
                teaService.Update(Tea.Map());

                return RedirectToAction("Details", "Tea", new { id = Tea.Id });
            }

            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Edit", Tea);
        }

        public ActionResult Delete(Guid id)
        {
            TeaView Tea = teaService.GetById(id).Map();

            return View(Tea);
        }

        public ActionResult Deleted(TeaView Tea)
        {
            teaService.Delete(Tea.Map());

            return RedirectToAction("Index", "Tea");
        }

        public ActionResult Create()
        {
            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View();
        }

        public ActionResult Created(TeaView Tea)
        {
            Tea.Id = Guid.NewGuid();

            if (ModelState.IsValid)
            {
                teaService.Create(Tea.Map());

                return RedirectToAction("Index", "Tea");
            }

            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Create");
        }
    }
}