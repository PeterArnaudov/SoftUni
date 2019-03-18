function solve(input) {
    input = input.split(/\. |, | /);

    for (let i = 0; i < input.length; i++) {
        let current = +input[i];

        if (!isNaN(current)) {
            if (current % 10 == 1) {
                console.log(`${current}st`);
            }
            else if (current % 10 == 2) {
                console.log(`${current}nd`);
            }
            else if (current % 10 == 3) {
                console.log(`${current}rd`);
            }
            else {
                console.log(`${current}th`);
            }
        }
    }
}

solve('Yesterday I bought 12 pounds of peppers, 31 kilograms of carrots and 5 kilograms of tomatoes.');