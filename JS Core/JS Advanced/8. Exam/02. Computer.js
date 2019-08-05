class Computer {
    constructor(ramMemory, cpuGHz, hddMemory) {
        this.ramMemory = ramMemory;
        this.cpuGHz = cpuGHz;
        this.hddMemory = hddMemory;
        this.taskManager = [];
        this.installedPrograms = [];
        this.totalRamUsage = 0;
        this.totalCpuUsage = 0;
    }

    installAProgram(name, requiredSpace) {
        if (this.hddMemory < requiredSpace) {
            throw new Error("There is not enough space on the hard drive");
        }
        else {
            let program = {
                name,
                requiredSpace
            };

            this.installedPrograms.push(program);
            this.hddMemory -= requiredSpace;

            return program;
        }
    }

    uninstallAProgram(name) {
        if (this.installedPrograms.filter(x => x.name === name).length === 0) {
            throw new Error('Control panel is not responding')
        }
        else {
            for (let i = 0; i < this.installedPrograms.length; i++) {
                if (this.installedPrograms[i].name === name) {
                    this.hddMemory += this.installedPrograms[i].requiredSpace;
                    this.installedPrograms.splice(i, 1);
                    return this.installedPrograms;
                }
            }
        }
    }

    openAProgram(name) {
        if (this.installedPrograms.filter(x => x.name === name).length === 0) {
            throw new Error(`The ${name} is not recognized`)
        }
        else if (this.taskManager.filter(x => x.name === name).length === 1) {
            throw new Error(`The ${name} is already open`)
        }
        else {
            let program = this.installedPrograms.find(x => x.name === name);
            let ramUsage = (program.requiredSpace / this.ramMemory) * 1.5;
            let cpuUsage = ((program.requiredSpace / this.cpuGHz) / 500) * 1.5;

            let openedProgram = {
                name: program.name,
                ramUsage: ramUsage,
                cpuUsage: cpuUsage
            };

            this.totalRamUsage += ramUsage;
            this.totalCpuUsage += cpuUsage;

            if (this.totalRamUsage >= 100) {
                throw new Error(`${program.name} caused out of memory exception`);
            }

            if (this.totalCpuUsage >= 100) {
                throw new Error(`${program.name} caused out of cpu exception`)
            }

            this.taskManager.push(openedProgram);
            return openedProgram;
        }
    }

    taskManagerView() {
        if (this.taskManager.length === 0) {
            return 'All running smooth so far';
        }
        else {
            let output = [];

            this.taskManager.forEach(x => {
                output.push(`Name - ${x.name} | Usage - CPU: ${Math.round(x.cpuUsage)}%, RAM: ${Math.round(x.ramUsage)}%`);
            });

            return output.join('\n');
        }
    }

    get availableSpace() {
        return this.hddMemory;
    }
}

function solve() {
    let computer = new Computer(4096, 7.5, 250000);

    computer.installAProgram('Word', 7300);
    computer.installAProgram('Excel', 10240);
    computer.installAProgram('PowerPoint', 12288);
    computer.uninstallAProgram('Word');
    computer.installAProgram('Solitare', 1500);

    computer.openAProgram('Excel');
    computer.openAProgram('Solitare');

    console.log(computer.installedPrograms);
    console.log(computer.taskManager);



}

solve();