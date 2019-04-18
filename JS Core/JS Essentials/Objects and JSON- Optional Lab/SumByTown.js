function solve(input) {
    let towns = {};

    for (let i = 0; i < input.length; i+=2) {
        let townName = input[i];
        let value = +input[i + 1];

        if (!towns.hasOwnProperty(townName)) {
            towns[townName] = 0;
        }

        towns[townName] += value;
    }

    console.log(JSON.stringify(towns));
}