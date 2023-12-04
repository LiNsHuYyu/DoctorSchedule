// 假設今天是 2023 年 11 月
const year = 2023;
const month = 10; // JavaScript 的月份是從 0 開始的，所以 10 代表 11 月

// 獲取當月第一天是星期幾 (0-6)
const firstDay = new Date(year, month, 1).getDay();

// 獲取當月有多少天
const daysInMonth = new Date(year, month + 1, 0).getDate();

// 創建月曆的 HTML
let calendarHTML = "<tr>";
for (let i = 0; i < firstDay; i++) {
    calendarHTML += "<td></td>"; // 當月第一天之前的空白日期
}

for (let day = 1; day <= daysInMonth; day++) {
    if ((day + firstDay - 1) % 7 === 0) {
        calendarHTML += "</tr><tr>"; // 每週開始新的一行
    }
    calendarHTML += `<td>${day}</td>`; // 當月的日期
}

calendarHTML += "</tr>";

// 將生成的 HTML 添加到月曆的 tbody
document.querySelector('.calendar tbody').innerHTML = calendarHTML;
