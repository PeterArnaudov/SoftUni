function subsum(array, startIndex, endIndex) {
    if (!Array.isArray(array)) {
        return NaN;
    }

    if (startIndex < 0) {
        startIndex = 0;
    }

    if (endIndex >= array.length) {
        endIndex = array.length - 1;
    }

    if (array.length == 0) {
        return 0;
    }

    return array.map(a => Number(a)).slice(startIndex, endIndex + 1).reduce((a, b) => a + b);
}