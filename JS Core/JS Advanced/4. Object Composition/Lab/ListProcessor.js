function solve(commands)
{
    function getListProcessor() {
        let collection = [];

        return {
            add: (string) => collection.push(string),
            remove: (string) => collection = collection.filter(x => x != string),
            print: () => console.log(collection.join(','))
        }
    }

    let listProcessor = getListProcessor();

    for (let commandLine of commands) {
        let commandTokens = commandLine.split(' ');
        let commandType = commandTokens[0];

        if (commandType == 'add') {
            listProcessor.add(commandTokens[1]);
        }
        else if (commandType == 'remove') {
            listProcessor.remove(commandTokens[1]);
        }
        else if (commandType == 'print') {
            listProcessor.print();
        }
    }
}