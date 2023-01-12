using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace dacn_api.Controllers
{
   
    public class FileController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Upload()
        {
            try
            {
                var request = HttpContext.Current.Request;
                //var description = request.Form["description"];
                var photo = request.Files["photo"];
                photo.SaveAs(HttpContext.Current.Server.MapPath("~/Assets/images/user/"+photo.FileName));

                 return new HttpResponseMessage(HttpStatusCode.OK);
                //return true;
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            //return false;
        }
    }
}
