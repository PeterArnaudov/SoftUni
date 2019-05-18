function solve(array) {
    let n = +array.pop();

    for (let i = 0; i < array.length; i+=n) {
        console.log(array[i]);
    }
}