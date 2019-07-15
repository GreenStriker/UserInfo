using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInfo.Models;
using UserInfo.Repository;

namespace UserInfo.Controllers
{
    public class DivitionController : Controller
    {
        // GET: Divition


       private IDivition idv;

        public DivitionController()
       {

           this.idv = new DivitionRepo(new Models.userEntities());


       }

        public ActionResult Index()
        {

            var divlist = idv.getDivition().ToList();
            return View(divlist);
        }

        // GET: Divition/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Divition/Create
        public ActionResult Create()
        {
            return View(new Divition());
        }

        // POST: Divition/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection ,Divition insertDv)
        {
            try
            {
                // TODO: Add insert logic here
                var adddv = new Divition();
                adddv.Name = insertDv.Name;
                //adddv.DivitionId = insertDv.DivitionId;
                idv.InserDivition(adddv);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Divition/Edit/5
        public ActionResult Edit(int id)
        {
            var getdv = idv.GetDivitionId(id);
            var editdc = new Divition();
            editdc.Name = getdv.Name;
            editdc.DivitionId = getdv.DivitionId;

            return View(editdc);
        }

        // POST: Divition/Edit/5
        [HttpPost]
        public ActionResult Edit(Divition dv, FormCollection collection)
        {
            try
            {
                idv.UpdateDivition(dv);

                


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Divition/Delete/5
        public ActionResult Delete(int id)
        {

            try
            {
                idv.DeleteDivition(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    
    }
}
