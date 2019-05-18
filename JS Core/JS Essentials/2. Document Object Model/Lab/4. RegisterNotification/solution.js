 function register() {
     let usernameElement = document.getElementById('username');
     let usernameElementValue = usernameElement.value;

     let emailElement = document.getElementById('email');
     let emailElementValue = emailElement.value;

     let passwordElement = document.getElementById('password');
     let passwordElementValue = passwordElement.value;

     if (usernameElementValue && emailElementValue.match(/(.+)@(.+).(com|bg)/gm) && passwordElementValue) {
         let notificationHeader = document.createElement('h1');
         notificationHeader.textContent = 'Successful Registration!';

         let notificationBodyUsername = document.createDocumentFragment();
         notificationBodyUsername.textContent = `Username: ${usernameElementValue}`;

         let notificationBodyEmail = document.createDocumentFragment();
         notificationBodyEmail.textContent = `Email: ${emailElementValue}`;

         let notificationBodyPassword = document.createDocumentFragment();
         notificationBodyPassword.textContent = `Password: ${'*'.repeat(passwordElementValue.length)}`;

         let result = document.getElementById('result');

         result.appendChild(notificationHeader);
         result.appendChild(notificationBodyUsername);
         result.appendChild(document.createElement('BR'));
         result.appendChild(notificationBodyEmail);
         result.appendChild(document.createElement('BR'));
         result.appendChild(notificationBodyPassword);

         setTimeout(function() {
             while (result.firstChild) {
                 result.removeChild(result.firstChild);
             }
         }, 5000);

         //setTimeout(() => { result.style.visibility = 'hidden'; }, 5000);
     }
 }