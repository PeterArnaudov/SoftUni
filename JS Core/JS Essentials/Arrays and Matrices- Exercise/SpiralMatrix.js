function solve(rows, cols) {
    let matrix = [];

    for (let i = 0; i < rows; i++) {
        matrix[i] = [];
    }

    let number = 1;
    let k = 0;
    let l = 0;

    while (k < rows && l < cols) {
        for (let i = l; i < cols; ++i) {
            matrix[k][i] = number++;
        }
        k++;

        for (let i = k; i < rows; ++i) {
            matrix[i][cols - 1] = number++;
        }
        cols--;

        if (k < rows) {
            for (let i = cols - 1; i >= l ; --i) {
                matrix[rows - 1][i] = number++;
            }
            rows--;
        }

        if (l < cols) {
            for (let i = rows - 1; i >= k; --i) {
                matrix[i][l] = number++;
            }
            l++;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        console.log(matrix[i].join(' '));
    }
}