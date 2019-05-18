function solve(array, number = 1, output = []) {
    array.forEach(x => {
        x == 'add' ? output.push(number) : output.pop();
        number++;
    });

    output.length > 0 ? output.forEach(x => console.log(x)) : console.log('Empty');
}