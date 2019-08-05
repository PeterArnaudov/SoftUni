handlers.getCreate = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    context.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    })
        .then(function () {
            this.partial('templates/offers/createOffer.hbs');
        });
};

handlers.createOffer = function (context) {
    let product = context.params.product;
    let description = context.params.description;
    let pictureUrl = context.params.pictureUrl;
    let price = context.params.price;

    if (product.length < 6) {
        notifications.showError('Product name has to be at least 6 symbols long!');
    }
    else if (description.length < 10) {
        notifications.showError('Product description should be at least 10 symbols long!');
    }
    else if (!price.match('\\d+\\.*\\d*')) {
        notifications.showError('Product price should be a number!');
    }
    else if (!pictureUrl.match('https*:\\/\\/')) {
        notifications.showError('Image URL should start with http://... or https://...');
    }
    else {
        let data = {
            product,
            description,
            pictureUrl,
            price
        };

        offersService.createOffer(data)
            .then(function () {
                notifications.showSuccess('Offer created successfully!');
                context.redirect('#/dashboard');
            })
    }
};

handlers.getDashboard = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');

    offersService.getAllOffers()
        .then(function (data) {
            context.offers = data;
            context.anyOffers = data.length;

            for (let offer of data) {
                if (offer._acl.creator === sessionStorage.getItem('userID')) {
                    offer.isOwner = true;
                }
                else {
                    offer.isOwner = false;
                }
            }

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                offer: 'templates/offers/offer.hbs'
            })
                .then(function () {
                    this.partial('templates/offers/dashboard.hbs');
                });
        });

};

handlers.getOfferDetails = function (context) {
    let id = context.params.id.replace(':', '');
    offersService.getOffer(id)
        .then(function (result) {
            context.isAuth = userService.isAuth();
            context.username = sessionStorage.getItem('username');
            context.product = result.product;
            context.pictureUrl = result.pictureUrl;
            context.description = result.description;
            context.price = result.price;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/offers/detailsOffer.hbs');
                });
        });
};

handlers.getEdit = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');
    let id = context.params.id.replace(':', '');

    offersService.getOffer(id)
        .then(function (result) {
            context.id = id;
            context.product = result.product;
            context.description = result.description;
            context.price = result.price;
            context.pictureUrl = result.pictureUrl;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/offers/editOffer.hbs');
                });
        });
};

handlers.editOffer = function (context) {
    let id = context.params.id.replace(':', '');

    offersService.getOffer(id)
        .then(function (data) {
            if (context.params.product.length < 6) {
                notifications.showError('Product name has to be at least 6 symbols long!');
            }
            else if (context.params.description.length < 10) {
                notifications.showError('Product description should be at least 10 symbols long!');
            }
            else if (!context.params.price.match('\\d+\\.*\\d*')) {
                notifications.showError('Product price should be a number!');
            }
            else if (!context.params.pictureUrl.match('https*:\\/\\/')) {
                notifications.showError('Image URL should start with http://... or https://...');
            }
            else {
                let editedData = {
                    _id: id,
                    product: context.params.product,
                    description: context.params.description,
                    price: context.params.price,
                    pictureUrl: context.params.pictureUrl
                };

                offersService.editEvent(editedData)
                    .then(function () {
                        notifications.showSuccess('Product edited successfully!');
                        context.redirect('#/dashboard');
                    })
            }
        });
};

handlers.getDelete = function (context) {
    context.isAuth = userService.isAuth();
    context.username = sessionStorage.getItem('username');
    let id = context.params.id.replace(':', '');

    offersService.getOffer(id)
        .then(function (result) {
            context.id = id;
            context.product = result.product;
            context.description = result.description;
            context.price = result.price;
            context.pictureUrl = result.pictureUrl;

            context.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('templates/offers/deleteOffer.hbs');
                });
        });
};

handlers.deleteOffer = function (context) {
    let id = context.params.id.replace(':', '');

    offersService.deleteOffer(id)
        .then(function () {
            notifications.showSuccess('Offer deleted successfully!');
            context.redirect('#/dashboard');
        })
};