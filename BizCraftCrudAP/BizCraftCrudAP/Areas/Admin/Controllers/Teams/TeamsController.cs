using BizCraftCrudAP.DAL;
using BizCraftCrudAP.Extensions;
using BizCraftCrudAP.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BizCraftCrudAP.Areas.Admin.Controllers.Teams
{
    [Area("Admin")]
    public class TeamsController : Controller
    {
        private readonly BizContext _context;
        private readonly IHostingEnvironment _env;
        public TeamsController(BizContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Teams);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }

            if (!team.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Image type is not valid");
                return View(team);
            }

            if (team.Photo.IsSmaller(1) )
            {
                ModelState.AddModelError("Photo", "Image size can be max 1 mb");
            }

            //var filename = Guid.NewGuid().ToString() + Path.GetFileName(team.Photo.FileName);

            //string path = _env.WebRootPath + @"\images\" + filename;
        

            team.Image = await team.Photo.SaveFileAsync(_env.WebRootPath, "images");

            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}