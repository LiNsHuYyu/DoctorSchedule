using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoctorSchedule.Models;

public class SetDocsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}