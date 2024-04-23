using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using opticron_clone.Data;
using opticron_clone.Models;

namespace opticron_clone.App_Data
{
    public class FeatureController : Controller
    {
        private readonly FeatureModelContext _context;

        public FeatureController(FeatureModelContext context)
        {
            _context = context;
        }

        // GET: Feature
        public async Task<IActionResult> Index()
        {
            ViewData["OSectionTitle"] = "Special Offers";
            ViewData["OfferButton"] = "View Offers";
            ViewData["CatagoryTitle"] = "Product Catagories";
            return View(await _context.FeatureModel.ToListAsync());
        }

        // List features
        public async Task<IActionResult> List()
        {
            return View(await _context.FeatureModel.ToListAsync());
        }

        // GET: Feature/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var featureModel = await _context.FeatureModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (featureModel == null)
            {
                return NotFound();
            }

            return View(featureModel);
        }

        // GET: Feature/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feature/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImageSrc,Description,FBtnText")] FeatureModel featureModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(featureModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(featureModel);
        }

        // GET: Feature/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var featureModel = await _context.FeatureModel.FindAsync(id);
            if (featureModel == null)
            {
                return NotFound();
            }
            return View(featureModel);
        }

        // POST: Feature/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImageSrc,Description,FBtnText")] FeatureModel featureModel)
        {
            if (id != featureModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(featureModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeatureModelExists(featureModel.Id))
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
            return View(featureModel);
        }

        // GET: Feature/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var featureModel = await _context.FeatureModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (featureModel == null)
            {
                return NotFound();
            }

            return View(featureModel);
        }

        // POST: Feature/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var featureModel = await _context.FeatureModel.FindAsync(id);
            if (featureModel != null)
            {
                _context.FeatureModel.Remove(featureModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeatureModelExists(int id)
        {
            return _context.FeatureModel.Any(e => e.Id == id);
        }
    }
}
