using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameReviewSite.Models;

namespace GameReviewSite.Controllers
{
    public class GameController : Controller
    {
        public static List<GameModel> GameList = new List<GameModel>();
        public static int Id = 0;

        // GET: Game
        public ActionResult Index()
        {
            return View(GameList);
        }

        // GET: Game/Details/5
        public ActionResult Details(int id)
        {
            return View(GameList.Find(c => c.Id == id));
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameModel game, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                GameList.Add(game);
                Id = Id++;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int id)
        {
            return View(GameList.Find(c => c.Id == id));
        }

        // POST: Game/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GameModel gameEdit,IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                GameList.Remove(GameList.Find(c => c.Id == id));

                GameList.Add(gameEdit);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GameList.Find(c => c.Id == id));
        }

        // POST: Game/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                GameList.Remove(GameList.Find(c => c.Id == id));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}