function solve(array) {
    let output = [Number.MIN_SAFE_INTEGER];

    array.forEach(x => {if (x >= output[output.length - 1]) output.push(x)});
    output.shift();
    output.forEach(x => console.log(x));
}