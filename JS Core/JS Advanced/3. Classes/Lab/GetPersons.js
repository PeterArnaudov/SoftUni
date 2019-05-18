function getPersons() {
    class Person {
        constructor(firstName, lastName, age, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }

    let personOne = new Person('Maria', 'Petrova', 22, 'mp@yahoo.com');
    let personTwo = new Person('SoftUni');
    let personThree = new Person('Stephan', 'Nikolov', 25);
    let personFour = new Person('Peter', 'Kolev', 24, 'ptr@gmail.com');

    let arrayOfPerson = [personOne, personTwo, personThree, personFour];

    return arrayOfPerson;
}