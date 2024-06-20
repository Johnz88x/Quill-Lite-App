using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quill_Lite_App.Data;
using Quill_Lite_App.Models;

namespace Quill_Lite_App.Controllers
{
    public class QuillsController : Controller
    {
        private readonly Quill_Lite_AppContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public QuillsController(Quill_Lite_AppContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Quills
        public async Task<IActionResult> Index()
        {
            // Ensure _context.Quill is not null before querying
            if (_context.Quill == null)
            {
                return Problem("Entity set 'Quill_Lite_AppContext.Quill' is null.");
            }

            var quills = await _context.Quill.ToListAsync();
            return View(quills);
        }

        // GET: Quills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Quill == null)
            {
                return NotFound();
            }

            var quill = await _context.Quill.FirstOrDefaultAsync(m => m.Id == id);

            if (quill == null)
            {
                return NotFound();
            }

            return View(quill);
        }

        // GET: Quills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quills/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Material,Ratings,SizeFit,Color,Price,ImageFile")] Quill quill)
        {
            if (ModelState.IsValid)
            {
                // Handle image upload
                if (quill.ImageFile != null)
                {
                    string uploadPath = Path.Combine(_hostEnvironment.WebRootPath, "images");

                    // Ensure the directory exists
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }

                    string fileName = Path.GetFileNameWithoutExtension(quill.ImageFile.FileName);
                    string extension = Path.GetExtension(quill.ImageFile.FileName);
                    string uniqueFileName = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;
                    quill.ImagePath = Path.Combine("images", uniqueFileName);
                    string fullPath = Path.Combine(uploadPath, uniqueFileName);

                    using (var fileStream = new FileStream(fullPath, FileMode.Create))
                    {
                        await quill.ImageFile.CopyToAsync(fileStream);
                    }
                }

                _context.Add(quill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quill);
        }

        // GET: Quills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Quill == null)
            {
                return NotFound();
            }

            var quill = await _context.Quill.FindAsync(id);

            if (quill == null)
            {
                return NotFound();
            }

            return View(quill);
        }

        // POST: Quills/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Material,Ratings,SizeFit,Color,Price,ImageFile,ImagePath")] Quill quill)
        {
            if (id != quill.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Handle image upload
                    if (quill.ImageFile != null)
                    {
                        string uploadPath = Path.Combine(_hostEnvironment.WebRootPath, "images");

                        // Ensure the directory exists
                        if (!Directory.Exists(uploadPath))
                        {
                            Directory.CreateDirectory(uploadPath);
                        }

                        string fileName = Path.GetFileNameWithoutExtension(quill.ImageFile.FileName);
                        string extension = Path.GetExtension(quill.ImageFile.FileName);
                        string uniqueFileName = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;
                        quill.ImagePath = Path.Combine("images", uniqueFileName);
                        string fullPath = Path.Combine(uploadPath, uniqueFileName);

                        using (var fileStream = new FileStream(fullPath, FileMode.Create))
                        {
                            await quill.ImageFile.CopyToAsync(fileStream);
                        }
                    }

                    _context.Update(quill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuillExists(quill.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(quill);
        }

        // GET: Quills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Quill == null)
            {
                return NotFound();
            }

            var quill = await _context.Quill.FirstOrDefaultAsync(m => m.Id == id);

            if (quill == null)
            {
                return NotFound();
            }

            return View(quill);
        }

        // POST: Quills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Quill == null)
            {
                return Problem("Entity set 'Quill_Lite_AppContext.Quill' is null.");
            }

            var quill = await _context.Quill.FindAsync(id);

            if (quill != null)
            {
                _context.Quill.Remove(quill);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool QuillExists(int id)
        {
            return _context.Quill.Any(e => e.Id == id);
        }
    }
}
