using BLL.Models;
using PL.CoffeeServiceReference;
using PL.CountryServiceReference;
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
            ViewBag.Countries = GetCountriesLikeSelectList();
            ViewBag.CoffeeSorts = GetEnumLikeSelectList<CoffeeSortBll>();
            ViewBag.Qualities = GetEnumLikeSelectList<QualityBll>();

            return View(coffee);
        }

        public ActionResult Edited(CoffeeView coffee)
        {
            if (ModelState.IsValid)
            {
                coffeeService.Update(coffee.Map());

                return RedirectToAction("Details", "Coffee", new { id = coffee.Id });
            }

            ViewBag.Countries = GetCountriesLikeSelectList();
            ViewBag.CoffeeSorts = GetEnumLikeSelectList<CoffeeSortBll>();
            ViewBag.Qualities = GetEnumLikeSelectList<QualityBll>();

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
            ViewBag.Countries = GetCountriesLikeSelectList();
            ViewBag.CoffeeSorts = GetEnumLikeSelectList<CoffeeSortBll>();
            ViewBag.Qualities = GetEnumLikeSelectList<QualityBll>();

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

            ViewBag.Countries = GetCountriesLikeSelectList();
            ViewBag.CoffeeSorts = GetEnumLikeSelectList<CoffeeSortBll>();
            ViewBag.Qualities = GetEnumLikeSelectList<QualityBll>();

            return View("Create");
        }

        private SelectList GetCountriesLikeSelectList()
        {
            List<CountryView> countries = countryService.GetAll().Select(CountryMapper.Map).ToList();

            return new SelectList(countries, "Id", "Name");
        }

        private SelectList GetEnumLikeSelectList<T>() where T : struct
        {
            IEnumerable<T> enumValues = Enum.GetValues(typeof(T)).Cast<T>();

            return new SelectList(enumValues.Select(ev => new { Id = (int)(object)ev, Name = ev.ToString() }),
                "Id", "Name");
        }
    }
}