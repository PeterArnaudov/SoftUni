function solve(input) {
    let allWords = input[0].match(/\w+/g);
    let wordsCount = new Map();

    for (let word of allWords) {
        if (!wordsCount.has(word.toLowerCase())) {
            wordsCount.set(word.toLowerCase(), 1);
        }
        else {
            wordsCount.set(word.toLowerCase(), wordsCount.get(word.toLowerCase()) + 1);
        }
    }

    wordsCount = Array.from(wordsCount).sort()
    for (let word of wordsCount) {
        console.log(`'${word[0]}' -> ${word[1]} times`);
    }
}