using Microsoft.AspNetCore.Mvc;
using MigraDoc.Core.CRUD;
using MigraDoc.Core.ViewModels;

namespace MigraDoc.WebAPP.Controllers
{
    public class HomeController : Controller
    {
        private UserDataRepository UserDataRepository;

        public IActionResult Index()
        {
            return View();
        }
        public HomeController(UserDataRepository UserDataRepository)
        {
            this.UserDataRepository = UserDataRepository;
        }
        [HttpGet]
        public IActionResult Clients()
        {
            var Users = UserDataRepository.GetUsers(new ClientsFilterPanel());
            ClientsViewModel viewModel = new ClientsViewModel()
            {
                Users = Users
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Clients(ClientsViewModel viewModel)
        {
            viewModel.Users = UserDataRepository.GetUsers(viewModel.filter);

            return View(viewModel);
        }
    }
}
