function solve(number) {
    let same = true;
    let sum = 0;

    for (let i = 0; i < number.toString().length; i++) {
        sum += +number.toString()[i];

        if (number.toString()[0] == number.toString()[i] && same) {
            same = true;
        }
        else {
            same = false;
        }
    }

    console.log(same);
    console.log(sum)
}