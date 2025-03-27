using FlatRentService.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlatRentService.Controllers;

public class FlatDetailsController : Controller
{
    // GET
    public IActionResult FlatView()
    {
        var flat = new FlatDetails(){Location="Banasree Dhaka", BuildingName="Golden Palace",BuildingNumber="63-A",Floor=6,NumberOfBedRoom=3,NumberOfBathRoom=3,FlatSize=1350,IsLiftAvailable = true};
        return View(flat);
    }
}