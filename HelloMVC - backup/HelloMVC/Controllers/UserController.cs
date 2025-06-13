using System.Diagnostics;
using HelloMVC.Models;
using HelloMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }

        [HttpPost]
        public IActionResult Save(User user)
        {
            if (user.Id == 0)
                _userService.Add(user);
            else
                _userService.Update(user);

            return RedirectToAction("Index");
        }

        public IActionResult Select(int id)
        {
            var user = _userService.GetById(id) ?? new User();
            ViewBag.SelectedUser = user;

            return View("Index", _userService.GetAll());
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _userService.DeleteById(id);
            return RedirectToAction("Index");
        }

        public IActionResult Reset()
        {
            return RedirectToAction("Index");
        }
    }
}
