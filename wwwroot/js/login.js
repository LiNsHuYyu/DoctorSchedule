document.addEventListener("DOMContentLoaded", function() {
    var managerLoginBtn = document.getElementById("managerLoginBtn");
    var doctorLoginBtn = document.getElementById("doctorLoginBtn");

    managerLoginBtn.addEventListener("click", function() {
        var userInput = document.getElementById("managerUserInput").value;
        if(userInput) {
            window.location.href = "/ManagerHome/Index"; // 跳轉到管理者主頁
        }
    });

    doctorLoginBtn.addEventListener("click", function() {
        var userInput = document.getElementById("doctorUserInput").value;
        if(userInput) {
            window.location.href = "/DoctorHome/Index"; // 跳轉到醫師主頁
        }
    });
});
