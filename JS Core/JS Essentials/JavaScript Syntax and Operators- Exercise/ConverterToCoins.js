function solve(amount, arrayOfCoins) {
    arrayOfCoins.sort(function(a, b){return b-a});

    let coins = [];

    for (let i = 0; i < arrayOfCoins.length; i++) {
        while (amount >= arrayOfCoins[i]) {

            coins.push(arrayOfCoins[i]);
            amount -= arrayOfCoins[i];
        }
    }

    console.log(coins.join(", "));
}