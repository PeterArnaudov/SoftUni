const PaymentPackage = require('./PaymentPackage');

const assert = require('chai').assert;

describe('PaymentPackage Tests', function () {
    let paymentPackage;
    let instanceName = 'Test';
    let instanceValue = 100;

    beforeEach(function () {
        paymentPackage = new PaymentPackage(instanceName, instanceValue);
    });

    describe('Constructor Tests', function () {
        it('should initialize an instance', function () {
            assert.isDefined(paymentPackage);
        });

        it('should have all properties', function () {
            assert.isTrue(paymentPackage.hasOwnProperty('_name'));
            assert.isTrue(paymentPackage.hasOwnProperty('_value'));
            assert.isTrue(paymentPackage.hasOwnProperty('_VAT'));
            assert.isTrue(paymentPackage.hasOwnProperty('_active'));
        });

        it('should initialize instance with given name', function () {
            assert.equal(paymentPackage._name, instanceName);
        });

        it('should initialize instance with given value', function () {
            assert.equal(paymentPackage._value, instanceValue);
        });
    });

    describe('Name property tests', function () {
        it('should throw error when non-string argument is given', function () {
            assert.throws(() => paymentPackage.name = 5);
        });

        it('should throw error when empty string is given', function () {
            assert.throws(() => paymentPackage.name = '');
        });

        it('should change the name if valid string is given', function () {
            let newName = 'ValidName';

            paymentPackage.name = newName;

            assert.equal(paymentPackage._name, newName);
        });

        it('should return correct name', function () {
            assert.equal(paymentPackage.name, instanceName);
        });
    });

    describe('Value property tests', function () {
        it('should throw error when non-number argument is given', function () {
            assert.throws(() => paymentPackage.value = 'string');
        });

        it('should throw error when negative number is given', function () {
            assert.throws(() => paymentPackage.value = -5);
        });

        it('should change the value if positive number is given', function () {
            let newValue = 50;

            paymentPackage.value = newValue;

            assert.equal(paymentPackage._value, newValue);
        });

        it('should change the value if 0 is given', function () {
            let newValue = 0;

            paymentPackage.value = newValue;

            assert.equal(paymentPackage._value, newValue);
        });

        it('should return correct value', function () {
            assert.equal(paymentPackage.value, instanceValue);
        });
    });

    describe('VAT property tests', function () {
        it('should have correct default VAT', function () {
            assert.equal(paymentPackage._VAT, 20);
        });

        it('should throw error when non-number argument is given', function () {
            assert.throws(() => paymentPackage.VAT = 'string');
        });

        it('should throw error when negative number is given', function () {
            assert.throws(() => paymentPackage.VAT = -5);
        });

        it('should change the value if positive number is given', function () {
            let newValue = 50;

            paymentPackage.VAT = newValue;

            assert.equal(paymentPackage._VAT, newValue);
        });

        it('should change the value if 0 is given', function () {
            let newValue = 0;

            paymentPackage.VAT = newValue;

            assert.equal(paymentPackage._VAT, newValue);
        });

        it('should return correct value', function () {
            let newVAT = 40;

            paymentPackage._VAT = newVAT;

            assert.equal(paymentPackage.VAT, newVAT);
        });
    });

    describe('Active property tests', function () {
        it('should have proper default status', function () {
            assert.equal(paymentPackage._active, true);
        });

        it('should throw error when non-boolean argument is given', function () {
            assert.throws(() => paymentPackage.active = 'string');
        });

        it('should change the status correctly', function () {
            let newStatus = false;

            paymentPackage.active = newStatus;

            assert.equal(paymentPackage._active, newStatus);
        });

        it('should return correct value', function () {
            assert.equal(paymentPackage.active, true);
        });
    });

    describe('toString tests', function () {
        it('should return correct string with active status', function () {
            let expected = 'Package: Test\n' +
                '- Value (excl. VAT): 100\n' +
                '- Value (VAT 20%): 120';

            let actual = paymentPackage.toString();

            assert.equal(actual, expected);
        });

        it('should return correct string with inactive status', function () {
            let expected = 'Package: Test (inactive)\n' +
                '- Value (excl. VAT): 100\n' +
                '- Value (VAT 20%): 120';

            paymentPackage.active = false;
            let actual = paymentPackage.toString();

            assert.equal(actual, expected);
        });
    });
});