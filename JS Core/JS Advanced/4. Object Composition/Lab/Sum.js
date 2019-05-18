function result() {
    let elementOne;
    let elementTwo;
    let resultElement;

    return {
        init: (selectorOne, selectorTwo, resultSelector) => {
            elementOne = $(selectorOne);
            elementTwo = $(selectorTwo);
            resultElement = $(resultSelector);
        },
        add: () => resultElement.val(+elementOne.val() + +elementTwo.val()),
        subtract: () => resultElement.val(+elementOne.val() - +elementTwo.val())
    }
}