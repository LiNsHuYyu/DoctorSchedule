document.addEventListener('DOMContentLoaded', function() {
    var urlParams = new URLSearchParams(window.location.search);
    var subdepartment = urlParams.get('subdepartment');
    var ward = urlParams.get('ward');

    // 這裡顯示這些選項
    document.getElementById('selected-subdepartment').textContent = subdepartment;
    document.getElementById('selected-ward').textContent = ward;
});

document.addEventListener('click', function(event) {
    if (event.target.classList.contains('btn-add-date')) {
        var newDateInput = document.createElement('input');
        newDateInput.type = 'date';
        var buttonContainer = event.target.parentNode; // 按鈕的父容器，例如 td 元素
        buttonContainer.insertBefore(newDateInput, event.target); // 在按鈕之前插入
    }
});

