function solve() {
    let inputElement = document.getElementById('str');
    let resultElement = document.getElementById('result');

    let input = inputElement.value.split(', ');
    let firstPart = input[0];
    let secondPart = input[1];

    let nameRegex = new RegExp(' ([A-Z][A-Za-z]*-[A-Z][A-Za-z]*(?:\\.-(?:[A-Z][A-Za-z]*))*) ', 'g');
    let airportRegex = new RegExp(' ([A-Z]{3}\\/[A-Z]{3}) ', 'g');
    let flightNumberRegex = new RegExp(' ([A-Z]{1,3}\\d{1,5}) ', 'g');
    let companyRegex = new RegExp('- ([A-Z][A-Za-z]*\\*[A-Z][A-Za-z]*) ', 'g');

    let passengerName = nameRegex.exec(firstPart)[1].toString();
    let airports = airportRegex.exec(firstPart)[1].toString().split('/');
    let fromAirport = airports[0];
    let toAirport = airports[1];
    let flightNumber = flightNumberRegex.exec(firstPart)[1].toString();
    let company = companyRegex.exec(firstPart)[1].toString();

    passengerName = passengerName.replace(/\-/g, ' ');
    company = company.replace('*', ' ');

    let outputName = `Mr/Ms, ${passengerName}, have a nice flight!`;
    let outputFlight = `Your flight number ${flightNumber} is from ${fromAirport} to ${toAirport}.`;
    let outputCompany = `Have a nice flight with ${company}.`;
    let outputAll = `Mr/Ms, ${passengerName}, your flight number ${flightNumber} is from ${fromAirport} to ${toAirport}. ${outputCompany}`;

    if (secondPart == 'name') {
        resultElement.textContent = outputName;
    }
    else if (secondPart == 'flight') {
        resultElement.textContent = outputFlight;
    }
    else if (secondPart == 'company') {
        resultElement.textContent = outputCompany;
    }
    else if (secondPart == 'all') {
        resultElement.textContent = outputAll;
    }
}