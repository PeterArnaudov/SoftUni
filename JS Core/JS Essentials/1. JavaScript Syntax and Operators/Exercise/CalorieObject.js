function solve(array) {
    let object = {};

    for (let i = 0; i < array.length; i+=2) {
        let propertyName = array[i];
        let propertyValue = +array[i + 1];
        object[propertyName] = propertyValue;
    }

    console.log(object);
}