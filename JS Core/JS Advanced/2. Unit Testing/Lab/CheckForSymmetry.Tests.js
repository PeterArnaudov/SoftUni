const isSymmetric = require('./CheckForSymmetry');

const assert = require('chai').assert;

describe('Check For Symmetry Tests', function () {
    it('should return true when input array of numbers is symmetrical', function () {
        let inputArray = [1, 2, 3, 2, 1];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array is symmetrical");
    });

    it('should return true when input array of numbers has negative numbers and is symmetrical', function () {
        let inputArray = [-1, 2, -1];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array is symmetrical");
    });

    it('should return true when input array of strings is symmetrical', function () {
        let inputArray = ['meow', 'bark', 'quack', 'bark', 'meow'];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array is symmetrical");
    });

    it('should return true when input array elements are the same', function () {
        let inputArray = [1, 1, 1, 1, 1];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array is symmetrical");
    });

    it('should return true when input array has mixed element types', function () {
        let inputArray = [1, 'string', {A:4}, new Date(), {A:4}, 'string', 1];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array is symmetrical")
    });

    it('should return true when empty array is given', function () {
        let inputArray = [];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array is empty");
    });

    it('should return true when array with one element is given', function () {
        let inputArray = [1];
        let expected = true;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns false but input array with one element is symmetrical");
    });

    it('should return false when input array of numbers is not symmetrical', function () {
        let inputArray = [1, 2, 3, 4, 5];
        let expected = false;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns true but input array isn't symmetrical");
    });

    it('should return false when input array of numbers has negative numbers and is not symmetrical', function () {
        let inputArray = [-1, 2, 1];
        let expected = false;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns true but input array isn't symmetrical");
    });

    it('should return false when array with two different elements is given', function () {
        let inputArray = [1, 5];
        let expected = false;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns true but input array with two different elements isn't symmetrical");
    });

    it('should return false when input array of strings is not symmetrical', function () {
        let inputArray = ['meow', 'bark', 'quack'];
        let expected = false;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns true but input array isn't symmetrical");
    });

    it('should return false when input array has mixed element types', function () {
        let inputArray = [1, 'string', {A:4}, new Date(), {B:5}, 'string', 1];
        let expected = false;

        let actual = isSymmetric(inputArray);

        assert.equal(actual, expected, "Returns true but input array isn't symmetrical")
    });

    it('should return false if input is string', function () {
        let input = 'I am not an array';
        let expected = false;

        let actual = isSymmetric(input);

        assert.equal(actual, expected, "Returns true but input isn't an array");
    });

    it('should return false if input is number', function () {
        let input = 5;
        let expected = false;

        let actual = isSymmetric(input);

        assert.equal(actual, expected, "Returns true but input isn't an array");
    });

    it('should return false if input is object', function () {
        let input = {};
        let expected = false;

        let actual = isSymmetric(input);

        assert.equal(actual, expected, "Returns true but input isn't an array");
    });
});