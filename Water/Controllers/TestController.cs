using System;
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
        public ActionResult GetTestlist()
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


    }
}