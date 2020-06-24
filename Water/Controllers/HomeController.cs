using DBServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Cors;
using DataAccessLayer.Model;
using System.Globalization;

namespace Water.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService = null;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            var count = _userService.GetUserCount();
            return View();
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]

        public ActionResult Login(string Email, string Password)
        {
            var login = _userService.GetUserByEmailByPassword(Email, Password);
            if (login != null)
            {
                return Json(new
                {
                    message = "Authorized user",
                    success = true,
                    model = login
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "UnAuthorized",
                    success = false

                }, JsonRequestBehavior.AllowGet);
            }
        }

      

        public ActionResult AddPatient(Patient pt)
        {
            var patient_id = _userService.AddPatient(pt);
            if (patient_id != 0)
            {
                return Json(new
                {
                    message = "Record Save Sucessfully",
                    success = true,
                    model = patient_id
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to save record",
                    success = true
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetPatientreferrelTypeId()
        {
            List<PatientReferrelTypeModel> referrelType = _userService.GetReferrelTypeList();
            if (referrelType.Count > 0)
            {
                return Json(new
                {
                    message = "Referral Type list Loaded",
                    success = true,
                    model = referrelType
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to Load Referral Type",
                    success = false
                });
            }
        }

        public ActionResult GetPartnerName()
        {
            List<PartnerName> parterName = _userService.GetPartnerNameList();
            if (parterName.Count > 0)
            {
                return Json(new
                {
                    message = "Partner list Loaded",
                    success = true,
                    model = parterName
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to Load Partner list",
                    success = false,
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetGenderName()
        {
            List<GenderModel> genderName = _userService.GetGenderNameList();
            if (genderName.Count > 0)
            {
                return Json(new
                {
                    message = "Gender list Loaded",
                    success = true,
                    model = genderName
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to Load Gender list",
                    success = false
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetPanelName()
        {
            List<PanelMasterModel> PanelName = _userService.GetPanelNameList();
            if (PanelName.Count > 0)
            {
                return Json(new
                {
                    message = "Panel list Loaded",
                    success = true,
                    model = PanelName
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to Load Gender list",
                    success = false
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
