const lookupChar = require('./CharLookup');

const assert = require('chai').assert;

describe('CharLookup Tests', function () {
    it('should return undefined if first argument is not string', function () {
        let inputString = 5;
        let inputNumber = 0;

        assert.isUndefined(lookupChar(inputString, inputNumber));
    });

    it('should return undefined if second argument is not number', function () {
        let inputString = 'string';
        let inputNumber = 'string';

        assert.isUndefined(lookupChar(inputString, inputNumber));
    });

    it('should return undefined if second argument is decimal number', function () {
        let inputString = 'string';
        let inputNumber = 3.14;

        assert.isUndefined(lookupChar(inputString, inputNumber));
    });

    it('should return undefined if first argument is not string and second argument is not number', function () {
        let inputString = 5;
        let inputNumber = 'string';

        assert.isUndefined(lookupChar(inputString, inputNumber));
    });

    it('should return failure string if index is below zero', function () {
        let inputString = 'string';
        let inputNumber = -3;
        let expected = 'Incorrect index';

        let actual = lookupChar(inputString, inputNumber);

        assert.equal(actual, expected);
    });

    it('should return failure string if index is equal or higher than string length', function () {
        let inputString = 'string';
        let inputNumber = 10;
        let expected = 'Incorrect index';

        let actual = lookupChar(inputString, inputNumber);

        assert.equal(actual, expected);
    });

    it('should return char of a string at zero index', function () {
        let inputString = 'string';
        let inputNumber = 0;
        let expected = inputString[0];

        let actual = lookupChar(inputString, inputNumber);

        assert.equal(actual, expected);
    });

    it('should return char of a string at last index', function () {
        let inputString = 'string';
        let inputNumber = inputString.length - 1;
        let expected = inputString[inputNumber];

        let actual = lookupChar(inputString, inputNumber);

        assert.equal(actual, expected);
    });

    it('should return char at middle index', function () {
        let inputString = 'mouse';
        let inputNumber = Math.ceil(inputString.length / 2);
        let expected = inputString[inputNumber];

        let actual = lookupChar(inputString, inputNumber);

        assert.equal(actual, expected);
    });
});