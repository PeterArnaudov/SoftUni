function solve(array) {
    let perfectNumbers = [];

    for (let number of array) {
        let properDivisors = getAllProperDivisors(number);
        let sumOfProperDivisors = getSum(properDivisors);

        if (number == sumOfProperDivisors - number || number == sumOfProperDivisors / 2) {
            perfectNumbers.push(number);
        }
    }

    console.log(perfectNumbers.length != 0 ? perfectNumbers.join(", ") : 'No perfect number');
    
    function getAllProperDivisors(number) {
        let properDivisors = [];
        for (let i = 1; i <= number; i++) {
            if (number % i == 0) {
                properDivisors.push(i);
            }
        }

        return properDivisors;
    }

    function getSum(numbers) {
        let sum = 0;

        for (let number of numbers) {
            sum += number;
        }

        return sum;
    }
}