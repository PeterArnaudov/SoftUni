function solve(arg) {
    let result;

    if (typeof arg == 'number') {
        result = (Math.PI * (arg * arg)).toFixed(2);
    }
    else {
        result = `We can not calculate the circle area, because we receive a ${typeof arg}.`
    }

    console.log(result);
}