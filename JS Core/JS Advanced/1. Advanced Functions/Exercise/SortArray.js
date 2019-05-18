function sortArray(array, order) {
    if (order == 'asc') {
        return array.sort((a, b) => a-b);
    }
    else {
        return array.sort((a, b) => b-a);
    }
}