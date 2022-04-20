using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP2084_Project_200478377.Data;
using COMP2084_Project_200478377.Models;

namespace COMP2084_Project_200478377.Controllers
{
    public class DeliveryDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveryDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DeliveryDetail.Include(d => d.BillID).Include(d => d.CustomerID);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DeliveryDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryDetail = await _context.DeliveryDetail
                .Include(d => d.BillID)
                .Include(d => d.CustomerID)
                .FirstOrDefaultAsync(m => m.DeliveryId == id);
            if (deliveryDetail == null)
            {
                return NotFound();
            }

            return View(deliveryDetail);
        }

        // GET: DeliveryDetails/Create
        public IActionResult Create()
        {
            ViewData["BillId"] = new SelectList(_context.BillDetail, "BillId", "BillId");
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
            return View();
        }

        // POST: DeliveryDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeliveryId,ShippingAddress,OrderDate,DeliveryDate,BillId,CustomerId")] DeliveryDetail deliveryDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BillId"] = new SelectList(_context.BillDetail, "BillId", "BillId", deliveryDetail.BillId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", deliveryDetail.CustomerId);
            return View(deliveryDetail);
        }

        // GET: DeliveryDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryDetail = await _context.DeliveryDetail.FindAsync(id);
            if (deliveryDetail == null)
            {
                return NotFound();
            }
            ViewData["BillId"] = new SelectList(_context.BillDetail, "BillId", "BillId", deliveryDetail.BillId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", deliveryDetail.CustomerId);
            return View(deliveryDetail);
        }

        // POST: DeliveryDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeliveryId,ShippingAddress,OrderDate,DeliveryDate,BillId,CustomerId")] DeliveryDetail deliveryDetail)
        {
            if (id != deliveryDetail.DeliveryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryDetailExists(deliveryDetail.DeliveryId))
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
            ViewData["BillId"] = new SelectList(_context.BillDetail, "BillId", "BillId", deliveryDetail.BillId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", deliveryDetail.CustomerId);
            return View(deliveryDetail);
        }

        // GET: DeliveryDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryDetail = await _context.DeliveryDetail
                .Include(d => d.BillID)
                .Include(d => d.CustomerID)
                .FirstOrDefaultAsync(m => m.DeliveryId == id);
            if (deliveryDetail == null)
            {
                return NotFound();
            }

            return View(deliveryDetail);
        }

        // POST: DeliveryDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryDetail = await _context.DeliveryDetail.FindAsync(id);
            _context.DeliveryDetail.Remove(deliveryDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryDetailExists(int id)
        {
            return _context.DeliveryDetail.Any(e => e.DeliveryId == id);
        }
    }
}
