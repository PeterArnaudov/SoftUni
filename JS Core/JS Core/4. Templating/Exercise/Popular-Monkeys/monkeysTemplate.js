function showInfo(id) {
    $(`#${id}`).toggle();
}

$(() => {
    $.get('monkey-info.hbs')
        .then(monkeyInfoTemplateRaw => {
            const template = Handlebars.compile(monkeyInfoTemplateRaw);

            const context = {
                monkeys
            };

            const renderedHTML = template(context);
            $('.monkeys').append(renderedHTML);
        })
});