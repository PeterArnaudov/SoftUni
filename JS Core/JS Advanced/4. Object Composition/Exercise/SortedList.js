function sortedList() {
    let numbers = [];

    return {
        size: 0,

        add: function(element) {
            numbers.push(element);
            this.size++;

            numbers = numbers.sort((a, b) => a - b);

            return numbers;
        },

        remove: function(index) {
            if (index >= 0 && index < numbers.length) {
                numbers.splice(index, 1);
                this.size--;

                return numbers;
            }
        },

        get: function(index) {
            if (index >= 0 && index < numbers.length) {
                return numbers[index];
            }
        }
    }
}