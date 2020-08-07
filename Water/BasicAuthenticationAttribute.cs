using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using DBServices;
using System.Security.Principal;
using System.Threading;

namespace Water
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public UserService _userService;
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
                string[] firstNameLastNameArray = decodedAuthenticationToken.Split(':');
                string firstName = firstNameLastNameArray[0];
                string lastName = firstNameLastNameArray[1];
                var res = _userService.GetUserByFNameAndLName(firstName, lastName);


                if (res != null)
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(firstName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}