class CheckingAccount {
    constructor(clientID, email, firstName, lastName) {
        this.clientID = clientID;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
        this.products = [];
    }

    get clientID() {
        return this._clientID;
    }

    set clientID(clientID) {
        if (typeof(clientID) != "string" || clientID.length != 6) {
            throw new TypeError("Client ID must be a 6-digit number");
        }

        this._clientID = clientID;
    }

    get email() {
        return this._email;
    }

    set email(email) {
        if (!email.match('^[a-zA-Z\\d]+@[a-zA-Z.]+$')) {
            throw new TypeError("Invalid e-mail");
        }

        this._email = email;
    }

    get firstName() {
        return this._firstName;
    }

    set firstName(firstName) {
        if (firstName.length < 3 || firstName.length > 20) {
            throw new TypeError('First name must be between 3 and 20 characters long');
        }
        else if (firstName.match('[^a-zA-Z]')) {
            throw new TypeError('First name must contain only Latin characters')
        }

        this._firstName = firstName;
    }

    get lastName() {
        return this._lastName;
    }

    set lastName(lastName) {
        if (lastName.length < 3 || lastName.length > 20) {
            throw new TypeError('Last name must be between 3 and 20 characters long');
        }
        else if (lastName.match('[^a-zA-Z]')) {
            throw new TypeError('Last name must contain only Latin characters')
        }

        this._lastName = lastName;
    }
}