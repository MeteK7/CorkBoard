﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorkBoardUI.BusinessManagers.Interfaces;
using CorkBoardUI.ViewModels.AdminViewModels;

namespace CorkBoardUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAdminBusinessManager adminBusinessManager;

        public AdminController(IAdminBusinessManager adminBusinessManager)
        {
            this.adminBusinessManager = adminBusinessManager;
        }
        public async Task<IActionResult> Index()
        {
            return View(await adminBusinessManager.GetAdminDashboard(User));
        }

        public async Task<IActionResult> EditAbout()//The about page for author (Not for the site creator!)
        {
            return View(await adminBusinessManager.GetAboutViewModel(User));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(AboutViewModel aboutViewModel)
        {
            await adminBusinessManager.UpdateAbout(aboutViewModel, User);
            return RedirectToAction("EditAbout");
        }
    }
}
