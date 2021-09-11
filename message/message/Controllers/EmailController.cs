using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;

namespace message.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email

        public ActionResult SendEmail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(string usermail)
        {
            string subject = "this is a subject part of mail";
            string body = "this is a body part of mail";

            WebMail.Send(usermail, subject, body, null, null);
            @ViewBag.msg = "Email";
            @ViewBag.msg = "Email Sended !!";
            return View();
        }
    }
}