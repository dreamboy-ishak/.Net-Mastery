using Microsoft.AspNetCore.Mvc;

public class AmarController : Controller{
    public IActionResult User(int id){
        return Content($"User id: {id}");
    }
}