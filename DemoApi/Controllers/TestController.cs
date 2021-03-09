using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
[ApiController]
[Route("Test")]
public class TestController : ControllerBase
{
    [HttpGet]
    [Route("name")]
    public string[] GetName()
    {
        return new string[] { "Ram Prasad","Hari Yadav" };
    }
    [HttpGet]
    [Route("capitalizeNames")]
    public string[] CapitalizeNames()
    {
        var names = new string[] { "Ram Prasad","Hari Yadav" };
        var cNames = names.Select(x => x.ToUpper()).ToArray();
        return cNames;
    }
}  

