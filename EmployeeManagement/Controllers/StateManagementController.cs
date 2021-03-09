using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateManagementController: Controller
{
    public ViewResult FirstPage()
    {
        TempData["xyz"]="This is xyz";
        ViewData["x"]=356;
        ViewBag.Y = 101;

        //2.Session
        HttpContext.Session.SetInt32("dob", 234);

        
        //1. Cookie
         var userName = "Anisha Bajracharya";
        CookieOptions options = new CookieOptions();
        // options.MaxAge = DateTimeOffset.FromUnixTimeSeconds(3242).Hour;
        options.Expires = DateTime.Now.AddHours(1);
        Response.Cookies.Append("user", userName);



        //2. Query strings
        return View();
    }
    public ViewResult SecondPage(string name, int age)
    {
        
        var user = Request.Cookies["user"];
        
        var x = TempData["xyz"];

        //2. Query Strings
        return View("SecondPage",user);
    }
    [HttpPost]
    public ViewResult SecondPage(string id)
    {
        var x = TempData["xyz"];
        return View();
    }
}
