using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInfo.Models;
using UserInfo.Repository;
using UserInfo.ViewModel;
namespace UserInfo.Controllers
{
    public class DistricController : Controller
    {
        // GET: Distric

        private IDistrict idis;
        private IDivition idv;
        public DistricController()
       {

           this.idis = new DistrictRepo(new Models.userEntities());

           this.idv = new DivitionRepo(new Models.userEntities());

       }


        public ActionResult Index()
        {


            var dislist = idis.getDistrict().ToList();
            return View(dislist);
        }

        // GET: Distric/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Distric/Create
        public ActionResult Create()
        {
            var district = new vmDistrict();
           // var item = idv.GetKVP();
            district.Divitions =idv.GetKVP();
            return View(district);
        }

        // POST: Distric/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, District insertDc)
        {
            try
            {
               
                var adddv = new District();
                adddv.Name = insertDc.Name;
                adddv.DivitionId = insertDc.DivitionId;
                idis.InserDistrict(adddv);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Distric/Edit/5
        public ActionResult Edit(int id)
        {   var  getdc = idis.GetDistrict(id);
            var editdc = new vmDistrict();
            editdc.DistrictId = getdc.DistrictId;
            editdc.Name = getdc.Name;
            editdc.DivitionId = getdc.DivitionId;
            editdc.Divitions = idv.GetKVP();

            return View(editdc);
        }

        // POST: Distric/Edit/5
        [HttpPost]
        public ActionResult Edit(District dis, FormCollection collection)
        {
            try
            {
                idis.UpdateDistrict(dis);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Distric/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                idis.DeleteDistrict(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    
    }
}
