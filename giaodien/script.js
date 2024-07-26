document.addEventListener('DOMContentLoaded', function() {
      const sidebarToggle = document.getElementById('sidebarToggle');
      const sidebar = document.getElementById('sidebar');
      console.log(sidebarToggle,sidebar )
  
      sidebarToggle.addEventListener('click', function() {
          sidebar.classList.toggle('warehouse__sidebar--hidden');
      });
  });
  //cap nhat ngay gio tu dong
  document.addEventListener("DOMContentLoaded", function() {
    var now = new Date();
    var day = String(now.getDate()).padStart(2, '0');
    var month = String(now.getMonth() + 1).padStart(2, '0');
    var year = now.getFullYear();
    var hours = String(now.getHours()).padStart(2, '0');
    var minutes = String(now.getMinutes()).padStart(2, '0');
    var currentDate = `${day}/${month}/${year} - ${hours}:${minutes}`;
    document.getElementById("activity").textContent = `Hoạt động trong ngày (${currentDate})`;
});
