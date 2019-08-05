const handlers = {};

$(() => {
    $('#errorBox').click(e => $(e.target).hide());
});

$(() => {
   const app = Sammy('#root', function () {
       this.use('Handlebars', 'hbs');
       this.get('/index.html', handlers.getHome);

       this.get('#/home', handlers.getHome);
       this.get('#/register', handlers.getRegister);
       this.get('#/login', handlers.getLogin);
       this.get('#/user', handlers.getUser);

       this.post('#/login', handlers.loginUser);
       this.post('#/register', handlers.registerUser);
       this.get('#/logout', handlers.logoutUser);

       this.get('#/createOffer', handlers.getCreate);
       this.post('#/createOffer', handlers.createOffer);
       this.get('#/dashboard', handlers.getDashboard);
       this.get('#/edit/:id', handlers.getEdit);
       this.post('#/edit/:id', handlers.editOffer);
       this.get('#/delete/:id', handlers.getDelete);
       this.post('#/delete/:id', handlers.deleteOffer);
       this.get('#/details/:id', handlers.getOfferDetails);

       this.get('#/offers/:id', handlers.getEventDetails);
       this.get('#/join/:id', handlers.joinEvent);

       this.get('#/remove/:id', handlers.deleteEvent);
   });

    app.run();
});