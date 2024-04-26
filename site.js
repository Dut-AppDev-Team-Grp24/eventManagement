// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Buttons declarations
const buyTicketBtn = document.getElementById("buy-ticket-btn");
const editEventBtn = document.getElementById("edit-event-btn");
const cancelEventBtn = document.getElementById("cancel-event-btn");
const dropdownButton = document.getElementById('dropdownButton');


if (buyTicketBtn != null) {
    //event Listerners
    buyTicketBtn.addEventListener("click",
        function () {
            var id = document.getElementById("event-id").value;
            window.location.href = "Tickets/Buy/" + id;
        }
    );
}


if (editEventBtn != null) {
    editEventBtn.addEventListener("click",
        function () {
            var id = document.getElementById("event-id").value;
            window.location.href = "/Events/Edit/" + id;
        }
    );
}

if (cancelEventBtn != null) {
    cancelEventBtn.addEventListener("click",
        function () {
            var id = document.getElementById("event-id").value;
            fetch("/Events/ConfirmCancel/" + id, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({ id: id })
            })
            .then(response => {
                if (response.ok) {
                  // Redirect to the desired URL
                  window.location.href = '/Home/EventManagerHome';
                } else {
                  // Handle error response
                  throw new Error('Failed to cancel event');
                }
              })
              .catch(error => {
                console.error(error);
                // Handle error
              }
            );
        }
    )
}

if (dropdownButton != null) {

    // Add click event listener to toggle the dropdown menu
    dropdownButton.addEventListener('click', function () {
        const dropdownMenu = this.nextElementSibling; // Get the dropdown menu next to the button
        const isExpanded = this.getAttribute('aria-expanded') === 'true'; // Check if the dropdown is currently expanded

        // Toggle the aria-expanded attribute and show/hide the dropdown menu
        this.setAttribute('aria-expanded', !isExpanded);
        dropdownMenu.style.display = isExpanded ? 'none' : 'block';
    });
}