function solve(input) {
    let rows = input[0];
    let cols = input[1];
    let starRow = input[2];
    let starCol = input[3];

    let matrix = [];
    for(let i = 0; i < rows; i++) {
        matrix[i] = [];
    }

    for(let i = 0; i < rows; i++) {
        for(let j = 0; j < cols; j++) {
            matrix[i][j] = Math.max(Math.abs(i - starRow), Math.abs(j - starCol)) + 1;
        }
    }

    console.log(matrix.map(row => row.join(" ")).join("\n"));
}