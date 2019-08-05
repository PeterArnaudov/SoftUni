class Vacation {
    constructor(organizer, destination, budget) {
        this.organizer = organizer;
        this.destination = destination;
        this.budget = budget;
        this.kids = {};
        this._numberOfChildren = 0;
    }

    registerChild(name, grade, budget) {
        if (this.budget <= budget) {
            if (!this.kids.hasOwnProperty(grade)) {
                this.kids[grade] = [];
            }

            if (!this.kids[grade].some(x => x.split('-')[0].includes(name))) {
                this.kids[grade].push([name, budget].join('-'));
                this._numberOfChildren++;
                return this.kids[grade];
            }
            else {
                return `${name} is already in the list for this ${this.destination} vacation.`;
            }
        }
        else {
            return `${name}'s money is not enough to go on vacation to ${this.destination}.`;
        }
    }

    removeChild(name, grade) {
        if (this.kids.hasOwnProperty(grade) && this.kids[grade].some(x => x.split('-')[0].includes(name))) {
            let index = this.kids[grade].indexOf(name);

            this.kids[grade].splice(index - 1, 1);
            this._numberOfChildren--;

            return this.kids[grade];
        }
        else {
            return `We couldn't find ${name} in ${grade} grade.`;
        }
    }

    get numberOfChildren() {
        return this._numberOfChildren;
    }

    toString() {
        if (this.numberOfChildren == 0) {
            return `No children are enrolled for the trip and the organization of ${this.organizer} falls out...`;
        }

        let gradesInfo = '';
        let orderedGrades = Object.keys(this.kids).sort((a, b) => a-b);

        for (let grade of orderedGrades) {
            if (this.kids[grade].length != 0) {
                gradesInfo += `Grade: ${grade}\n`;
                let counter = 0;

                for (let kid of this.kids[grade]) {
                    counter++;
                    gradesInfo += `${counter}. ${kid}\n`;
                }
            }
        }
        let organizerInfo = `${this.organizer} will take ${this.numberOfChildren} children on trip to ${this.destination}\n`;

        return organizerInfo + gradesInfo;
    }
}

function solve() {
    let vacation = new Vacation('Mr Pesho', 'San diego', 2000);

    console.log(vacation.registerChild('Gosho', 5, 2000));
    console.log(vacation.registerChild('Lilly', 6, 2100));
    console.log(vacation.removeChild('Lilly', 6));

    console.log(vacation.numberOfChildren);
    console.log(vacation.toString());

}

solve();