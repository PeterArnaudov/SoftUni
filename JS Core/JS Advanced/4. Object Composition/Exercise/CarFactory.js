function solve(carInfo) {
    let engines = [{power: 90, volume: 1800}, {power: 120, volume: 2400}, {power: 200, volume: 3500}];
    let carriages = [{type: 'hatchback', color: carInfo.color}, {type: 'coupe', color: carInfo.color}];
    let wheelSize = carInfo.wheelsize % 2 != 0 ? carInfo.wheelsize : carInfo.wheelsize - 1;

    let car = {
        model: carInfo.model,
        engine: engines.filter(e => e.power >= carInfo.power)[0],
        carriage: carriages.filter(c => c.type == carInfo.carriage)[0],
        wheels: [wheelSize, wheelSize, wheelSize, wheelSize]
    };

    return car;
}