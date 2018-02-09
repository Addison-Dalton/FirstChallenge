using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstChallenge.Models;
using System.Web.Mvc;
using System.Net;

namespace FirstChallenge.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Index()
        {
            var comicBooks = Models.ComicBookManager.GetComicBooks();

            return View(comicBooks);
        }

        // GET: ComicBook/Details
        public ActionResult Details(int? comicBookId)
        {
            if(comicBookId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComicBook comicBook = Models.ComicBookManager.GetComicBooks().Find(p => p.ComicBookId == comicBookId);
            if(comicBook == null)
            {
                return HttpNotFound();
            }
            return View(comicBook);
        }
    }
}