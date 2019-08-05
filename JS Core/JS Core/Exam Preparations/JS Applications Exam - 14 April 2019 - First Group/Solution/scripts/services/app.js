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

       this.get('#/organize', handlers.getOrganize);
       this.post('#/organize', handlers.createEvent);
       this.get('#/events/:id', handlers.getEventDetails);
       this.get('#/join/:id', handlers.joinEvent);
       this.get('#/edit/:id', handlers.getEdit);
       this.post('#/edit/:id', handlers.editEvent);
       this.get('#/remove/:id', handlers.deleteEvent);
   });

    app.run();
});