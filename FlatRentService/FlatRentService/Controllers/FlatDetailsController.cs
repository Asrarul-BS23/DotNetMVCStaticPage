using FlatRentService.Data;
using FlatRentService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlatRentService.Controllers;

public class FlatDetailsController : Controller
{
    private readonly FlatDbContext _context;
    public FlatDetailsController(FlatDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var flat = await _context.FlatDetails.ToListAsync();
        return View(flat);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Id, Location, BuildingName, BuildingNumber, Floor, NumberOfBedRoom, NumberOfBathRoom, FlatSize, IsLiftAvailable")] FlatDetails flatDetails)
    {
        if(ModelState.IsValid)
        {
            _context.FlatDetails.Add(flatDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(flatDetails);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var flatDetails = await _context.FlatDetails.FirstOrDefaultAsync(x => x.Id == id);
        return View(flatDetails);
    }
}