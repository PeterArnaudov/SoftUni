const isOddOrEven = require('./EvenOrOdd');

const assert = require('chai').assert;

describe('isOddOrEven Tests', function () {
    it('should return undefined if input is number', function () {
        assert.isUndefined(isOddOrEven(5));
    });

    it('should return undefined if input is bool', function () {
        assert.isUndefined(isOddOrEven(true));
    });

    it('should return undefined if input is array', function () {
        assert.isUndefined(isOddOrEven([1, 2, 3]));
    });

    it('should return undefined if input is array', function () {
        assert.isUndefined(isOddOrEven(['one', 'two']));
    });

    it('should return undefined if input is object', function () {
        assert.isUndefined(isOddOrEven({}));
    });

    it('should return even if string length is even', function () {
        let expected = 'even';

        let actual = isOddOrEven('even');

        assert.equal(actual, expected);
    });

    it('should return odd if string length is odd', function () {
        let expected = 'odd';

        let actual = isOddOrEven('odd');

        assert.equal(actual, expected);
    });
});