const mathEnforcer = require('./MathEnforcer');

const assert = require('chai').assert;

describe('MathEnforcer Tests', function () {
    it('should have property addFive', function () {
        let expected = true;

        let actual = mathEnforcer.hasOwnProperty('addFive');

        assert.equal(actual, expected);
    });

    it('should have property subtractTen', function () {
        let expected = true;

        let actual = mathEnforcer.hasOwnProperty('subtractTen');

        assert.equal(actual, expected);
    });

    it('should have property sum', function () {
        let expected = true;

        let actual = mathEnforcer.hasOwnProperty('sum');

        assert.equal(actual, expected);
    });
});

describe('addFive function tests', function () {
    it('addFive function should return undefined if not-number is given', function () {
        assert.isUndefined(mathEnforcer.addFive('string'));
        assert.isUndefined(mathEnforcer.addFive('5'));
        assert.isUndefined(mathEnforcer.addFive(true));
        assert.isUndefined(mathEnforcer.addFive([]));
        assert.isUndefined(mathEnforcer.addFive({}));
    });

    it('addFive function should return number plus 5', function () {
        let number = 10;
        let expected = number + 5;

        let actual = mathEnforcer.addFive(number);

        assert.equal(actual, expected);
    });

    it('addFive function should return zero', function () {
        let number = -5;
        let expected = number + 5;

        let actual = mathEnforcer.addFive(number);

        assert.equal(actual, expected);
    });

    it('addFive function should return number plus 5 when decimal number is given', function () {
        let number = 3.14;
        let expected = number + 5;

        let actual = mathEnforcer.addFive(number);

        assert.closeTo(actual, expected, 0.01);
    });

    it('addFive function should return negative number', function () {
        let number = -15;
        let expected = number + 5;

        let actual = mathEnforcer.addFive(number);

        assert.equal(actual, expected);
    });
});

describe('subtractTen function tests', function () {
    it('subtractTen function should return undefined if not-number is given', function () {
        assert.isUndefined(mathEnforcer.subtractTen('string'));
        assert.isUndefined(mathEnforcer.subtractTen('5'));
        assert.isUndefined(mathEnforcer.subtractTen(true));
        assert.isUndefined(mathEnforcer.subtractTen([]));
        assert.isUndefined(mathEnforcer.subtractTen({}));
    });

    it('subtractTen function should return number minus 10', function () {
        let number = 15;
        let expected = number - 10;

        let actual = mathEnforcer.subtractTen(number);

        assert.equal(actual, expected);
    });

    it('subtractTen function should return zero', function () {
        let number = 10;
        let expected = number - 10;

        let actual = mathEnforcer.subtractTen(number);

        assert.equal(actual, expected);
    });

    it('subtractTen function should return number minus 10 when decimal number is given', function () {
        let number = 30.14;
        let expected = number - 10;

        let actual = mathEnforcer.subtractTen(number);

        assert.closeTo(actual, expected, 0.01);
    });

    it('subtractTen function should return negative number', function () {
        let number = -30.14;
        let expected = number - 10;

        let actual = mathEnforcer.subtractTen(number);

        assert.closeTo(actual, expected, 0.01);
    });
});

describe('sum function tests', function () {
    it('sum function should return undefined when first argument is not a number', function () {
        assert.isUndefined(mathEnforcer.sum('string', 5));
        assert.isUndefined(mathEnforcer.sum('5', 5));
        assert.isUndefined(mathEnforcer.sum(true, 5));
        assert.isUndefined(mathEnforcer.sum([], 5));
        assert.isUndefined(mathEnforcer.sum({}, 5));
    });

    it('sum function should return undefined when second argument is not a number', function () {
        assert.isUndefined(mathEnforcer.sum(5, 'string'));
        assert.isUndefined(mathEnforcer.sum(5, '5'));
        assert.isUndefined(mathEnforcer.sum(5, true));
        assert.isUndefined(mathEnforcer.sum(5, []));
        assert.isUndefined(mathEnforcer.sum(5, {}));
    });

    it('sum function should return undefined when both arguments are not numbers', function () {
        assert.isUndefined(mathEnforcer.sum('string', 'string'));
        assert.isUndefined(mathEnforcer.sum('5', '5'));
        assert.isUndefined(mathEnforcer.sum(true, false));
        assert.isUndefined(mathEnforcer.sum([], {}));
        assert.isUndefined(mathEnforcer.sum({}, []));
    });

    it('sum function should return zero when both numbers are zero', function () {
        let numberOne = 0;
        let numberTwo = 0;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.equal(actual, expected);
    });

    it('sum function should return positive number which is sum of two numbers', function () {
        let numberOne = 5;
        let numberTwo = 10;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.equal(actual, expected);
    });

    it('sum function should return negative number which is sum of two numbers', function () {
        let numberOne = -5;
        let numberTwo = -10;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.equal(actual, expected);
    });

    it('sum function should return positive decimal number which is sum of two numbers', function () {
        let numberOne = 5.99;
        let numberTwo = 10.27;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.closeTo(actual, expected, 0.01);
    });

    it('sum function should return negative decimal number which is sum of two numbers', function () {
        let numberOne = -5.45;
        let numberTwo = -10.88;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.closeTo(actual, expected, 0.01);
    });

    it('sum function should return decimal number which is sum of two numbers and one is not decimal', function () {
        let numberOne = 5;
        let numberTwo = 10.88;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.closeTo(actual, expected, 0.01);
    });


    it('sum function should return correct number when summing positive and negative numbers', function () {
        let numberOne = -10;
        let numberTwo = 3;
        let expected = numberOne + numberTwo;

        let actual = mathEnforcer.sum(numberOne, numberTwo);

        assert.equal(actual, expected);
    });
});