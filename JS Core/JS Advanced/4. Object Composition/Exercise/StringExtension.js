(function extendString() {
    String.prototype.ensureStart = function (string) {
        if (!this.startsWith(string)) {
            return string + this.toString();
        }

        return this.toString();
    };

    String.prototype.ensureEnd = function (string) {
        if (!this.endsWith(string)) {
            return this.toString() + string;
        }

        return this.toString();
    };

    String.prototype.isEmpty = function () {
        return this.toString().length === 0;
    };

    String.prototype.truncate = function (n) {
        if (this.toString().length <= n) {
            return this.toString();
        }
        else {
            if (this.toString().includes(' ')) {
                let words = this.toString().split(' ');
                let newString = '';

                while (newString.length + words[0].length + 3 <= n) {
                    newString += words.shift() + ' ';
                }

                newString = newString.trim() + '...';

                return newString;
            }
            else {
                if (n < 4) {
                    return '.'.repeat(n);
                }
                else {
                    return this.toString().slice(0, n - 3) + '...';
                }
            }
        }
    };

    String.format = function (string, ...params) {
        for (let i = 0; i < params.length; i++) {
            string = string.replace(`{${i}}`, params[i]);
        }

        return string;
    }
})();