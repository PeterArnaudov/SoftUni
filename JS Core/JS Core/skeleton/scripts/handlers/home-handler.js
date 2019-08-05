handlers.getHome = function (context) {
    context.isAuth = userService.isAuth();

    if (userService.isAuth()) {
        context.username = sessionStorage.getItem('username');

        postService.getAllPosts()
            .then(function (posts) {
                context.posts = posts;

                context.loadPartials({
                    header: 'templates/common/header.hbs',
                    footer: 'templates/common/footer.hbs',
                    posts: 'templates/posts/postsCollection.hbs',
                    post: 'templates/posts/post.hbs'
                })
                    .then(function () {
                        this.partial('templates/home/home.hbs');
                    });
            });
    }
    else {
        context.loadPartials({
            header: 'templates/common/header.hbs',
            footer: 'templates/common/footer.hbs'
        })
            .then(function () {
                this.partial('templates/home/home.hbs');
            });
    }
};