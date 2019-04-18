function solve(input) {
    let uniqueWords = new Set();

    for (let i = 0; i < input.length; i++) {
        let words = input[i].match(/\w+/g);

        for (let word of words) {
            uniqueWords.add(word.toLowerCase());
        }
    }

    console.log(Array.from(uniqueWords).join(', '));
}