function solve(input) {
    let cities = new Map();

    for (let i = 0; i < input.length; i++) {
        let tokens = input[i].split(/ -> | : /);
        let cityName = tokens[0];
        let productName = tokens[1];
        let profit = tokens[2] * tokens[3];

        if (!cities.has(cityName)) {
            cities.set(cityName, new Map());
        }

        if (!cities.get(cityName).has(productName)) {
            cities.get(cityName).set(productName, 0);
        }

        cities.get(cityName).set(productName, cities.get(cityName).get(productName) + profit);
    }

    for (let town of cities) {
        console.log(`Town - ${town[0]}`);

        for (let [product, profit] of cities.get(town[0])) {
            console.log(`$$$${product} : ${profit}`);
        }
    }
}