const createCalculator = require('./AddSubtract');

const assert = require('chai').assert;

describe('AddSubtract Tests', function () {
    let calculator;

    beforeEach(function () {
       calculator = createCalculator();
    });

    it('should return an object with add, subtract and get functions', function () {
        assert.property(calculator, 'add');
        assert.property(calculator, 'subtract');
        assert.property(calculator, 'get');
    });

    it('should have closure with initial value 0', function () {
        let expected = 0;

        let actual = calculator.get();

        assert.equal(actual, expected);
    });

    it('should not be able to modify the closure value', function () {
        let expected = 0;

        calculator.value += 5;
        let actual = calculator.get();

        assert.equal(actual, expected);
    });

    it('function add should take parsable argument', function () {
        assert.doesNotThrow(() => calculator.add(5));
        assert.doesNotThrow(() => calculator.add('5'));
    });

    it('function add should add the value', function () {
        let expected = 10;

        calculator.add(10);
        let actual = calculator.get();

        assert.equal(actual, expected);
    });

    it('function add should return NaN when non-number string is given', function () {
        calculator.add('ten');
        let actual = calculator.get();

        assert.isNaN(actual);
    });

    it('function subtract should take parsable argument', function () {
        assert.doesNotThrow(() => calculator.subtract(5));
        assert.doesNotThrow(() => calculator.subtract('5'));
    });

    it('function subtract should subtract the value', function () {
        let expected = -10;

        calculator.subtract(10);
        let actual = calculator.get();

        assert.equal(actual, expected);
    });

    it('function subtract should return NaN when non-number string is given', function () {
        calculator.subtract('ten');
        let actual = calculator.get();

        assert.isNaN(actual);
    });

    it('should do many calculations properly', function () {
        let expected = 65;

        calculator.add(100);
        calculator.subtract(50);
        calculator.add(25);
        calculator.subtract(10);

        let actual = calculator.get();

        assert.equal(actual, expected);
    });

    it('should do proper calculations with negative numbers', function () {
        let expected = -10;

        calculator.add(-5);
        calculator.subtract(5);

        let actual = calculator.get();

        assert.equal(actual, expected);
    });

    it('should do proper calculations with decimal numbers', function () {
        let expected = 13.7;

        calculator.add(4.5);
        calculator.add(10.3);
        calculator.subtract(1.1);

        let actual = calculator.get();

        assert.equal(actual.toFixed(1), expected);
    });

    it('should do proper calculations with given numbers and numbers as strings', function () {
        let expected = 20;

        calculator.add(5);
        calculator.add('20');
        calculator.subtract(3);
        calculator.subtract('2');

        let actual = calculator.get();

        assert.equal(actual, expected);
    });
});