const loginForm = document.querySelector('#login-form');

loginForm.addEventListener('submit', async (event) => {
  event.preventDefault();

  const username = document.querySelector('#username').value;
  const password = document.querySelector('#password').value;

  const response = await fetch('/api/admin', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json'
    },
    body: JSON.stringify({
      username: username,
      password: password
    })
  });

  if (response.ok) {
    // Login successful, redirect to home page
    window.location.href = '/home';
  } else {
    window.location.href = "/"
    // Login failed, show error message
    const errorMessage = await response.text();
    alert(`Login failed: ${errorMessage}`);
  }
});
