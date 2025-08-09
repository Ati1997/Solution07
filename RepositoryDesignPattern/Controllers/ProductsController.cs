using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.ApplicationServices.Services.Contracts;
using RepositoryDesignPattern.Models.DomainModels.ProductAggregates;
using RepositoryDesignPattern.Sample01.Models.Services;

namespace RepositoryDesignPattern.Controllers
{
    public class ProductsController : Controller
    {
        //ye aggre az iproductappservice be onvan service dahande
        private readonly IProductApplicationService _productApplicationService;

        public ProductsController(IProductApplicationService productApplicationService)
        {
            _productApplicationService = productApplicationService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productApplicationService.GetAll();
            return View(products);
        }


    }
}

//        // GET: Products
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Product.ToListAsync());
//        }

//        // GET: Products/Details/5
//        public async Task<IActionResult> Details(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var product = await _context.Product
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (product == null)
//            {
//                return NotFound();
//            }

//            return View(product);
//        }

//        // GET: Products/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Products/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Title,Quantity,Price")] Product product)
//        {
//            if (ModelState.IsValid)
//            {
//                product.Id = Guid.NewGuid();
//                _context.Add(product);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(product);
//        }

//        // GET: Products/Edit/5
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var product = await _context.Product.FindAsync(id);
//            if (product == null)
//            {
//                return NotFound();
//            }
//            return View(product);
//        }

//        // POST: Products/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Quantity,Price")] Product product)
//        {
//            if (id != product.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(product);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ProductExists(product.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(product);
//        }

//        // GET: Products/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var product = await _context.Product
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (product == null)
//            {
//                return NotFound();
//            }

//            return View(product);
//        }

//        // POST: Products/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            var product = await _context.Product.FindAsync(id);
//            if (product != null)
//            {
//                _context.Product.Remove(product);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ProductExists(Guid id)
//        {
//            return _context.Product.Any(e => e.Id == id);
//        }
//    }
//}
