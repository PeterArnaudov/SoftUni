const handlers = {};

$(() => {
   const app = Sammy('#root', function () {
       this.use('Handlebars', 'hbs');
       this.get('/index.html', handlers.getHome);

       this.get('#/home', handlers.getHome);
       this.get('#/register', handlers.getRegister);
       this.get('#/login', handlers.getLogin);

       this.post('#/login', handlers.loginUser);
       this.post('#/register', handlers.registerUser);
       this.get('#/logout', handlers.logoutUser);

       this.post('#/posts/delete/:id', handlers.deletePost);
   });

    app.run();
});