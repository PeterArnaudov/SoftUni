function GreatestCommonDivisor(a, b) {
    while (a != b) {
        if (a > b) {
            a = a - b;
        }
        else {
            b = b - a;
        }
    }

    console.log(a);
}