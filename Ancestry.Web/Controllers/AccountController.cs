using Ancestry.Models;
using Ancestry.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ancestry.Web.Controllers
{
    public class AccountController : Controller
    {
        public IAccountService accountService;

        public AccountController()
        {
            accountService = new AccountService();
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserInformation info = null;
                info = accountService.ValidateUserData(model);
                if (info != null)
                {
                    return RedirectToAction("");
                }
            }
            return View();
        }
    }
}