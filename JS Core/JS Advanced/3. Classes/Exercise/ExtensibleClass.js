(() => {
    let id = 0;

    return class Extensible {
        constructor() {
            this.id = id++;
        }

        extend(template) {
            for (let property of Object.getOwnPropertyNames(template)) {
                if (typeof(template[property]) == "function") {
                    Extensible.prototype[property] = template[property];
                }
                else {
                    this[property] = template[property];
                }
            }
        }
    }
})();