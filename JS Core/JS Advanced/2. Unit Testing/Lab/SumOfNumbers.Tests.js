const sum = require('./SumOfNumbers');

const assert = require('chai').assert;

describe('Sum Function', function () {
    it('should sum all array numbers', function () {
        let inputArray = [1, 2, 3, 4, 5];
        let expected = 15;

        let actual = sum(inputArray);

        assert.equal(actual, expected, "Sum Function doesn't sum correctly.");
    });

    it('should return 0 if empty array is given', function () {
        let inputArray = [];
        let expected = 0;

        let actual = sum(inputArray);

        assert.equal(actual, expected, "Sum Function doesn't return 0 when empty array is given.")
    });

    it('should sum correctly when negative numbers are given', function () {
        let inputArray = [-1, -2, -3];
        let expected = -6;

        let actual = sum(inputArray);

        assert.equal(actual, expected, "Sum Function doesn't sum correctly negative numbers.")
    });
});