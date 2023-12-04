using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoctorSchedule.Models;

public class DoctorHomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}