using BLL.Models;
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
        public ActionResult Index()
        {
            List<CoffeeView> allCoffee = ParseFromResponseHelper.GetObject<List<CoffeeBll>>("Coffee")
                .Select(CoffeeMapper.Map).ToList();
            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();

            return View(allCoffee);
        }

        public ActionResult Details(Guid id)
        {
            CoffeeView coffee = ParseFromResponseHelper.GetObject<CoffeeBll>("Coffee?id=" + id).Map();

            return View(coffee);
        }

        public ActionResult Edit(Guid id)
        {
            CoffeeView coffee = ParseFromResponseHelper.GetObject<CoffeeBll>("Coffee?id=" + id).Map();
            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View(coffee);
        }

        public ActionResult Edited(CoffeeView coffee)
        {
            if (ModelState.IsValid)
            {
                ParseFromResponseHelper.PutObject<CoffeeBll>("Coffee/Update", coffee.Map());

                return RedirectToAction("Details", "Coffee", new { id = coffee.Id });
            }

            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Edit", coffee);
        }

        public ActionResult Delete(Guid id)
        {
            CoffeeView coffee = ParseFromResponseHelper.GetObject<CoffeeBll>("Coffee?id=" + id).Map();

            return View(coffee);
        }

        public ActionResult Deleted(CoffeeView coffee)
        {
            ParseFromResponseHelper.DeleteObject("Coffee/Delete", coffee.Map());

            return RedirectToAction("Index", "Coffee");
        }

        public ActionResult Create()
        {
            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View();
        }

        public ActionResult Created(CoffeeView coffee)
        {
            coffee.Id = Guid.NewGuid();

            if (ModelState.IsValid)
            {
                ParseFromResponseHelper.PostObject("Coffee/Create", coffee.Map());

                return RedirectToAction("Index", "Coffee");
            }

            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.CoffeeSorts = SelectListHelper.GetEnum<CoffeeSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Create");
        }

        public ActionResult Filter(CoffeeSortBll sort, Guid countryId)
        {
            List<CoffeeView> coffee = ParseFromResponseHelper
                .GetObject<List<CoffeeBll>>("Coffee/Filter?sort=" + sort + "&countryId=" + countryId)
                .Select(CoffeeMapper.Map).ToList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Coffee", coffee);
            }

            return View("_Coffee", coffee);
        }
    }
}