handlers.getShare = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/recipes/shareRecipe.hbs');
        });
};

handlers.getRecipeDetails = function (context) {
    let id = context.params.id.replace(':', '');
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    recipeService.getRecipe(id)
        .then(function (result) {
            context.meal = result.meal;
            context.foodImageURL = result.foodImageURL;
            context.description = result.description;
            context.prepMethod = result.prepMethod;
            context.ingredients = result.ingredients;
            context.likes = result.likes;
            context.id = result._id;
            context.isPublisher = result._acl.creator === sessionStorage.getItem('userID');

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/recipes/recipeDetails.hbs');
                });
        });
};

handlers.likeRecipe = function (context) {
    let id = context.params.id.replace(':', '');

    recipeService.getRecipe(id)
        .then(function (data) {
            let editedData = {
                _id: id,
                categoryImageURL: data.categoryImageURL,
                category: data.category,
                foodImageURL: data.foodImageURL,
                description: data.description,
                prepMethod: data.prepMethod,
                ingredients: data.ingredients,
                meal: data.meal,
                likes: +data.likes + 1
            };

            recipeService.editRecipe(editedData)
                .then(function () {
                    notifications.showSuccess('You liked that recipe.');
                    context.redirect('#/home');
                })
        });
};

handlers.getEdit = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');
    let id = context.params.id.replace(':', '');

    recipeService.getRecipe(id)
        .then(function (result) {
            context.id = id;
            context.meal = result.meal;
            context.ingredients = result.ingredients;
            context.prepMethod = result.prepMethod;
            context.description = result.description;
            context.foodImageURL = result.foodImageURL;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/recipes/editRecipe.hbs');
                });
        });
};

handlers.editRecipe = function (context) {
    let id = context.params.id.replace(':', '');

    recipeService.getRecipe(id)
        .then(function (data) {
            if (context.params.meal.length < 4) {
                notifications.showError('Meal name has to be at least 4 symbols long!');
            }
            else if (context.params.ingredients.length < 2) {
                notifications.showError('Ingredients have to be at least 2!');
            }
            else if (context.params.prepMethod.length < 10) {
                notifications.showError('Preparation method should be at least 10 symbols long!');
            }
            else if (context.params.description.length < 10) {
                notifications.showError('Recipe description should be at least 10 symbols long!');
            }
            else if (!context.params.foodImageURL.match('https*:\\/\\/')) {
                notifications.showError('Image URL should start with http://... or https://...');
            }
            else if (context.params.category === 'Select category...') {
                notifications.showError('Please select a category!');
            }
            else {
                if (context.params.category === 'Vegetables and legumes/beans') {
                    data.categoryImageURL = "https://cdn.pixabay.com/photo/2017/10/09/19/29/eat-2834549__340.jpg";
                }
                else if (context.params.category === 'Grain Food') {
                    data.categoryImageURL = "https://cdn.pixabay.com/photo/2014/12/11/02/55/corn-syrup-563796__340.jpg";
                }
                else if (context.params.category === 'Fruits') {
                    data.categoryImageURL = "https://cdn.pixabay.com/photo/2017/06/02/18/24/fruit-2367029__340.jpg";
                }
                else if (context.params.category === 'Milk, cheese, eggs and alternatives') {
                    data.categoryImageURL = "https://image.shutterstock.com/image-photo/assorted-dairy-products-milk-yogurt-260nw-530162824.jpg";
                }
                else if (context.params.category === 'Lean meats and poultry, fish and alternatives') {
                    data.categoryImageURL = "https://t3.ftcdn.net/jpg/01/18/84/52/240_F_118845283_n9uWnb81tg8cG7Rf9y3McWT1DT1ZKTDx.jpg";
                }

                let editedData = {
                    _id: id,
                    categoryImageURL: context.params.categoryImageURL,
                    category: context.params.category,
                    foodImageURL: context.params.foodImageURL,
                    description: context.params.description,
                    prepMethod: context.params.prepMethod,
                    ingredients: context.params.ingredients,
                    meal: context.params.meal,
                    likes: context.params.likes
                };

                recipeService.editRecipe(editedData)
                    .then(function () {
                        notifications.showSuccess('Recipe edited successfully!');
                        context.redirect('#/home');
                    })
            }
        });
};

handlers.shareRecipe = function (context) {
    let meal = context.params.meal;
    let ingredients = context.params.ingredients.split(' ');
    let prepMethod = context.params.prepMethod;
    let description = context.params.description;
    let category = context.params.category;
    let foodImageURL = context.params.foodImageURL;
    let categoryImageURL = '';
    let likes = 0;

    if (meal.length < 4) {
        notifications.showError('Meal name has to be at least 4 symbols long!');
    }
    else if (ingredients.length < 2) {
        notifications.showError('Ingredients have to be at least 2!');
    }
    else if (prepMethod.length < 10) {
        notifications.showError('Preparation method should be at least 10 symbols long!');
    }
    else if (description.length < 10) {
        notifications.showError('Recipe description should be at least 10 symbols long!');
    }
    else if (!foodImageURL.match('https*:\\/\\/')) {
        notifications.showError('Image URL should start with http://... or https://...');
    }
    else if (category === 'Select category...') {
        notifications.showError('Please select a category!');
    }
    else {
        if (category === 'Vegetables and legumes/beans') {
            categoryImageURL = "https://cdn.pixabay.com/photo/2017/10/09/19/29/eat-2834549__340.jpg";
        }
        else if (category === 'Grain Food') {
            categoryImageURL = "https://cdn.pixabay.com/photo/2014/12/11/02/55/corn-syrup-563796__340.jpg";
        }
        else if (category === 'Fruits') {
            categoryImageURL = "https://cdn.pixabay.com/photo/2017/06/02/18/24/fruit-2367029__340.jpg";
        }
        else if (category === 'Milk, cheese, eggs and alternatives') {
            categoryImageURL = "https://image.shutterstock.com/image-photo/assorted-dairy-products-milk-yogurt-260nw-530162824.jpg";
        }
        else if (category === 'Lean meats and poultry, fish and alternatives') {
            categoryImageURL = "https://t3.ftcdn.net/jpg/01/18/84/52/240_F_118845283_n9uWnb81tg8cG7Rf9y3McWT1DT1ZKTDx.jpg";
        }

        let data = {
            meal,
            ingredients,
            prepMethod,
            description,
            category,
            foodImageURL,
            categoryImageURL,
            likes
        };

        recipeService.createRecipe(data)
            .then(function () {
                notifications.showSuccess('Recipe added successfully!');
                context.redirect('#/home');
            })
    }
};

handlers.archiveRecipe = function (context) {
    let id = context.params.id.replace(':', '');

    recipeService.archiveRecipe(id)
        .then(function () {
            notifications.showSuccess('Your recipe was archived.');
            context.redirect('#/home');
        })
};