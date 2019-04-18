function solve(input) {
    let towns = [];
    let splitRegex = /\s*\|\s*/;

    for (let i = 1; i < input.length; i++) {
        let currentTown = {};
        let currentString = input[i].split(splitRegex).filter(x => x);
        currentTown["Town"] = currentString[0];
        currentTown["Latitude"] = +currentString[1];
        currentTown["Longitude"] = +currentString[2];

        towns.push(currentTown);
    }

    let JSONTowns = JSON.stringify(towns);
    console.log(JSONTowns);
}