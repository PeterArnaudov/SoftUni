function aggregate(input) {
    console.log(`Sum = ${input.reduce((a, b) => a + b)}`);
    console.log(`Min = ${input.reduce((a, b) => a < b ? a : b, Number.MAX_SAFE_INTEGER)}`);
    console.log(`Max = ${input.reduce((a, b) => a > b ? a : b, Number.MIN_SAFE_INTEGER)}`);
    console.log(`Product = ${input.reduce((a, b) => a * b)}`);
    console.log(`Join = ${input.reduce((a, b) => a += b, '')}`);
}