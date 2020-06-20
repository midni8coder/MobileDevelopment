using GuestApp.Data.GuestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace GuestApp.WebAPI.Controllers.GuestApp.API
{
    public class GuestAppCommonController : ApiController
    {
        protected static JsonMediaTypeFormatter formatter = new JsonMediaTypeFormatter();

        [HttpGet]
        [Route("api/guest/common/GetGuestList")]
        public HttpResponseMessage GetGuestList()
        {
            GuestData userData = new GuestData();
            var data = userData.GetGuestList();

            return Request.CreateResponse(System.Net.HttpStatusCode.OK,
                        data.Tables[0]
                        , formatter, "application/json");
        }
    }
}