function showDetails(id) {
    $(`#${id}`).toggle();
}

$(() => {
    const contactsListRequest = $.get('contact-list.hbs');
    const contactInfoRequest = $.get('contact-info.hbs');

    Promise.all([contactsListRequest, contactInfoRequest])
        .then(([contactListHTML, contactInfoHTML]) => {
            Handlebars.registerPartial('contactInfo', contactInfoHTML);
            const template = Handlebars.compile(contactListHTML);

            const context = {
                contacts
            };

            const renderedHTML = template(context);

            $('body').append(renderedHTML);
        })
        .catch(e => console.log(e));
});