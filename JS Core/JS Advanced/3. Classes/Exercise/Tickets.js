function solve(ticketsData, sortCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let tickets = [];

    for (let data of ticketsData) {
        let dataTokens = data.split('|');
        let destination = dataTokens[0];
        let price = +dataTokens[1];
        let status = dataTokens[2];

        let ticket = new Ticket(destination, price, status);
        tickets.push(ticket);
    }

    let sortedTickets = tickets.sort((a, b) => (a[sortCriteria] < b[sortCriteria]) ? -1 : (a[sortCriteria] > b[sortCriteria]) ? 1 : 0);

    return sortedTickets;
}