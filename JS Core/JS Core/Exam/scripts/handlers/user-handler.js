handlers.getRegister = function (context) {
    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs',
        registerForm: 'templates/register/registerForm.hbs'
    })
        .then(function () {
            this.partial('templates/register/registerPage.hbs');
        });
};

handlers.getLogin = function (context) {
    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs',
        loginForm: 'templates/login/loginForm.hbs'
    })
        .then(function () {
            this.partial('templates/login/loginPage.hbs');
        });
};

handlers.registerUser = function (context) {
    let username = context.params.username;
    let password = context.params.password;
    let repeatPassword = context.params.rePassword;

    if (password !== repeatPassword) {
        notifications.showError("Passwords must match!");
        return;
    }

    userService.register(username, password)
        .then((response) => {
            userService.saveSession(response);
            notifications.showSuccess("User registered successfully!");
            context.redirect('#/home');
        })
        .catch(function (error) {
            notifications.showError(error.responseJSON.description);
        });
};

handlers.loginUser = function (context) {
    let username = context.params.username;
    let password = context.params.password;

    userService.login(username, password)
        .then(function (response) {
            userService.saveSession(response);
            notifications.showSuccess("User logged in successfully!");
            context.redirect('#/home');
        })
        .catch(function (error) {
            notifications.showError(error.responseJSON.description);
        });
};

handlers.logoutUser = function (context) {
  userService.logout()
      .then(function () {
          sessionStorage.clear();
          notifications.showSuccess("User logged out successfully!");
          context.redirect('#/home');
      })
      .catch(function (error) {
          notifications.showError(error.responseJSON.description);
      });
};