﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using DBServices;
using System.Web.Http.Cors;
using DataAccessLayer.Model;

namespace Water.Controllers
{
    public class TestController : Controller
    {
        DataBaseContext DB = new DataBaseContext();
        private ITestService _testService = null;
       

        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult GetTestList()
        {
            List<Test> test = _testService.GetTestList();
            if (test.Count > 0)
            {
                return Json(new
                {
                    message = "PatientListLoaded",
                    success = true,
                    model = test
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

        public ActionResult AddTest(Test tst)
        {
            var tstID = _testService.AddTest(tst);
            if (tstID != 0)
            {
                return Json(new
                {
                    message = "Test save successfully",
                    success = true,
                    model = tstID
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to save test",
                    success = false
                }, JsonRequestBehavior.AllowGet);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult GetTestRecordByID(int tst_Id)
        {
            var pt = _testService.GetTestRecById(tst_Id);
            if (pt != null)
            {
                return Json(new
                {
                    message = "Test Rec is available",
                    success = true,
                    model = pt
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Test not exist",
                    success = false
                }, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult AddPackageMaster( PackageMater pkg)
        {
            var pkgM = _testService.AddPackageMaster(pkg);
            if (pkgM != 0)
            {
                return Json(new
                {
                    message = "Package Save Successfully",
                    success = true,
                    model = pkgM
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    message = "Failed to save records",
                    success = false
                }, JsonRequestBehavior.AllowGet);

            }
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ActionResult AddPackageDetail(PackaDetail[] packageDetail, int PackageMasterID)
        {
            //PackaDetail[] packageDetail,
            //    var VpackageDetail = _testService.AddPackageDetail(packageDetail.ToList(), PackageMasterID);
            //    if (VpackageDetail)
            //    {
            //        return Json(new
            //        {
            //            message = "Package Save Successfully",
            //            success = true,
            //            model = VpackageDetail
            //        }, JsonRequestBehavior.AllowGet);
            //    }
            //    else
            //    {
            //        return Json(new
            //        {
            //            message = "Failed to Save record ",
            //            success = false
            //        }, JsonRequestBehavior.AllowGet);

            //    }
            return null;
        }


    }
}