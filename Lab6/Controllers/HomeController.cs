using Lab6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers;

public class HomeController : Controller
{
    private CompositeModel _compositeModel = new CompositeModel();
    
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult OrderSummary()
    {
        return View();
    }
    
    public IActionResult SelectQuantity()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(User user)
    {
        if (user.Age <= 0)
        {
            return View();
        }
        
        TempData["UserName"] = user.Name;
        TempData["UserAge"] = user.Age;
        if (user.Age >= 16)
        {
            return RedirectToAction("SelectQuantity");
        }

        _compositeModel = new CompositeModel(user, new Order());
        return View("OrderSummary", _compositeModel);
    }
    
    [HttpPost]
    [ActionName("SelectQuantity")]
    public IActionResult SelectQuantity(Order order)
    {
        if (order.OrderQuantity == 0)
        {
            return View();
        }

        User user = new User((string)TempData["UserName"], (int)TempData["UserAge"]);
        _compositeModel = new CompositeModel(user, order);
        return View("OrderSummary", _compositeModel);
    }
}