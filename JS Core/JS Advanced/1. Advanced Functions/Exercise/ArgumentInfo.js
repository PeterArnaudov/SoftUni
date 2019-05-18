function argumentInfo() {
    let typeCount = {};

    for (let arg of arguments) {
        console.log(`${typeof(arg)}: ${arg}`);

        if (!typeCount.hasOwnProperty(typeof(arg))) {
            typeCount[typeof(arg)] = 0;
        }

        typeCount[typeof(arg)]++;
    }

    for (let type of Object.entries(typeCount).sort((a, b) => b[1] - a[1])) {
        console.log(`${type[0]} = ${type[1]}`);
    }
}