using BLL.Models;
using PL.Mappers;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PL.Helpers;

namespace PL.Controllers
{
    public class TeaController : Controller
    {
        public ActionResult Index()
        {
            List<TeaView> allTea = ParseFromResponseHelper.GetObject<List<TeaBll>>("Tea")
                .Select(TeaMapper.Map).ToList();
            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();

            return View(allTea);
        }

        public ActionResult Details(Guid id)
        {
            TeaView Tea = ParseFromResponseHelper.GetObject<TeaBll>("Tea?id=" + id).Map();

            return View(Tea);
        }

        public ActionResult Edit(Guid id)
        {
            TeaView Tea = ParseFromResponseHelper.GetObject<TeaBll>("Tea?id=" + id).Map();
            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View(Tea);
        }

        public ActionResult Edited(TeaView Tea)
        {
            if (ModelState.IsValid)
            {
                ParseFromResponseHelper.PutObject("Tea/Update", Tea.Map());

                return RedirectToAction("Details", "Tea", new { id = Tea.Id });
            }

            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Edit", Tea);
        }

        public ActionResult Delete(Guid id)
        {
            TeaView Tea = ParseFromResponseHelper.GetObject<TeaBll>("Tea?id=" + id).Map();

            return View(Tea);
        }

        public ActionResult Deleted(TeaView Tea)
        {
            ParseFromResponseHelper.DeleteObject("Tea/Delete", Tea.Map());

            return RedirectToAction("Index", "Tea");
        }

        public ActionResult Create()
        {
            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View();
        }

        public ActionResult Created(TeaView Tea)
        {
            Tea.Id = Guid.NewGuid();

            if (ModelState.IsValid)
            {
                ParseFromResponseHelper.PostObject("Tea/Create", Tea.Map());

                return RedirectToAction("Index", "Tea");
            }

            ViewBag.Countries = SelectListHelper.GetCountries();
            ViewBag.TeaSorts = SelectListHelper.GetEnum<TeaSortBll>();
            ViewBag.Qualities = SelectListHelper.GetEnum<QualityBll>();

            return View("Create");
        }
    }
}