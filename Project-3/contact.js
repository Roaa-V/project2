// Firebase configuration

const firebaseURL = "https://fitness-contact-api-default-rtdb.firebaseio.com/contacts.json";


document.getElementById("contactForm").addEventListener("submit", function(e) {
  e.preventDefault();

  const name = document.getElementById("name").value;
  const email = document.getElementById("email").value;
  const message = document.getElementById("message").value;

  fetch(firebaseURL, {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify({
      name: name,
      email: email,
      message: message,
      date: new Date().toLocaleString()
    })
  })
  .then(response => {
    if (response.ok) {
      document.getElementById("status").innerText = "Message sent successfully ✅";
      document.getElementById("contactForm").reset();
    } else {
      throw new Error("Error");
    }
  })
  .catch(() => {
    document.getElementById("status").innerText = "Failed to send message ❌";
  });
});