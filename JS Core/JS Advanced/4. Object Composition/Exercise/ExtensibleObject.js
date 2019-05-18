function solve() {
    let extensibleObject = {
        __proto__: {},
        extend: function (template) {
            for (let propertyName of Object.getOwnPropertyNames(template)) {
                if (typeof(template[propertyName]) == "function") {
                    this.__proto__[propertyName] = template[propertyName];
                }
                else {
                    this[propertyName] = template[propertyName];
                }
            }
        }
    };

    return extensibleObject;
}