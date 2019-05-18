const StringBuilder = require('./string-builder');

const assert = require('chai').assert;

describe('StringBuilder Tests', function () {
    let sb;

    beforeEach(function () {
        sb = new StringBuilder();
    });

    describe('Constructor Tests', function () {
        it('should be instantiated without arguments', function () {
            let expected = 0;
            let actual = sb._stringArray.length;

            assert.isDefined(sb);
            assert.equal(actual, expected);
        });

        it('should be instantiated with arguments', function () {
            let expected = 'Test';
            sb = new StringBuilder(expected);

            let actual = sb._stringArray.join('');

            assert.isDefined(sb);
            assert.equal(actual, expected);
        });

        it('should have _stringArray property', function () {
            assert.isTrue(sb.hasOwnProperty('_stringArray'));
        });

        it('should have _stringArray of type Array', function () {
            assert.isArray(sb._stringArray);
        });

        it('should have empty array as data when no params are given to the initialization', function () {
            let expected = 0;

            let actual = sb._stringArray.length;

            assert.equal(actual, expected);
        });

        it('should have non-empty array as data when string is given to the initialization', function () {
            let instanceString = 'Test';
            let expected = instanceString.length;

            sb = new StringBuilder(instanceString);
            let actual = sb._stringArray.length;

            assert.equal(actual, expected);
        });

        it('should have its function properties', function () {
            assert.isTrue(Object.getPrototypeOf(sb).hasOwnProperty('append'));
            assert.isTrue(Object.getPrototypeOf(sb).hasOwnProperty('prepend'));
            assert.isTrue(Object.getPrototypeOf(sb).hasOwnProperty('insertAt'));
            assert.isTrue(Object.getPrototypeOf(sb).hasOwnProperty('remove'));
            assert.isTrue(Object.getPrototypeOf(sb).hasOwnProperty('toString'));
        });

        it('should not throw error when initialized without params', function () {
            assert.doesNotThrow(() => sb = new StringBuilder());
        });

        it('should not throw error when initialized with string', function () {
            assert.doesNotThrow(() => sb = new StringBuilder('Test'));
        });

        it('should throw error when instantiated with non-string argument', function () {
            assert.throws(() => sb = new StringBuilder(5));
        });
    });

    describe('Append Tests', function () {
        it('should append a string', function () {
            let expected = 'Test';

            sb.append(expected);
            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should append a string in the end', function () {
            let stringOne = 'Test';
            let stringTwo = 'Meow';
            let expected = stringOne + stringTwo;

            sb.append(stringOne);
            sb.append(stringTwo);
            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should throw exception when non-string argument is given', function () {
            assert.throws(() => sb.append(5));
        });
    });

    describe('Prepend Tests', function () {
        it('should append a string', function () {
            let expected = 'Test';

            sb.prepend(expected);
            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should append a string in the beginning', function () {
            let instanceString = 'Test';
            let stringTwo = 'Meow ';
            let expected = stringTwo + instanceString;

            sb = new StringBuilder(instanceString);
            sb.prepend(stringTwo);
            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should throw error when non-string argument is given', function () {
            assert.throws(() => sb.prepend(5));
        });
    });

    describe('InsertAt Tests', function () {
        it('should insert string in the beginning', function () {
            let instanceString = 'Test';
            let insertedString = 'Meow';
            let insertIndex = 0;
            let expected = insertedString + instanceString;

            sb = new StringBuilder(instanceString);
            sb.insertAt(insertedString, insertIndex);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should insert string in the beginning when negative index is given', function () {
            let instanceString = 'Test';
            let insertedString = 'Meow';
            let insertIndex = -5;
            let expected = insertedString + instanceString;

            sb = new StringBuilder(instanceString);
            sb.insertAt(insertedString, insertIndex);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should insert string in the end', function () {
            let instanceString = 'Test';
            let insertedString = 'Meow';
            let insertIndex = instanceString.length;
            let expected = instanceString + insertedString;

            sb = new StringBuilder(instanceString);
            sb.insertAt(insertedString, insertIndex);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should insert string in the end when index higher than the sb length is given', function () {
            let instanceString = 'Test';
            let insertedString = 'Meow';
            let insertIndex = instanceString.length + 5;
            let expected = instanceString + insertedString;

            sb = new StringBuilder(instanceString);
            sb.insertAt(insertedString, insertIndex);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should insert string at an index', function () {
            let instanceString = 'Test';
            let insertedString = 'Meow';
            let insertIndex = instanceString.length - 2;
            let expected = 'TeMeowst';

            sb = new StringBuilder(instanceString);
            sb.insertAt(insertedString, insertIndex);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should throw error when non-string argument is given', function () {
            assert.throws(() => sb.insertAt(0, 0));
        });
    });

    describe('Remove Tests', function () {
        let instanceString = 'Test';

        beforeEach(function () {
            sb = new StringBuilder(instanceString);
        });

        it('should remove from start index', function () {
            let startIndex = 2;
            let removeLength = 2;
            let expected = instanceString.substring(0, removeLength);

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should remove from the beginning', function () {
            let startIndex = 0;
            let removeLength = 2;
            let expected = instanceString.substring(removeLength, instanceString.length);

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should remove from the beginning to the end', function () {
            let startIndex = 0;
            let removeLength = instanceString.length;
            let expected = '';

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should remove from the beginning to the end when higher index than the sb length is given', function () {
            let startIndex = 0;
            let removeLength = instanceString.length + 5;
            let expected = '';

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should remove from the end when negative index is given', function () {
            let startIndex = -2;
            let removeLength = 2;
            let expected = instanceString.substring(0, removeLength);

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should not remove elements when negative remove length is given', function () {
            let startIndex = 0;
            let removeLength = -2;
            let expected = instanceString;

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('');

            assert.equal(actual, expected);
        });

        it('should remove characters exact to the length argument given', function () {
            let startIndex = 0;
            let removeLength = 2;
            let expected = instanceString.substring(removeLength, instanceString.length).length;

            sb.remove(startIndex, removeLength);

            let actual = sb._stringArray.join('').length;

            assert.equal(actual, expected);
        });
    });

    describe('toString Tests', function () {
        it('should return correct string with instance string', function () {
            let instanceString = 'Test';
            let expected = instanceString;

            sb = new StringBuilder(instanceString);
            let actual = sb.toString();

            assert.equal(actual, expected);
        });

        it('should return correct string with methods used', function () {
            let instanceString = 'Test';
            let appendString = 'Meow';
            let prependString = 'Bark';
            let expected = prependString + instanceString + appendString;

            sb = new StringBuilder(instanceString);
            sb.append(appendString);
            sb.prepend(prependString);
            let actual = sb.toString();

            assert.equal(actual, expected);
        });

        it('should return empty string when sb is empty', function () {
            let expected = '';

            let actual = sb.toString();

            assert.equal(actual, expected);
        });
    });
});