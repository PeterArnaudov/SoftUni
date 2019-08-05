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

        eventService.getAllEvents()
            .then(function (events) {
                context.events = events.sort((a, b) => +b.peopleInterestedIn - +a.peopleInterestedIn);
                context.anyEvents = events.length !== 0;

                context.loadPartials({
                    header: 'templates/common/header.hbs',
                    footer: 'templates/common/footer.hbs',
                    events: 'templates/events/eventsCollection.hbs',
                    event: 'templates/events/event.hbs'
                })
                    .then(function () {
                        this.partial('templates/home/home.hbs');
                    });
            });
    }
};