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
                viewModel.DocumentBase = doc.DocumentBase;
                viewModel.AdditionalInfo = doc.AdditionalInfo;
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
            var doc = viewModel.UserData.Documents.FirstOrDefault(x => x.id == viewModel.DocumentId);
            viewModel.UserData.Documents.Remove(doc);
            doc.AdditionalInfo = viewModel.AdditionalInfo;
            doc.DocumentBase = viewModel.DocumentBase;
            viewModel.UserData.Documents.Add(doc);
            try
            {
                viewModel.UserData = UserDataRepository.UpdateUserData(viewModel.UserData);

            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            viewModel.DocumentId = doc.id;
            viewModel.DocumentBase = doc.DocumentBase;
            viewModel.AdditionalInfo = doc.AdditionalInfo;
            viewModel.DocumentName = doc.Name;
            viewModel.DocumentDate = doc.Date.ToShortDateString();
            return View(viewModel);
        }

        public IActionResult CreateRelative(Guid UserId, Guid DocumentId)
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

            return RedirectToAction("Relative", new { UserId, DocumentId, RelativeId });
        }

        public IActionResult RemoveRelative(Guid RelativeId, Guid DocumentId)
        {
            Guid UserId = UserDataRepository.RemoveRelative(RelativeId);
            return RedirectToAction("Data", new { UserId, DocumentId });
        }

        [HttpGet]
        public IActionResult Relative(Guid UserId, Guid DocumentId, Guid RelativeId)
        {
            RelativeViewModel viewModel = new RelativeViewModel();
            try
            {
                viewModel.UserData = UserDataRepository.GetUserData(UserId);
                viewModel.Relative = viewModel.UserData.Relatives.FirstOrDefault(x => x.id == RelativeId);

                viewModel.RelativeId = RelativeId;

                switch (viewModel.Relative.KinsfolkType)
                {
                    case Core.Models.KinsfolkType.parent:
                        viewModel.Relative.RelativeType = "Родитель";
                        break;
                    case Core.Models.KinsfolkType.brother:
                        viewModel.Relative.RelativeType = "Брат (сестра)";
                        break;
                    case Core.Models.KinsfolkType.wife:
                        viewModel.Relative.RelativeType = "Муж (жена)";
                        break;
                    case Core.Models.KinsfolkType.child:
                        viewModel.Relative.RelativeType = "Ребенок";
                        break;
                    default:
                        break;
                }

                var doc = viewModel.UserData.Documents.Where(x => x.id == DocumentId).FirstOrDefault();

                viewModel.DocumentId = doc.id;
                viewModel.DocumentBase = doc.DocumentBase;
                viewModel.AdditionalInfo = doc.AdditionalInfo;
                viewModel.DocumentName = doc.Name;
                viewModel.DocumentDate = doc.Date.ToShortDateString();
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            ViewBag.RelativeTypes = DropDowns.GetRelativeTypes();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Relative(RelativeViewModel viewModel)
        {
            try
            {
                var UserData = UserDataRepository.GetUserData(viewModel.Relative.UserId);
                var relative = UserData.Relatives.FirstOrDefault(x => x.id == viewModel.RelativeId);
                UserData.Relatives.Remove(relative);
                viewModel.Relative.id = relative.id;
                viewModel.Relative.NationalityId = relative.NationalityId;
                viewModel.Relative.CountryOfResidenceId = relative.CountryOfResidenceId;
                switch (viewModel.Relative.RelativeType)
                {
                    case "Муж (жена)":
                        viewModel.Relative.KinsfolkType = Core.Models.KinsfolkType.wife;
                        break;
                    case "Родитель":
                        viewModel.Relative.KinsfolkType = Core.Models.KinsfolkType.parent;

                        break;
                    case "Ребенок":
                        viewModel.Relative.KinsfolkType = Core.Models.KinsfolkType.child;

                        break;
                    case "Брат (сестра)":
                        viewModel.Relative.KinsfolkType = Core.Models.KinsfolkType.brother;

                        break;
                    default:
                        break;
                }

                UserData.Relatives.Add(viewModel.Relative);

                UserDataRepository.UpdateUserData(UserData);
            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            return RedirectToAction("Data", new { UserId = viewModel.UserData.id, DocumentId = viewModel.DocumentId });
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

        [HttpGet]
        public IActionResult AddWork(Guid DocumentId)
        {
            DocumentEntity doc = new DocumentEntity();
            try
            {
                doc = UserDataRepository.GetDocument(DocumentId);
                UserDataRepository.AddWork(doc.UserId);
            }
            catch(UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            return RedirectToAction("Data", new { doc.UserId, DocumentId });
        }

        [HttpPost]
        public IActionResult AddWork(UserDataViewModel viewModel)
        {
            var doc = viewModel.UserData.Documents.FirstOrDefault(x => x.id == viewModel.DocumentId);
            viewModel.UserData.Documents.Remove(doc);
            doc.AdditionalInfo = viewModel.AdditionalInfo;
            doc.DocumentBase = viewModel.DocumentBase;
            viewModel.UserData.Documents.Add(doc);
            try
            {
                viewModel.UserData.Works.Add(new WorkEntity
                {
                    Address = new AddressEntity()
                });
                viewModel.UserData = UserDataRepository.UpdateUserData(viewModel.UserData);

            }
            catch (UserNotFoundException e)
            {
                Console.WriteLine(e.GetMessageObject());
                return RedirectToAction("NotFound");
            }

            viewModel.DocumentId = doc.id;
            viewModel.DocumentBase = doc.DocumentBase;
            viewModel.AdditionalInfo = doc.AdditionalInfo;
            viewModel.DocumentName = doc.Name;
            viewModel.DocumentDate = doc.Date.ToShortDateString();

            return RedirectToAction("Data", new { viewModel.UserData.UserId, viewModel.DocumentId });

        }
    }
}
