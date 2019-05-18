(function getVectorMath() {
    return {
        add: (vecOne, vecTwo) => [vecOne[0] + vecTwo[0], vecOne[1] + vecTwo[1]],
        multiply: (vecOne, scalar) => [vecOne[0] * scalar, vecOne[1] * scalar],
        length: vecOne => Math.sqrt(vecOne[0] * vecOne[0] + vecOne[1] * vecOne[1]),
        dot: (vecOne, vecTwo) => vecOne[0] * vecTwo[0] + vecOne[1] * vecTwo[1],
        cross: (vecOne, vecTwo) => vecOne[0] * vecTwo[1] - vecOne[1] * vecTwo[0]
    }
})();