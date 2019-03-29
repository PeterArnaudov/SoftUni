function solve(arr1, arr2, arr3) {
    let sumLength;
    let averageLength;

    let firstArgumentLength = arr1.length;
    let secondArgumentLength = arr2.length;
    let thirdArgumentLength = arr3.length;

    let sumLenghts = firstArgumentLength + secondArgumentLength + thirdArgumentLength;
    let avgLength = Math.floor(sumLenghts / 3);

    console.log(sumLenghts);
    console.log(avgLength);
}