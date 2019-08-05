handlers.getHome = function (context) {
    context.isAuth = userService.isAuth();

    if (!userService.isAuth()) {
        context.loadPartials({
            header: 'templates/common/header.hbs',
            footer: 'templates/common/footer.hbs'
        })
            .then(function () {
                this.partial('templates/home/home.hbs');
            });
    }
    else {
        context.username = sessionStorage.getItem('username');

        recipeService.getAllRecipes()
            .then(function (recipes) {
                context.recipes = recipes;
                context.anyRecipes = recipes.length !== 0;

                context.loadPartials({
                    header: 'templates/common/header.hbs',
                    footer: 'templates/common/footer.hbs',
                    recipes: 'templates/recipes/recipesCollection.hbs',
                    recipe: 'templates/recipes/recipe.hbs'
                })
                    .then(function () {
                        this.partial('templates/home/home.hbs');
                    });
            });
    }
};