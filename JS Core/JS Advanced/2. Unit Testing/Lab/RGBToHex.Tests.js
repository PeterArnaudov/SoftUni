const rgbToHexColor = require('./RGBToHex');

const assert = require('chai').assert;

describe('RGBToHex Tests', function () {
    it('should return correct hexColor', function () {
        let expected = '#255FBC';

        let actual = rgbToHexColor(37, 95, 188);

        assert.equal(actual, expected);
    });

    it('should return correct hexColor', function () {
        let expected = '#FFFFFF';

        let actual = rgbToHexColor(255, 255, 255);

        assert.equal(actual, expected);
    });

    it('should return correct hexColor', function () {
        let expected = '#000000';

        let actual = rgbToHexColor(0, 0, 0);

        assert.equal(actual, expected);
    });

    //red
    it('should return undefined with invalid red', function () {
        let expected = undefined;

        let actual = rgbToHexColor('string', 100, 100);

        assert.equal(actual, expected);
    });

    it('should return undefined with red below zero', function () {
        let expected = undefined;

        let actual = rgbToHexColor(-100, 100, 100);

        assert.equal(actual, expected);
    });

    it('should return undefined with red above 255', function () {
        let expected = undefined;

        let actual = rgbToHexColor(300, 100, 100);

        assert.equal(actual, expected);
    });

    //green
    it('should return undefined with invalid green', function () {
        let expected = undefined;

        let actual = rgbToHexColor(100, 'invalid', 100);

        assert.equal(actual, expected);
    });

    it('should return undefined with green below zero', function () {
        let expected = undefined;

        let actual = rgbToHexColor(100, -100, 100);

        assert.equal(actual, expected);
    });

    it('should return undefined with green above 255', function () {
        let expected = undefined;

        let actual = rgbToHexColor(100, 300, 100);

        assert.equal(actual, expected);
    });

    //blue
    it('should return undefined with invalid blue', function () {
        let expected = undefined;

        let actual = rgbToHexColor(100, 100, 'invalid');

        assert.equal(actual, expected);
    });

    it('should return undefined with blue below zero', function () {
        let expected = undefined;

        let actual = rgbToHexColor(100, 100, -100);

        assert.equal(actual, expected);
    });

    it('should return undefined with blue above 255', function () {
        let expected = undefined;

        let actual = rgbToHexColor(100, 100, 300);

        assert.equal(actual, expected);
    });
});