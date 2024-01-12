using Microsoft.AspNetCore.Mvc;
using AspNetMVC.Models;

public class ConsultationController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public string Consultation(ConsultationModel model)
    {
        if (ModelState.IsValid)
        {
            return $"Дані пройшли валідацію: {model.Name} - {model.Email} - {model.ConsultationDate} - {model.SelectedProduct}";
        }
        return "Дані не пройшли валідацію";
    }
}
