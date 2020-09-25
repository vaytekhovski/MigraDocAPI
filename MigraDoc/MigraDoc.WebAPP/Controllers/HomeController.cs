using Com.SNGJob.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using MigraDoc.Core.CRUD;
using MigraDoc.Core.Entities;
using MigraDoc.Core.ViewModels;
using MigraDoc.WebAPP.Models;
using MigraDoc.Core.ViewModels;
using System;
using System.Linq;

namespace MigraDoc.WebAPP.Controllers
{
    public class HomeController : Controller
    {
        private UserDataRepository UserDataRepository;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NotFound()
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
            ClientsViewModel viewModel = new ClientsViewModel();
            foreach (var user in Users)
            {
                foreach (var document in user.Documents)
                {
                    var userDataViewModel = new UserDataViewModel();
                    userDataViewModel.UserData = user;

                    userDataViewModel.DocumentId = document.id;
                    userDataViewModel.DocumentName = document.Name;
                    userDataViewModel.DocumentDate = document.Date.ToShortDateString();


                    switch (document.Status)
                    {
                        case Core.Models.DocumentStatusType.none:
                            userDataViewModel.DocumentStatus = "none";
                            break;
                        case Core.Models.DocumentStatusType.NotStarted:
                            userDataViewModel.DocumentStatus = "Не начат";
                            break;
                        case Core.Models.DocumentStatusType.InWork:
                            userDataViewModel.DocumentStatus = "В процессе";
                            break;
                        case Core.Models.DocumentStatusType.Complete:
                            userDataViewModel.DocumentStatus = "Завершен";
                            break;
                        default:
                            break;
                    }

                    viewModel.Users.Add(userDataViewModel);
                }
                
            }

            viewModel.filter.Countrys = DropDowns.GetCountrys();
            viewModel.filter.DocumentTypes = DropDowns.GetDocumentTypes();
            viewModel.filter.DocumentStatuses = DropDowns.GetDocumentStatuses();
            viewModel.filter.Sexs = DropDowns.GetSexs();
            viewModel.filter.ChangedNames = DropDowns.GetChangedNames();
            viewModel.filter.OrderBy = DropDowns.GetOrderBy();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Clients(ClientsViewModel viewModel)
        {
            var Users = UserDataRepository.GetUsers(viewModel.filter);
            viewModel.Users.Clear();
            foreach (var user in Users)
            {
                foreach (var document in user.Documents)
                {
                    var userDataViewModel = new UserDataViewModel();
                    userDataViewModel.UserData = user;


                    userDataViewModel.DocumentId = document.id;
                    userDataViewModel.DocumentName = document.Name;
                    userDataViewModel.DocumentDate = document.Date.ToShortDateString();


                    switch (document.Status)
                    {
                        case Core.Models.DocumentStatusType.none:
                            userDataViewModel.DocumentStatus = "none";
                            break;
                        case Core.Models.DocumentStatusType.NotStarted:;
                            userDataViewModel.DocumentStatus = "Не начат";
                            break;
                        case Core.Models.DocumentStatusType.InWork:
                            userDataViewModel.DocumentStatus = "В процессе";
                            break;
                        case Core.Models.DocumentStatusType.Complete:
                            userDataViewModel.DocumentStatus = "Завершен";
                            break;
                        default:
                            break;
                    }

                    viewModel.Users.Add(userDataViewModel);
                }

            }


            viewModel.filter.Countrys = DropDowns.GetCountrys();
            viewModel.filter.DocumentTypes = DropDowns.GetDocumentTypes();
            viewModel.filter.DocumentStatuses = DropDowns.GetDocumentStatuses();
            viewModel.filter.Sexs = DropDowns.GetSexs();
            viewModel.filter.ChangedNames = DropDowns.GetChangedNames();
            viewModel.filter.OrderBy = DropDowns.GetOrderBy();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Data(Guid UserId, Guid DocumentId)
        {
            UserDataViewModel viewModel = new UserDataViewModel();
            try
            {
                viewModel.UserData = UserDataRepository.GetUserData(UserId);
                var doc = viewModel.UserData.Documents.Where(x => x.id == DocumentId).FirstOrDefault();


                viewModel.DocumentId = doc.id;
                viewModel.DocumentName = doc.Name;
                viewModel.DocumentDate = doc.Date.ToShortDateString();


                switch (doc.Status)
                {
                    case Core.Models.DocumentStatusType.none:
                        viewModel.DocumentStatus = "none";
                        break;
                    case Core.Models.DocumentStatusType.NotStarted:
                        ;
                        viewModel.DocumentStatus = "Не начат";
                        break;
                    case Core.Models.DocumentStatusType.InWork:
                        viewModel.DocumentStatus = "В процессе";
                        break;
                    case Core.Models.DocumentStatusType.Complete:
                        viewModel.DocumentStatus = "Завершен";
                        break;
                    default:
                        break;
                }
            }
            catch(UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Data(UserDataViewModel viewModel)
        {
            try
            {
                UserDataRepository.UpdateUserData(viewModel.UserData);

            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }
            return View(viewModel);
        }

        public IActionResult CreateRelative(Guid UserId)
        {
            Guid RelativeId = new Guid();
            try
            {
                RelativeId = UserDataRepository.CreateRelative(UserId);
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            return RedirectToAction("Relative", new { UserId, RelativeId });
        }

        public IActionResult RemoveRelative(Guid RelativeId)
        {
            Guid UserId = UserDataRepository.RemoveRelative(RelativeId);
            return RedirectToAction("Data", UserId);
        }

        [HttpGet]
        public IActionResult Relative(Guid UserId, Guid RelativeId)
        {
            UserDataEntity viewModel = new UserDataEntity();
            try
            {
                viewModel = UserDataRepository.GetUserRelative(UserId, RelativeId);
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Relative(UserDataEntity viewModel)
        {
            try
            {
                UserDataRepository.UpdateUserData(viewModel);
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            return View(viewModel);
        }

        public IActionResult ChangeDocumentStatus(Guid DocumentId)
        {
            Guid UserId = new Guid();
            try
            {
                UserId = UserDataRepository.ChangeUserDocumentStatus(DocumentId);
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            return RedirectToAction("Data", new { UserId, DocumentId });
        }
    }
}
