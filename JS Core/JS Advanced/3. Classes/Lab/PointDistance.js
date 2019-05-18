class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(pointOne, pointTwo) {
        return Math.sqrt(Math.pow((pointTwo.x - pointOne.x), 2) + Math.pow((pointTwo.y - pointOne.y), 2));
    }
}