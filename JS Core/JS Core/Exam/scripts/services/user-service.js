const userService = (() => {
    function isAuth() {
        return sessionStorage.getItem('authtoken') !== null;
    }

    function saveSession(result) {
        sessionStorage.setItem('username', result.username);
        sessionStorage.setItem('authtoken', result._kmd.authtoken);
        sessionStorage.setItem('userID', result._id);
    }
    
    function register(username, password) {
        return kinvey.post('user', '', 'basic', {username, password});
    }

    function login(username, password) {
        return kinvey.post('user', 'login', 'basic', {username, password});
    }

    function logout() {
        return kinvey.post('user', '_logout', 'kinvey')
    }

    return {
        isAuth,
        saveSession,
        register,
        login,
        logout
    }
})();