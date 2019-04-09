function solve(input) {
    let allWords = input[0].match(/\w+/g);
    let wordsCount = {};

    for (let word of allWords) {
        if (!wordsCount.hasOwnProperty(word)) {
            wordsCount[word] = 0;
        }

        wordsCount[word]++;
    }

    console.log(JSON.stringify(wordsCount));
}