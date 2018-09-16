using BLL.Models;
using PL.CoffeeServiceReference;
using PL.CountryServiceReference;
using PL.Helpers;
using PL.Mappers;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class CoffeeController : Controller
    {
        private ICoffeeService coffeeService;
        private ICountryService countryService;

        public CoffeeController()
        {
            coffeeService = new CoffeeServiceClient();
            countryService = new CountryServiceClient();
        }

        public ActionResult Index()
        {
            List<CoffeeView> allCoffee = coffeeService.GetAll().Select(CoffeeMapper.Map).ToList();
            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();

            return View(allCoffee);
        }

        public ActionResult Details(Guid id)
        {
            CoffeeView coffee = coffeeService.GetById(id).Map();

            return View(coffee);
        }

        public ActionResult Edit(Guid id)
        {
            CoffeeView coffee = coffeeService.GetById(id).Map();
            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View(coffee);
        }

        public ActionResult Edited(CoffeeView coffee)
        {
            if (ModelState.IsValid)
            {
                coffeeService.Update(coffee.Map());

                return RedirectToAction("Details", "Coffee", new { id = coffee.Id });
            }

            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Edit", coffee);
        }

        public ActionResult Delete(Guid id)
        {
            CoffeeView coffee = coffeeService.GetById(id).Map();

            return View(coffee);
        }

        public ActionResult Deleted(CoffeeView coffee)
        {
            coffeeService.Delete(coffee.Map());

            return RedirectToAction("Index", "Coffee");
        }

        public ActionResult Create()
        {
            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View();
        }

        public ActionResult Created(CoffeeView coffee)
        {
            coffee.Id = Guid.NewGuid();

            if (ModelState.IsValid)
            {
                coffeeService.Create(coffee.Map());

                return RedirectToAction("Index", "Coffee");
            }

            ViewBag.Countries = SelectListHelper.GetCountries(countryService);
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Create");
        }

        public ActionResult Filter(CoffeeSortBll sort, Guid countryId)
        {
            List<CoffeeView> coffee = coffeeService.Filter(sort, countryId).Select(CoffeeMapper.Map).ToList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Coffee", coffee);
            }

            return View("_Coffee", coffee);
        }
    }
}