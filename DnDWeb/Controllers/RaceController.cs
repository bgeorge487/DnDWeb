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
    public class RaceController : Controller
    {
        List<ApiItem> _raceCollection;

        public RaceController()
        {
            string apiUri = "https://www.dnd5eapi.co/api/races";
            var apiTask = apiUri.GetJsonAsync<CharacterRace>();
            apiTask.Wait();
            _raceCollection = apiTask.Result.results;
        }

        // GET: RaceController
        public ActionResult Index()
        {
            return View(_raceCollection);
        }

        // GET: RaceController/Details/5
        public ActionResult Details(string index)
        {
            string apiUri = $"https://www.dnd5eapi.co/api/races/{index}";
            var apiTask = apiUri.GetJsonAsync<RaceDetails>();
            apiTask.Wait();

            RaceDetails raceDetail = apiTask.Result;

            return View(raceDetail);
        }

        public ActionResult TraitDetails()
        {
            return View();
        }

        // GET: RaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RaceController/Create
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

        // GET: RaceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RaceController/Edit/5
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

        // GET: RaceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RaceController/Delete/5
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
