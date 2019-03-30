function solve(array) {
    let rotations = +array.pop();

    for (let i = 0; i < rotations % array.length; i++) {
        array.unshift(array.pop());
    }

    console.log(array.join(' '));
}