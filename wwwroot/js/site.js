document.addEventListener("DOMContentLoaded", () => {
    const rows = document.querySelectorAll(".table tbody tr");
    rows.forEach((row, index) => {
        row.style.setProperty('--i', index);
    });
});
    let deleteUrl = "";

    function showDeleteModal(url) {
        deleteUrl = url;
    document.getElementById("deleteModal").style.display = "block";
    }

    function closeModal() {
        document.getElementById("deleteModal").style.display = "none";
    }

    function confirmDelete() {
        window.location.href = deleteUrl;
    }


var nameElement = document.getElementsByClassName("name")[0]; // الحصول على العنصر
var nameText = nameElement.textContent; // الحصول على النص من العنصر

if (nameText.length > 20) {
    nameText = nameText.slice(0, 20) + "..."; // تقصير النص وإضافة "...”
    nameElement.textContent = nameText; // تحديث محتوى العنصر
}

function showDeleteModal(url) {
    const modal = document.getElementById('deleteModal');
    modal.style.display = 'block';
    window.deleteUrl = url;
}

function closeModal() {
    document.getElementById('deleteModal').style.display = 'none';
}

function confirmDelete() {
    window.location.href = window.deleteUrl;
}

window.onclick = function (event) {
    const modal = document.getElementById('deleteModal');
    if (event.target === modal) {
        modal.style.display = 'none';
    }
}

function showLoader() {
    document.querySelector('.loader').style.display = 'block';
}

function hideLoader() {
    document.querySelector('.loader').style.display = 'none';
}

// Example: Before AJAX call
showLoader();

// After AJAX data loaded
hideLoader();
