using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDWeb.Models;
using Flurl.Http;

namespace DnDWeb.Controllers
{
    public class ClassController : Controller
    {
        List<ApiItem> _classCollection;

        public ClassController()
        {
            string apiUri = "https://www.dnd5eapi.co/api/classes";
            var apiTask = apiUri.GetJsonAsync<CharacterClass>();
            apiTask.Wait();
            _classCollection = apiTask.Result.results;
        }

        // GET: ClassController
        public ActionResult Index()
        {
            return View(_classCollection);
        }

        // GET: ClassController/Details/5
        public ActionResult Details(string index)
        {
            string apiUri = $"https://www.dnd5eapi.co/api/classes/{index}";
            var apiTask = apiUri.GetJsonAsync<ClassDetail>();
            apiTask.Wait();

            ClassDetail classDetail = apiTask.Result;

            return View(classDetail);
        }

        public ActionResult ItemDetails(string index)
        {
            string apiUri = $"https://www.dnd5eapi.co/api/equipment/{index}";
            var apiTask = apiUri.GetJsonAsync<Equipment>();
            apiTask.Wait();

            Equipment equipmentDetails = apiTask.Result;

            return View(equipmentDetails);
        }


        // GET: ClassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
