using Microsoft.AspNetCore.Mvc;
using AspNetMVC.Models;

namespace AspNetMVC.Components
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<ProductModel> products)

        {
            return View("/Views/Product/ProductTable.cshtml", products);

        }
    }
}
