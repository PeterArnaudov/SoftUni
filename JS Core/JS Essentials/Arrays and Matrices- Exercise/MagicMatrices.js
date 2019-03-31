function solve(matrix) {
    let sum = 0;
    for (let i = 0; i < matrix[0].length; i++) {
        sum += matrix[0][i];
    }

    for (let i = 1; i < matrix.length; i++) {
        let currentSum = 0;
        for (let j = 0; j < matrix[i].length; j++) {
            currentSum += matrix[i][j];
        }
        if (currentSum != sum) {
            return false;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        let currentSum = 0;
        for (let j = 0; j < matrix.length; j++) {
            currentSum += matrix[i][j];
        }
        if (currentSum != sum) {
            return false;
        }
    }

    return true;
}