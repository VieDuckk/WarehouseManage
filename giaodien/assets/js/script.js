document.addEventListener('DOMContentLoaded', function() {
      const sidebarToggle = document.getElementById('sidebarToggle');
      const sidebar = document.getElementById('sidebar');
      console.log(sidebarToggle,sidebar )
  
      sidebarToggle.addEventListener('click', function() {
          sidebar.classList.toggle('warehouse__sidebar--hidden');
      });
  });

