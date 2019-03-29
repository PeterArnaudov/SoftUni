function solve(arrayOne, arrayTwo, arrayThree) {
    let commonNumbers = [];
    let sum = 0;

    for (let i = 0; i < arrayOne.length; i++) {
        if (arrayTwo.includes(arrayOne[i]) && arrayThree.includes(arrayOne[i])) {
            commonNumbers.push(arrayOne[i]);
        }
    }

    commonNumbers.sort();

    for (let i = 0; i < commonNumbers.length; i++) {
        sum += commonNumbers[i];
    }

    let average = sum / commonNumbers.length;
    let median = 0;
    let middle = Math.floor(commonNumbers.length / 2);

    if (commonNumbers.length % 2 == 0) {
        median = (commonNumbers[middle] + commonNumbers[middle - 1]) / 2;
    }
    else {
        median = commonNumbers[middle];
    }

    console.log(`The common elements are ${commonNumbers.join(", ")}.`);
    console.log(`Average: ${average}.`);
    console.log(`Median: ${median}.`);
}