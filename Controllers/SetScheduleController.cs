using DoctorSchedule.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DoctorSchedule.Controllers {
    public class SetScheduleController : Controller {
        private readonly DBManager _dbManager;

        public SetScheduleController() {
            _dbManager = new DBManager();
        }

        public IActionResult Index(string subdepartment) {
            int departmentId = ConvertSubdepartmentToId(subdepartment); // 轉換 subdepartment 為對應的 departmentId
            List<Doctor> doctors = _dbManager.GetDoctorsByDepartment(departmentId);
            return View(doctors); // 將醫生列表傳遞給視圖
        }

        private int ConvertSubdepartmentToId(string subdepartment) {
            // 這裡加入將 subdepartment 字串轉換為 departmentId 的邏輯
            if (subdepartment == "神經外科") return 11;
            // ...其他 subdepartment 的轉換
            return 0;
        }
    }
}
