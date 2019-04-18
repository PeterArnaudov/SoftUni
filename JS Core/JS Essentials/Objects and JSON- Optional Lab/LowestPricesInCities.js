function solve(input) {
    let products = new Map();

    for (let i = 0; i < input.length; i++) {
        let tokens = input[i].split(' | ');
        let productName = tokens[1];
        let cityName = tokens[0];
        let price = tokens[2];

        if (!products.has(productName)) {
            products.set(productName, new Map());
        }

        products.get(productName).set(cityName, +price);
    }

    for (let [product, cities] of products) {
        let lowestPrice = Number.POSITIVE_INFINITY;
        let lowestPriceCity = '';

        for (let [city, price] of cities) {
            if (lowestPrice > price) {
                lowestPrice = price;
                lowestPriceCity = city;
            }
        }

        console.log(`${product} -> ${lowestPrice} (${lowestPriceCity})`);
    }
}