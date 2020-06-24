using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using DBServices;
using System.Web.Http.Cors;

namespace Water.Controllers
{
    public class PatientController : Controller
    {
        DataBaseContext DB = new DataBaseContext();

        private IUserService _userService = null;
        public PatientController(IUserService userService)
        {
            _userService = userService;
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult AddPatient(Patient pt)
        {
                var PatientID = _userService.AddPatient(pt);       
                if (PatientID != 0)
                {
                    return Json(new
                    {
                        message = "Record save successfully",
                        success = true,
                        model = PatientID
                    }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                return Json(new
                {
                    message = "Failed to Save Record",
                    success = true                    
                }, JsonRequestBehavior.AllowGet);
            } 
        }


        public ActionResult GetPatientlist()
        {
            List<Patient> Pt = _userService.GetPatientList();
            var ist = new List<Patient>();
            if (Pt.Count > 0)
            {
                return Json(new
                {
                    message = "PatientListLoaded",
                    success = true,
                    model = Pt
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "PatientListLoadFailed",
                    sucess = false
                }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult GetPatientRecordByID(int ID)
        {
            var pt = _userService.GetPatientRecById(ID);
            if (pt != null)
            {
                return Json(new {
                    message = "Patient Rec is available",
                    success = true,
                    model = pt
                },JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Patient not exist",
                    success = false
                }, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult EditPatientRec(int id, Patient pt)
        {
            var pt_Id = _userService.EditPatientRec(id, pt);
            if (pt_Id !=null)
            {
                return Json(new
                {
                    message = "Patient record update sucessfully",
                    sucess = true,
                    model = pt
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to update patient record",
                    sucess = true
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
