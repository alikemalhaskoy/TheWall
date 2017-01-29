using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TheWall.Models;

namespace TheWall.Controllers
{
    public class MessageController : ApiController
    {
        public IHttpActionResult Get()
        {
            InstantMessage message = new InstantMessage();
            message.Text = "duduk";

            return Ok(message.Text);
        }
    }
}
