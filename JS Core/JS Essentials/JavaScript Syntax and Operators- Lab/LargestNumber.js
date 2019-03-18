function solve(num1, num2, num3) {
    let largestNumber = num1;

    if (largestNumber < num2) {
        largestNumber = num2;
    }

    if (largestNumber < num3) {
        largestNumber = num3;
    }

    console.log("The largest number is " +  largestNumber + ".");
}