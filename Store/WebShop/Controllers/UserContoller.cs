﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using MyWebProject2.ViewModel;
using WebShop.Data.Models;
namespace MyWebProject2.Controllers
{
    public class UserContoller
    {
        [Authorize(Roles = "admin")]
        public class UsersController : Controller
        {
            UserManager<ShopUser> _userManager;

            public UsersController(UserManager<ShopUser> userManager)
            {
                _userManager = userManager;
            }
            public IActionResult Index() => View(_userManager.Users.ToList());
            public IActionResult Create() => View();

            [HttpPost]
            public async Task<IActionResult> Create(CreateUserVM model)
            {
                if (ModelState.IsValid)
                {
                    ShopUser user = new ShopUser
                    {
                        Email = model.Email,
                        UserName = model.UserName
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                return View(model);
            }

            public async Task<IActionResult> Edit(string id)
            {
                ShopUser user = await _userManager.FindByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                EditUserVM model = new EditUserVM { Id = user.Id, Email = user.Email, UserName = user.UserName };
                return View(model);
            }

            [HttpPost]
            public async Task<IActionResult> Edit(EditUserVM model)
            {
                if (ModelState.IsValid)
                {
                    ShopUser user = await _userManager.FindByIdAsync(model.Id);
                    if (user != null)
                    {
                        user.Email = model.Email;
                        user.UserName = model.UserName;

                        var result = await _userManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError(string.Empty, error.Description);
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "ShopUser not found");
                    }

                }
                return View(model);
            }
            [HttpPost]
            public async Task<IActionResult> Delete(string id)
            {
                ShopUser user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    IdentityResult result = await _userManager.DeleteAsync(user);
                }
                return RedirectToAction("Index");
            }

            public async Task<IActionResult> ChangePassword(string id)
            {
                ShopUser user = await _userManager.FindByIdAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                ChangePasswordVM model = new ChangePasswordVM { Id = user.Id, Name = user.UserName };
                return View(model);
            }

            [HttpPost]
            public async Task<IActionResult> ChangePassword(ChangePasswordVM model)
            {
                if (ModelState.IsValid)
                {
                    ShopUser user = await _userManager.FindByIdAsync(model.Id);
                    if (user != null)
                    {
                        IdentityResult result =
                            await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError(string.Empty, error.Description);
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "ShopUser not found");
                    }
                }
                return View(model);
            }
        }
    }
}
