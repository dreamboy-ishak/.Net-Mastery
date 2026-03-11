using Microsoft.AspNetCore.Mvc;

public class AmarController : Controller
{
    public IActionResult Index(){//by default route
        return Content("This is a index page");
    }

    public IActionResult Hello(){
        return Content("This is a MVC app!");
    }

    public IActionResult Contact(){
        return Content("This is a Contact page");
    }

    //Understand how url maps to controller actions

}