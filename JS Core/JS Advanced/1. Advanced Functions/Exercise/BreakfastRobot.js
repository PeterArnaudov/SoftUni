function solution() {
    let robot = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0,

        prepareRecipe: {
            apple: () => {
                if (robot.carbohydrate >= 1 && robot.flavour >= 2) {
                    robot.carbohydrate -= 1;
                    robot.flavour -= 2;

                    return [true];
                }
                else if (robot.carbohydrate < 1) {
                    return [false, 'carbohydrate'];
                }
                else if (robot.flavour < 2) {
                    return [false, 'flavour'];
                }
            },
            coke: () => {
                if (robot.carbohydrate >= 10 && robot.flavour >= 20) {
                    robot.carbohydrate -= 10;
                    robot.flavour -= 20;

                    return [true];
                }
                else if (robot.carbohydrate < 10) {
                    return [false, 'carbohydrate'];
                }
                else if (robot.flavour < 20) {
                    return [false, 'flavour'];
                }
            },
            burger: () => {
              if (robot.carbohydrate >= 5 && robot.fat >= 7 && robot.flavour >= 3) {
                  robot.carbohydrate -= 5;
                  robot.fat -= 7;
                  robot.flavour -= 3;

                  return [true];
              }
              else if (robot.carbohydrate < 5) {
                  return [false, 'carbohydrate'];
              }
              else if (robot.fat < 7) {
                  return [false, 'fat'];
              }
              else if (robot.flavour < 3) {
                  return [false, 'flavour'];
              }
            },
            omelet: () => {
              if (robot.protein >= 5 && robot.fat >= 1 && robot.flavour >= 1) {
                  robot.protein -= 5;
                  robot.fat -= 1;
                  robot.flavour -= 1;

                  return [true];
              }
              else if (robot.protein < 5) {
                  return [false, 'protein'];
              }
              else if (robot.fat < 1) {
                  return [false, 'fat'];
              }
              else if (robot.flavour < 1) {
                  return [false, 'flavour'];
              }
            },
            cheverme: () => {
                if (robot.protein >= 10 && robot.carbohydrate >= 10 && robot.fat >= 10 && robot.flavour >= 10) {
                    robot.protein -= 10;
                    robot.carbohydrate -= 10;
                    robot.fat -= 10;
                    robot.flavour -= 10;

                    return [true];
                }
                else if (robot.protein < 10) {
                    return [false, 'protein'];
                }
                else if (robot.carbohydrate < 10) {
                    return [false, 'carbohydrate'];
                }
                else if (robot.fat < 10) {
                    return [false, 'fat'];
                }
                else if (robot.flavour < 10) {
                    return [false, 'flavour'];
                }
            }
        },

        commands: {
            restock: (type, quantity) => {
                robot[type] += quantity;
                return 'Success';
            },
            prepare: (recipe, quantity) => {
                for (let i = 0; i < quantity; i++) {
                    let result = robot.prepareRecipe[recipe]();

                    if (!result[0]) {
                        return `Error: not enough ${result[1]} in stock`
                    }
                }

                return 'Success';
            },
            report: () => `protein=${robot.protein} carbohydrate=${robot.carbohydrate} fat=${robot.fat} flavour=${robot.flavour}`
        }
    };
    
    function manageCommand(command) {
        let commandArgs = command.split(' ');
        let commandType = commandArgs[0];

        if (commandType == 'restock') {
            let type = commandArgs[1];
            let quantity = +commandArgs[2];

            return robot.commands.restock(type, quantity);
        }
        else if (commandType == 'prepare') {
            let recipe = commandArgs[1];
            let quantity = +commandArgs[2];

            return robot.commands.prepare(recipe, quantity);
        }
        else if (commandType == 'report') {
            return robot.commands.report();
        }
    }

    return manageCommand;
}