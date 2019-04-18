function solve(input) {
    let towns = {};

    for (let token of input) {
        let townName = token.split(' <-> ')[0];
        let population = +token.split(' <-> ')[1];

        if (!towns.hasOwnProperty(townName)) {
            towns[townName] = 0;
        }

        towns[townName] += population;
    }

    for (let town of Object.entries(towns)) {
        console.log(`${town[0]} : ${town[1]}`);
    }
}