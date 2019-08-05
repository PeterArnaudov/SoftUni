const handlers = {};

$(() => {
    $('#infoBox').click(e => $(e.target).hide());
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

       this.get('#/cinema', handlers.getCinema);
       this.get('#/movies/:id', handlers.getMovieDetails);
       this.get('#/buy/:id', handlers.buyTicket);
       this.get('#/addMovie', handlers.getAddMovie);
       this.post('#/addMovie', handlers.createMovie);
       this.get('#/edit/:id', handlers.getEdit);
       this.post('#/edit/:id', handlers.editMovie);
       this.get('#/myMovies', handlers.getMyMovies);
       this.get('#/buy/:id', handlers.buyTicket);
       this.get('#/delete/:id', handlers.getDelete);
       this.post('#/delete/:id', handlers.deleteMovie);

       this.get('#/cinema/', handlers.getSearchedMovies);
   });

    app.run();
});