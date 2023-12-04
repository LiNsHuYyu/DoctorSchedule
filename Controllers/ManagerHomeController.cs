using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoctorSchedule.Models;

public class ManagerHomeController : Controller
{
    public IActionResult Index()
    {
        // 假設這是從資料庫或其他來源獲取的數據
        var currentPhase = "xx階段";
        var deadline = DateTime.Now.AddDays(10).ToString("yyyy/MM/dd"); // 例如，10天後

        ViewData["CurrentPhase"] = currentPhase;
        ViewData["Deadline"] = deadline;

        return View();
    }

}