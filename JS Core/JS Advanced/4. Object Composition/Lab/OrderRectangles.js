function solve(array) {
    let rectangles = [];

    for (let rectInfo of array) {
        let rectangle = {
            width: rectInfo[0],
            height: rectInfo[1],
            area: () => rectangle.width * rectangle.height,
            compareTo: other => {
                if (rectangle.area() < other.area()) return 1;
                if (rectangle.area() > other.area()) return -1;
                if (rectangle.width < other.width) return 1;
                if (rectangle.width > other.width) return -1;
                return 0;
            }
        }

        rectangles.push(rectangle);
    }


    let sortedRectangles = rectangles.sort((a, b) => a.compareTo(b));

    return sortedRectangles;
}