function solve(array, number) {
    let gender = array.shift();
    let weight = array.shift();
    let height = array.shift();
    let age = array.shift();

    let basicMetabolism;

    if (gender == "f") {
        basicMetabolism = 655 + 9.7 * weight + 1.85 * height - 4.7 * age;
    }
    else if (gender == "m") {
        basicMetabolism = 66 + 13.8* weight + 5 * height - 6.8 * age;
    }

    let activeFactor;

    if (number == 1 || number == 2) {
        activeFactor = 1.375;
    }
    else if (number >= 3 && number <= 5) {
        activeFactor = 1.55;
    }
    else if (number == 6 || number == 7) {
        activeFactor = 1.725;
    }
    else if (number > 7) {
        activeFactor = 1.9;
    }
    else {
        activeFactor = 1.2;
    }

    let calorieIntake = basicMetabolism * activeFactor;

    console.log(Math.round(calorieIntake));
}