using Controllers;
using Core.Application;
using Microsoft.AspNetCore.Mvc;

namespace Controllers_API.Controllers
{
    public class AutomovilController(ICommandQueryBus commandQueryBus) : BaseController
{
    public IActionResult Index()
    {
        return View();
    }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
