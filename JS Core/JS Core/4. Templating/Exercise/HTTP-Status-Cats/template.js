function showInfo(id) {
    function changeButtonText() {
        $(this.parentNode.childNodes[1]).text(function(i, v){
            return v === 'Show status code' ? 'Hide status code' : 'Show status code'
        })
    }

    $(`#${id}`).toggle(changeButtonText);
}

$(() => {
    renderCatTemplate();

    function renderCatTemplate() {
        const catListRequest = $.get('cat-list.hbs');
        const catInfoRequest = $.get('cat-info.hbs');

        Promise.all([catListRequest, catInfoRequest])
            .then(([catList, catInfo]) => {
                Handlebars.registerPartial('catInfo', catInfo);
                const template = Handlebars.compile(catList);

                const context = {
                    cats
                };

                const renderedHTML = template(context);
                $('body').append(renderedHTML);
            })
            .catch(e => console.log(e));
    }
});
