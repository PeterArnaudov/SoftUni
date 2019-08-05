$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('#/home', function () {
            this.loggedIn = sessionStorage.getItem('authtoken') ? true : false;
            this.username = sessionStorage.getItem('username');
            this.teamId = sessionStorage.getItem('teamId');
            this.hasTeam = this.teamId == 'undefined' ? false : true;

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('./templates/home/home.hbs');
                })
        });

        this.get('#/about', function () {
            this.loggedIn = sessionStorage.getItem('authtoken') ? true : false;
            this.username = sessionStorage.getItem('username');

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            })
                .then(function () {
                    this.partial('./templates/about/about.hbs');
                })
        });

        this.get('#/login', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                loginForm: './templates/login/loginForm.hbs'
            })
                .then(function () {
                    this.partial('./templates/login/loginPage.hbs');
                })
        });

        this.post('#/login', function (context) {
            let that = this;
            let username = context.params.username;
            let password = context.params.password;
            auth.login(username, password)
                .then(function (res) {
                    auth.saveSession(res);
                    auth.showInfo('Login successful!');
                    that.redirect('#/home');
                });
        });

        this.get('#/logout', function () {
           auth.logout();
           sessionStorage.clear();
           auth.showInfo('Logout successful!');

           this.redirect('#/home');
        });

        this.get('#/register', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                registerForm: './templates/register/registerForm.hbs'
            })
                .then(function () {
                    this.partial('./templates/register/registerPage.hbs');
                })
        });

        this.post('#/register', function (context) {
            let that = this;
            let username = context.params.username;
            let password = context.params.password;

            auth.register(username, password)
                .then(function (res) {
                    auth.saveSession(res);
                    auth.showInfo('Register successful!');
                    that.redirect('#/home');
                })
                .catch(function () {
                    auth.showError('Register unsuccessful!');
                });
        });

        this.get('#/catalog', function () {
            let that = this;

            this.loggedIn = sessionStorage.getItem('authtoken') ? true : false;
            this.username = sessionStorage.getItem('username');
            this.hasNoTeam = sessionStorage.getItem('teamId') == 'undefined' ? true : false;

            teamsService.loadTeams()
                .then(function (data) {
                    that.teams = data;

                    that.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        team: './templates/catalog/team.hbs'
                    })
                        .then(function () {
                            this.partial('./templates/catalog/teamCatalog.hbs');
                        });
                });
        });

        this.get('#/catalog/:teamId', function (context) {
            let that = this;
            let teamId = context.params.teamId.replace(':', '');

            teamsService.loadTeamDetails(teamId)
                .then(function (teamData) {
                    that.loggedIn = sessionStorage.getItem('authtoken') ? true : false;
                    that.username = sessionStorage.getItem('username');
                    that.name = teamData.name;
                    that.members = teamData._acl.creator; //how do I get members of a team?
                    that.comment = teamData.comment;
                    that.isAuthor = teamData._acl.creator == sessionStorage.getItem('userId');
                    that.isOnTeam = sessionStorage.getItem('teamId') == teamData._id;
                    that.teamId = teamId;

                    that.loadPartials({
                        header: './templates/common/header.hbs',
                        footer: './templates/common/footer.hbs',
                        member: './templates/catalog/teamMember.hbs',
                        teamControls:  './templates/catalog/teamControls.hbs'
                    })
                        .then(function () {
                            this.partial('./templates/catalog/details.hbs');
                        });
                });
        });

        this.get('#/join/:teamId', function (context) {
            let that = this;
            let teamId = context.params.teamId.replace(':', '');

            teamsService.joinTeam(teamId)
                .then(function () {
                    sessionStorage.setItem('teamId', teamId);
                    auth.showInfo('You joined the team successfully!');
                    that.redirect('#/catalog');
                })
                .catch(function () {
                    auth.showError('Joining the team failed!');
                    that.redirect('#/catalog');
                })
        });

        this.get('#/edit/:teamId', function () {
           this.loadPartials({
               header: './templates/common/header.hbs',
               footer: './templates/common/footer.hbs',
               editForm: './templates/edit/editForm.hbs'
           })
               .then(function () {
                   this.partial('./templates/edit/editPage.hbs');
               })
        });

        this.post('#/edit/:teamId', function (context) {
            let that = this;
            let teamId = sessionStorage.getItem('teamId');
            let teamName = context.params.name;
            let teamComment = context.params.comment;

            teamsService.edit(teamId, teamName, teamComment)
                .then(function () {
                    that.redirect(`#/catalog/:${teamId}`);
                    auth.showInfo('Edited successfully!');
                })
                .catch(function () {
                    auth.showError('Edit unsuccessful!');
                });
        });

        this.get('#/leave', function () {
            let that = this;

            teamsService.leaveTeam()
                .then(function () {
                    sessionStorage.setItem('teamId', 'undefined');
                    auth.showInfo('You left the team successfully!');
                    that.redirect('#/catalog');
                })
                .catch(function () {
                    auth.showError('Leaving the team failed!');
                    that.redirect('#/catalog');
                })
        });

        this.get('#/create', function () {
            this.loggedIn = sessionStorage.getItem('authtoken') ? true : false;
            this.username = sessionStorage.getItem('username');

            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                createForm: './templates/create/createForm.hbs'
            })
                .then(function () {
                    this.partial('./templates/create/createPage.hbs');
                });
        });

        this.post('#/create', function (context) {
            let that = this;

            let teamName = context.params.name;
            let teamComment = context.params.comment;

            teamsService.createTeam(teamName, teamComment)
                .then(function (data) {
                    auth.showInfo('Team created successfully!');
                    let teamId = data._id;
                    teamsService.joinTeam(teamId)
                        .then(function () {
                            sessionStorage.setItem('teamId', teamId);
                            that.redirect('#/catalog');
                        })
                        .catch(function () {
                            auth.showError('Joining team failed!');
                        });
                })
                .catch(function () {
                    auth.showError('Team creation unsuccessful!');
                });
        })
    });

    app.run();
});