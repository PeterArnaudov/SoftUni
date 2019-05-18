class SortedList {
    constructor() {
        this.numbers = [];
        this.size = 0;
    }

    add(element) {
        this.numbers.push(element);
        this.size++;

        this.numbers = this.numbers.sort((a, b) => a-b);

        return this.numbers;
    }

    remove(index) {
        if (index >= 0 && index < this.numbers.length) {
            this.numbers.splice(index, 1);
            this.size--;

            return this.numbers;
        }
    }

    get(index) {
        if (index >= 0 && index < this.numbers.length) {
            return this.numbers[index];
        }
    }
}