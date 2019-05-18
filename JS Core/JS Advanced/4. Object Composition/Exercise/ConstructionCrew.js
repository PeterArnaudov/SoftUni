function solve(worker) {
    if (worker.handsShaking) {
        worker.bloodAlcoholLevel = worker.weight * worker.experience * 0.1 + worker.bloodAlcoholLevel;
        worker.handsShaking = false;
    }

    return worker;
}

console.log(solve({ weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true }

));