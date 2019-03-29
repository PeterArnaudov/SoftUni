function solve() {
    function multiplyMatrices(m1, m2) {
        let result = [];
        for (let i = 0; i < m1.length; i++) {
            result[i] = [];
            for (let j = 0; j < m2[0].length; j++) {
                let sum = 0;
                for (let k = 0; k < m1[0].length; k++) {
                    sum += m1[i][k] * m2[k][j];
                }
                result[i][j] = sum;
            }
        }
        return result;
    }

    function displayMatrix(matrix) {
        let output = '';
        for (let i = 0; i < matrix.length; i++) {
            let row = matrix[i].join(', ');
            output += `<p>${row}</p>`;
        }
        return output;
    }

    function getMatrix(input) {
        let matrix = [];
        let rows = input.split('], ');
        for (let i = 0; i < rows.length; i++) {
            let element = rows[i];
            element = element.replace(/\[/g, '');
            element = element.replace(/\]/g, '');
            let row = element.split(', ').map(Number);
            matrix.push(row);
        }
        return matrix;
    }

    let fstMatrixInput = document.getElementById('mat1').value;
    let sndMatrixInput = document.getElementById('mat2').value;

    let fstMatrix = getMatrix(fstMatrixInput);
    let sndMatrix = getMatrix(sndMatrixInput);
    sndMatrix = sndMatrix[0].map((col, i) => sndMatrix.map(row => row[i]));

    let result = multiplyMatrices(fstMatrix, sndMatrix);
    let output = displayMatrix(result);

    document.getElementById('result').innerHTML = output;
}