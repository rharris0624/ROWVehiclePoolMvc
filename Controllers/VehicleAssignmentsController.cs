using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RowVehiclePoolMVC.Context;
using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.ViewModels;
using RowVehiclePoolMVC.Utilities;

namespace RowVehiclePoolMVC.Controllers
{
    public class VehicleAssignmentsController : Controller
    {
        private readonly RvpAppContext _context;

        public VehicleAssignmentsController(RvpAppContext context)
        {
            _context = context;
        }

        // GET: VehicleAssignments
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehicleAssignment.ToListAsync());
        }

        // GET: VehicleAssignments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleAssignment = await _context.VehicleAssignment
                .FirstOrDefaultAsync(m => m.VehReqNo == id);
            if (vehicleAssignment == null)
            {
                return NotFound();
            }

            return View(vehicleAssignment);
        }

        // GET: VehicleAssignments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleAssignments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehReqNo,AssignNo,AssignTagNo,AssignDepartDate,AssignReturnDate,Comments")] VehicleAssignment vehicleAssignment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleAssignment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleAssignment);
        }

        [HttpGet]
        public IActionResult VehicleAssigned(int id) 
        {
            var vehicleRequisition = _context.VehicleRequisition.Where(c => c.VehReqNo == id).FirstOrDefault();
            return View(vehicleRequisition); 
        }

        // GET: VehicleAssignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var vehicleAssignmentVM = new VehicleAssignmentVM();

            if (id == null)
            {
                return NotFound();
            }

            var vehicleAssignment = await _context.VehicleAssignment.Where(c=>c.VehReqNo.Equals(id)).FirstOrDefaultAsync();
            if (vehicleAssignment == null)
            {
                return NotFound();
            }
            vehicleAssignmentVM.VehicleAssignment = vehicleAssignment;
            vehicleAssignmentVM.VehicleWeek = Utility.GetVehicleWeek(_context, vehicleAssignment.AssignDepartDate.ToString("yyyyMMdd"));
            return View(vehicleAssignmentVM);
        }

        // POST: VehicleAssignments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehReqNo,AssignNo,AssignTagNo,AssignDepartDate,AssignReturnDate,Comments")] VehicleAssignment vehicleAssignment)
        {
            if (id != vehicleAssignment.VehReqNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleAssignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleAssignmentExists(vehicleAssignment.VehReqNo))
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
            return View(vehicleAssignment);
        }

        // GET: VehicleAssignments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleAssignment = await _context.VehicleAssignment
                .FirstOrDefaultAsync(m => m.VehReqNo == id);
            if (vehicleAssignment == null)
            {
                return NotFound();
            }

            return View(vehicleAssignment);
        }

        // POST: VehicleAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleAssignment = await _context.VehicleAssignment.FindAsync(id);
            _context.VehicleAssignment.Remove(vehicleAssignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleAssignmentExists(int id)
        {
            return _context.VehicleAssignment.Any(e => e.VehReqNo == id);
        }
    }
}
