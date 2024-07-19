using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCform.Controllers
{
    public class UserControllercs : Controller
    {
        // GET: UserControllercs
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserControllercs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserControllercs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserControllercs/Create
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

        // GET: UserControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserControllercs/Edit/5
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

        // GET: UserControllercs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserControllercs/Delete/5
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
