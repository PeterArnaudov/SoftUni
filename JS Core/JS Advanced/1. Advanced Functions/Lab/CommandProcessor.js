function solve(array) {
    function getCommandProcessor() {
        let string = '';

        return {
            append: str => string = string.concat(str),
            removeStart: n => string = string.slice(+n),
            removeEnd: n => string = string.slice(0, string.length - +n),
            print: () => console.log(string)
        }
    }

    let commandProcessor = getCommandProcessor();

    for (let command of array) {
        let commandTokens = command.split(' ');
        let commandType = commandTokens[0];
        let commandValue = commandTokens[1];

        commandProcessor[commandType](commandValue);
    }
}