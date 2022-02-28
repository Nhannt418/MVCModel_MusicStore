﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMusicStore1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: HelloWorld

        /* public string Index()
         {
             return "This is my <b>default</b> action...";
         }*/

        // 
        // GET: /HelloWorld/Welcome/ 

        /* public string Welcome()
         {
             return "This is the Welcome action method...";
         }*/

        /*  public static void RegisterRoutes(RouteCollection routes)
          {
              routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

              routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
              );
          }


          public string Welcome(string name, int numTimes = 1)
          {
              return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
          }

          public ActionResult Index()
          {
              return View();
          }
          */

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }


    }


}