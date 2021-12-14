using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Plan.Data.Entities;
using Plan.intereces;
using Plan.Models;
using Plan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly SignInManager<DbUser> _signInManager;
        private readonly RoleManager<DbRole> _roleManager;
        private readonly IWebHostEnvironment _env;
        private readonly IRepository _repository;
        private readonly AppDBContent _appDBContent;

        public AccountController(UserManager<DbUser> userManager,
            SignInManager<DbUser> signInManager,
            RoleManager<DbRole> roleManager, AppDBContent appDBContent,
            IRepository repository, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _appDBContent = appDBContent;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            bool isEmailExist;
            if (model.Email == null)
            {
                return View(model);
            }
            else
            {
                isEmailExist = await _userManager.FindByEmailAsync(model.Email) == null;
            }           
            if (isEmailExist)
            {
                ModelState.AddModelError("Email", "Такий користувач не зареєстрований");
                return View(model);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    var userRoles = await _userManager.GetRolesAsync(user);
                    if (user != null)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                        if (result.Succeeded)
                        {
                            if (userRoles.FirstOrDefault() == "Teacher")
                            {
                                return View("Views/Teacher/Index.cshtml");
                            }
                            if (userRoles.FirstOrDefault() == "Manager")
                            {
                                await _signInManager.SignInAsync(user, isPersistent: false);
                                return View("Views/Manager/Index.cshtml");
                            }
                            if (userRoles.FirstOrDefault() == "Admin")
                            {
                                await _signInManager.SignInAsync(user, isPersistent: false);
                                return View("Views/Admin/Index.cshtml");
                            }
                        }
                    }
                }
            }
            ModelState.AddModelError("", "Дані вказано не коректно");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Registration(int id)
        {
            RegistrationViewModel registrationViewModel = new RegistrationViewModel { Id = id };
            return View(registrationViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            bool isEmailExist;
            if (model.Email == null)
            {
                return View(model);
            }
            else
            {
                isEmailExist = await _userManager.FindByEmailAsync(model.Email) == null;
            }

            if (!isEmailExist)
            {
                ModelState.AddModelError("Email", "Така пошта уже існує");
            }

            if (!isEmailExist)
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                var user = new DbUser
                {
                    Email = model.Email,
                    UserName = model.Email,
                    PhoneNumber = model.PhoneNumber
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    if (model.Id == 1)
                    {
                        await _userManager.AddToRoleAsync(user, "Teacher");
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        await _repository.createOtherTypesWork1(model.Email);
                        await _repository.createOtherTypesWork2(model.Email);
                        await _repository.createWorkloadSum(model.Email);

                        UserNameModel userNameModel = new UserNameModel();
                        var tempUser = _userManager.Users.Where(s => s.Email == model.Email).FirstOrDefault();
                        userNameModel.DbUserId = (Int32)tempUser.Id;
                        userNameModel.Name = model.Name;
                        userNameModel.LastName = model.LastName;
                        await _repository.createUserNames(userNameModel);
                        return RedirectToAction("Login");
                    }
                    if (model.Id == 2)
                    {
                        await _userManager.AddToRoleAsync(user, "Manager");
                        return RedirectToAction("Login");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Щось пішло не так.");
                }
            }
            return View(model);
        }
    }
}
