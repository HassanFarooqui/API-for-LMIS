using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer.Model;
using System.Globalization;
using System.Web.Http.Cors;
using DBServices;
using System.Web.Mvc;


namespace Water.Controllers
{
    public class PanelController : Controller
    {
        private IUserService _userService = null;
      

        public PanelController(IUserService userService)
        {
            _userService = userService;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
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
