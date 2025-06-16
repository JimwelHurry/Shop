// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// thank you for subscribing to our newsletter

document
  .querySelector('form[action="/Newsletter/Subscribe"]')
  .addEventListener("submit", function (event) {
    event.preventDefault(); // prevent default form submission for demo

    // Here you would normally do your AJAX call or form submission.
    // For demo, we just show the toast

    // Show toast
    var toastEl = document.getElementById("subscribeToast");
    var toast = new bootstrap.Toast(toastEl);
    toast.show();

    // Optionally clear the input
    this.reset();

    // If you want to actually submit, remove event.preventDefault() and handle server response to trigger toast
  });

// Countdown timer for daily deals

const end = new Date();
end.setHours(23, 59, 59); // Today 11:59 PM
const countdownEl = document.getElementById("countdown");

function updateTimer() {
  const now = new Date();
  const diff = end - now;

  if (diff <= 0) {
    countdownEl.textContent = "Deal ended!";
    return;
  }

  const hrs = String(Math.floor(diff / (1000 * 60 * 60))).padStart(2, "0");
  const mins = String(Math.floor((diff / (1000 * 60)) % 60)).padStart(2, "0");
  const secs = String(Math.floor((diff / 1000) % 60)).padStart(2, "0");

  countdownEl.textContent = `${hrs}:${mins}:${secs}`;
}

updateTimer();
setInterval(updateTimer, 1000);
