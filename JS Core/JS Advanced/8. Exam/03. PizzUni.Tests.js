const assert = require('chai').assert;
const PizzUni = require('./03. PizzUni');
let pizzUni = new PizzUni();

describe("PizzUni Tests", function() {
    beforeEach(function () {
        pizzUni = new PizzUni();
    });

    describe("constructor tests", function() {
        it('should have three properties', function () {
            assert.equal(Object.entries(pizzUni).length, 3);
        });

        it('should have three exact properties', function () {
            assert.equal(Object.entries(pizzUni)[0][0], 'registeredUsers');
            assert.equal(Object.entries(pizzUni)[1][0], 'availableProducts');
            assert.equal(Object.entries(pizzUni)[2][0], 'orders');
        });

        it("should initialize empty registeredUsers", function() {
            assert.equal(Object.entries(pizzUni.registeredUsers).length, 0);
        });

        it('should initialize availableProducts object with 2 properties', function () {
            assert.equal(Object.entries(pizzUni.availableProducts).length, 2);
        });

        it('should initialize availableProducts object with correct property names', function () {
            assert.equal(Object.entries(pizzUni.availableProducts)[0][0], 'pizzas');
            assert.equal(Object.entries(pizzUni.availableProducts)[1][0], 'drinks');
        });

        it('should initialize availableProducts object with correct property pizzas', function () {
            assert.equal(Object.entries(pizzUni.availableProducts)[0][1][0], 'Italian Style');
            assert.equal(Object.entries(pizzUni.availableProducts)[0][1][1], 'Barbeque Classic');
            assert.equal(Object.entries(pizzUni.availableProducts)[0][1][2], 'Classic Margherita');
        });

        it('should initialize availableProducts object with correct property drinks', function () {
            assert.equal(Object.entries(pizzUni.availableProducts)[1][1][0], 'Coca-Cola');
            assert.equal(Object.entries(pizzUni.availableProducts)[1][1][1], 'Fanta');
            assert.equal(Object.entries(pizzUni.availableProducts)[1][1][2], 'Water');
        });

        it('should initialize empty orders', function () {
            assert.equal(Object.entries(pizzUni.orders).length, 0);
        });
    });

    describe("registerUser tests", function () {
        it('should register user', function () {
            pizzUni.registerUser('meow');
            assert.equal(pizzUni.registeredUsers.length, 1);
        });

        it('should throw error registering existing user', function () {
            pizzUni.registerUser('meow');

            assert.throws(() => pizzUni.registerUser('meow'), 'This email address (meow) is already being used!');
        });

        it('should register user as an object', function () {
            pizzUni.registerUser('meow');

            assert.isObject(pizzUni.registeredUsers[0])
        });

        it('should register user as an object with empty array named orderHistory', function () {
            pizzUni.registerUser('meow');

            assert.isEmpty(pizzUni.registeredUsers[0].orderHistory);
        });

        it('should return the current user object', function () {
            let currentUser = {
                email: 'meow',
                orderHistory: []
            };

            let actual = pizzUni.registerUser('meow');

            assert.deepEqual(actual, currentUser);
        });
    })

    describe("makeAnOrder tests", function () {
        it('should throw error if user does not exist', function () {
            assert.throws(() => pizzUni.makeAnOrder('meow'), "You must be registered to make orders!")
        });

        it('should throw error if ordered pizza is not available', function () {
            pizzUni.registerUser('meow');

            assert.throws(() => pizzUni.makeAnOrder('meow', 'pizza'), "You must order at least 1 Pizza to finish the order.")
        });

        it('should push new object in the user orderHistory', function () {
            pizzUni.registerUser('meow');

            pizzUni.makeAnOrder('meow', 'Italian Style');

            let object = {
                orderedPizza: 'Italian Style'
            };

            assert.deepEqual(pizzUni.registeredUsers[0].orderHistory[0], object);
        });

        it('should push new object in the user orderHistory, drink included', function () {
            pizzUni.registerUser('meow');

            pizzUni.makeAnOrder('meow', 'Italian Style', 'Fanta');

            let object = {
                orderedPizza: 'Italian Style',
                orderedDrink: 'Fanta'
            };

            assert.deepEqual(pizzUni.registeredUsers[0].orderHistory[0], object);
        });

        it('should push new object in the user orderHistory, invalid drink included', function () {
            pizzUni.registerUser('meow');

            pizzUni.makeAnOrder('meow', 'Italian Style', 'Vodichka');

            let object = {
                orderedPizza: 'Italian Style'
            };

            assert.deepEqual(pizzUni.registeredUsers[0].orderHistory[0], object);
        });

        it('should return proper index', function () {
            pizzUni.registerUser('meow');

            pizzUni.makeAnOrder('meow', 'Italian Style');
            pizzUni.makeAnOrder('meow', 'Italian Style');
            let actual = pizzUni.makeAnOrder('meow', 'Italian Style');

            assert.equal(actual, 2);
        });

        it('should push object to orders', function () {
            pizzUni.registerUser('meow');

            pizzUni.makeAnOrder('meow', 'Italian Style');

            let object = {
                orderedPizza: 'Italian Style',
                email: 'meow',
                status: 'pending'
            };

            assert.deepEqual(pizzUni.orders[0], object);
        });
    });

    describe("completeOrder tests", function () {
        it('should complete order', function () {
            pizzUni.registerUser('meow');
            pizzUni.makeAnOrder('meow', 'Italian Style');

            pizzUni.completeOrder();

            let object = {
                orderedPizza: 'Italian Style',
                email: 'meow',
                status: 'completed'
            };

            assert.deepEqual(pizzUni.orders[0], object);
        });

        it('should complete the first order', function () {
            pizzUni.registerUser('meow');
            pizzUni.makeAnOrder('meow', 'Italian Style');
            pizzUni.makeAnOrder('meow', 'Italian Style');

            pizzUni.completeOrder();

            let complete = {
                orderedPizza: 'Italian Style',
                email: 'meow',
                status: 'completed'
            };

            let incomplete = {
                orderedPizza: 'Italian Style',
                email: 'meow',
                status: 'pending'
            };

            assert.deepEqual(pizzUni.orders[0], complete);
            assert.deepEqual(pizzUni.orders[1], incomplete);
        });

        it('should return undefined if no orders', function () {
            assert.isUndefined(pizzUni.completeOrder());
        });
    });

    describe("detailsAboutMyOrder tests", function () {
        it('should return correct order status with valid index, pending', function () {
            pizzUni.registerUser('meow');
            pizzUni.makeAnOrder('meow', 'Italian Style');

            assert.equal(pizzUni.detailsAboutMyOrder(0), 'Status of your order: pending');
        });

        it('should return correct order status with valid index, completed', function () {
            pizzUni.registerUser('meow');
            pizzUni.makeAnOrder('meow', 'Italian Style');
            pizzUni.completeOrder();

            assert.equal(pizzUni.detailsAboutMyOrder(0), 'Status of your order: completed');
        });

        it('should return undefined with invalid index', function () {
            pizzUni.registerUser('meow');
            pizzUni.makeAnOrder('meow', 'Italian Style');

            assert.isUndefined(pizzUni.detailsAboutMyOrder(1));
        });

        it('should return undefined with negative index', function () {
            pizzUni.registerUser('meow');
            pizzUni.makeAnOrder('meow', 'Italian Style');

            assert.isUndefined(pizzUni.detailsAboutMyOrder(-1));
        });

        it('should return undefined with no orders in the records', function () {
            assert.isUndefined(pizzUni.detailsAboutMyOrder(0));
        });

        it('should return undefined with no index given', function () {
            assert.isUndefined(pizzUni.detailsAboutMyOrder());
        });
    });
});
