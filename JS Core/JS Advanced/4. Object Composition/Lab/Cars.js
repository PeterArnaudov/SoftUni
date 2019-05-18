function solve(commands) {
     function createCarFactory() {
         let cars = {};

         return {
             create: (name) => cars[name] = {},
             inherit: (name, parentName) => Object.setPrototypeOf(cars[name], cars[parentName]),
             set: (name, key, value) => cars[name][key] = value,
             print: (name) => {
                 let infoArray = [];

                 for (let key in cars[name]) {
                     infoArray.push(`${key}:${cars[name][key]}`);
                 }

                 console.log(infoArray.join(', '));
             }
         }
     }

     let carFactory = createCarFactory();

     for (let commandLine of commands) {
         let commandTokens = commandLine.split(' ');
         let commandType = commandTokens[0];

         if (commandType == 'create') {
             carFactory.create(commandTokens[1]);

             if (commandTokens[2] == 'inherit') {
                 carFactory.create(commandTokens[1]);
                 carFactory.inherit(commandTokens[1], commandTokens[3]);
             }
         }
         else if (commandType == 'set') {
             carFactory.set(commandTokens[1], commandTokens[2], commandTokens[3]);
         }
         else if (commandType == 'print') {
             carFactory.print(commandTokens[1]);
         }
     }
}

solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
);