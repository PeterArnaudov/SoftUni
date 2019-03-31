function solve(matrix) {
    let leftDiagonalSum = 0;
    let rightDiagonalSum = 0;

    matrix = matrix.map(row => row.split(' '). map(Number));

    for (let i = 0, j = 0; i < matrix.length; i++, j++) {
        leftDiagonalSum += +matrix[i][j];
    }

    for (let i = 0, j = matrix.length - 1; i < matrix.length; i++, j--) {
        rightDiagonalSum += +matrix[i][j];
    }

    if (leftDiagonalSum == rightDiagonalSum) {
        for (let i = 0, k = matrix.length - 1; i < matrix.length; i++, k--) {
            for (let j = 0; j < matrix[i].length; j++) {
                if (j != i && j != k) {
                    matrix[i][j] = leftDiagonalSum;
                }
            }
        }
    }

    matrix.forEach(x => console.log(x.join(' ')));
}