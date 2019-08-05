handlers.getHome = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/home/home.hbs');
        });
};