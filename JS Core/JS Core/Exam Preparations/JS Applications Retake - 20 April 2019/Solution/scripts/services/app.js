const handlers = {};

$(() => {
    $('#infoBox').click(e => $(e.target).hide());
    $('#errorBox').click(e => $(e.target).hide());
});

$(() => {
   const app = Sammy('#rooter', function () {
       this.use('Handlebars', 'hbs');
       this.get('/index.html', handlers.getHome);

       this.get('#/home', handlers.getHome);
       this.get('#/register', handlers.getRegister);
       this.get('#/login', handlers.getLogin);

       this.post('#/login', handlers.loginUser);
       this.post('#/register', handlers.registerUser);
       this.get('#/logout', handlers.logoutUser);

       this.get('#/share', handlers.getShare);
       this.post('#/share', handlers.shareRecipe);
       this.get('#/recipes/:id', handlers.getRecipeDetails);
       this.get('#/like/:id', handlers.likeRecipe);
       this.get('#/edit/:id', handlers.getEdit);
       this.post('#/edit/:id', handlers.editRecipe);
       this.get('#/archive/:id', handlers.archiveRecipe);
   });

    app.run();
});