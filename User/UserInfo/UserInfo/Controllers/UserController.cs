using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInfo.Repository;
using UserInfo.ViewModel;

namespace UserInfo.Controllers
{
    public class UserController : Controller
    {
        // GET: User

       private IDistrict idis;
        private IDivition idv;
        private IUser iuser;
        public UserController()
       {

           this.idis = new DistrictRepo(new Models.userEntities());

           this.idv = new DivitionRepo(new Models.userEntities());


           this.iuser = new UserRepo(new Models.userEntities());
       }

        public ActionResult Dis(int id=0)
        {

            var list = idis.GetKVP(id);

            return Json(list,JsonRequestBehavior.AllowGet);

        }

        public ActionResult Index()
        {
            var UserList = iuser.getUser().ToList();

            return View(UserList);
        }



        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            var user = new vmUser();
            // var item = idv.GetKVP();
            user.Divitions = idv.GetKVP();
            user.Districts = idis.GetKVP(0);
            return View(user);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, ViewModel.vmUser user)
        {
            try
            {
                var adduser = new Models.UserInfo();
                user.Divitions = idv.GetKVP();
                user.Districts = idis.GetKVP(9);
                adduser.FristName = user.FristName ;
                adduser.LastName = user.LastName   ;
                adduser.UserName = user.UserName  ;
                adduser.Email = user.Email  ;
                adduser.Mobile = user.Mobile   ;
                adduser.GenderId = user.GenderId ;
                adduser.DivitionId = user.DivitionId  ;
                adduser.DistrictId = user.DistrictId   ;
                adduser.LastEducationalQulification = user.LastEducationalQulification ;
                adduser.Occupation = user.Occupation    ;
                adduser.PresentAddress = user.PresentAddress ;
                adduser.DateOFBirth = user.DateOFBirth;



                iuser.InserUser(adduser);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
